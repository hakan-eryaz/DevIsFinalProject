using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DevIsFinalProject.Controllers
{
    public class JobController : Controller
    {
        JobManager jobManager=new JobManager(new EFJobRepository());
        public IActionResult JobList()
        {
            var values = jobManager.GetJobWithCategory();
            return View(values);
        }

        public IActionResult JobDetails(int id)
        {
            var value = jobManager.GetJobByID(id);
            return View(value);
        }

        public IActionResult ApplyJob(int id)
        {
            var value = jobManager.GetJobByID(id);
            return View(value);
        }

        public IActionResult Quiz(int id)
        {
            var value = jobManager.GetJobByID(id);
            return View(value);
        }
    }
}
