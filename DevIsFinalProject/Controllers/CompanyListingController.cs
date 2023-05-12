using Microsoft.AspNetCore.Mvc;

namespace DevIsFinalProject.Controllers
{
    public class CompanyListingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
