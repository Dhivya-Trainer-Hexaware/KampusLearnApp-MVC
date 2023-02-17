using Microsoft.AspNetCore.Mvc;

namespace KampusLearnApp_MVC.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
