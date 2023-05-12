using Microsoft.AspNetCore.Mvc;

namespace DevIsFinalProject.Controllers
{
    public class SignInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
