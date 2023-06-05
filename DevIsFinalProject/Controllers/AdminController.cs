using Microsoft.AspNetCore.Mvc;

namespace DevIsFinalProject.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult PostJob()
        {
            return View();
        }
    }
}
