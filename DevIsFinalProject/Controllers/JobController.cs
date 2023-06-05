using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DevIsFinalProject.Controllers
{
    public class JobController : Controller
    {
        JobManager jobManager=new JobManager(new EFJobRepository());
        private ResumeManager resumeManager = new ResumeManager(new EfResumeRepository());
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
        [HttpGet]
        public IActionResult ApplyJob()
        {

            return View();
        }
        [HttpPost]
        public IActionResult ApplyJob(Resume resume ,int id)
        {
            resume.JobSeekerID = 1;
            resumeManager.TAdd(resume);
            return View();
        }

        public IActionResult Quiz(int id)
        {
            var value = jobManager.GetJobByID(id);
            return View(value);
        }
    }
}
