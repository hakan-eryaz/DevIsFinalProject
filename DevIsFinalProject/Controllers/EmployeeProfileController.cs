using Microsoft.AspNetCore.Mvc;

namespace DevIsFinalProject.Controllers
{
    public class EmployeeProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
