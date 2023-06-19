using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DevIsFinalProject.Controllers
{
    public class UserController : Controller
    {
        JobSeekerManager jobSeekerManager =new JobSeekerManager(new EfJobSeekerRepository());

        public IActionResult Index()
        {
            var id =(int)HttpContext.Session.GetInt32("User");

            var result = jobSeekerManager.GetListWithSkill(id);
            return View(result);
        }
    }
}
