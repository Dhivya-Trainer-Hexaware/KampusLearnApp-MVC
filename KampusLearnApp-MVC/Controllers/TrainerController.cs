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
        public IActionResult Index()
        {
            List<Trainer> trainers = dbContext.Trainers.ToList();

            //passing the data from a controller to View Using Models
            return View(trainers);
        }
    }
}
