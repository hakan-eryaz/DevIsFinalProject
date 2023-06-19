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
        [HttpGet]
        public IActionResult Login()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user=jobSeekerManager.GetByEmailAndPassword(email, password);
            HttpContext.Session.SetInt32("User",user.JobSeekerID);
            if (user.IsAdmin==1)
            {
                return RedirectToAction("Index", "Admin");
            }
            else if(user.IsAdmin == 0)
            {
                return RedirectToAction("JobList", "Job");

            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }
        
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("User");

            return RedirectToAction("Index", "Home");
            
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
            return RedirectToAction("Login", "Account");

        }
    }
}
