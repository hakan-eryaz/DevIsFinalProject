using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DevIsFinalProject.Controllers
{
    public class AccountController : Controller
    {
        private JobSeekerManager jobSeekerManager = new JobSeekerManager(new EfJobSeekerRepository());
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register( JobSeeker jobSeeker)
        {

            jobSeeker.JobSeekerStatus = 1;
            jobSeekerManager.TAdd(jobSeeker);
            return View();
        }
    }
}
