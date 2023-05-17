using Microsoft.AspNetCore.Mvc;

namespace DevIsFinalProject.Controllers
{
    public class QuizController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
