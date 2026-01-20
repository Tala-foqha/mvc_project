using Microsoft.AspNetCore.Mvc;

namespace mvc_project.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
