using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DevIsFinalProject.Controllers
{
    public class UserController : Controller
    {
        JobSeekerManager jobSeekerManager =new JobSeekerManager(new EfJobSeekerRepository());

        public IActionResult Index()
        {
            var result = jobSeekerManager.GetById(1);
            return View(result);
        }
    }
}
