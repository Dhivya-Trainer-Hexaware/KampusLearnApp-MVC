using KampusLearnApp_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace KampusLearnApp_MVC.Controllers
{
    public class TrainerController : Controller
    {
        private readonly KampusLearnDbContext dbContext;

        public TrainerController(KampusLearnDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
       
        [HttpGet]
        public IActionResult Index()
        {
         
            List<Trainer> trainers = dbContext.Trainers.ToList();

            //passing the data from a controller to View Using Models
            return View(trainers);
        }
        [HttpGet]
        public IActionResult GetTrainerDetail(int trainerID)
        {
            Trainer trainer = dbContext.Trainers.Find(trainerID);
            return View(trainer);
        }

        [HttpGet]
        public IActionResult DeleteTrainer(int trainerId)
        {
            Trainer trainer = dbContext.Trainers.Find(trainerId);
            dbContext.Trainers.Remove(trainer);//Delete query to delete the row
            dbContext.SaveChanges();// Execute the sql query.
            return RedirectToAction("Index");


        }

        [HttpGet]
        public IActionResult AddNewTrainer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewTrainer(Trainer trainer)
        {
            if (ModelState.IsValid)
            {
                dbContext.Trainers.Add(trainer);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

    }
}
