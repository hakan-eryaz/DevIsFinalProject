using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DevIsFinalProject.Controllers
{
    public class JobController : Controller
    {
        JobManager jobManager=new JobManager(new EFJobRepository());
         ApplicationManager applicationManager = new ApplicationManager(new EfApplicationRepository());
        ResumeManager resumeManager = new ResumeManager(new EfResumeRepository());

        public IActionResult JobList()
        {
            var values = jobManager.GetJobWithCategory();
            return View(values);
        }
        
        public IActionResult JobDetails(int id)
        {
            var value = jobManager.GetAllInfoAboutJob(id);
            return View(value);
        }
        [HttpGet]
        public IActionResult ApplyJob()
        {
            

            return View();
        }
        [HttpPost]
        public IActionResult ApplyJob(Resume resume)
        {
            Application application = new Application(); ;
            application.ApplicationDate = DateTime.Now;
            application.JobSeekerID = (int)HttpContext.Session.GetInt32("User");
            application.JobID = (int)HttpContext.Session.GetInt32("Job");


            applicationManager.TAdd(application);
            resume.JobSeekerID= (int)HttpContext.Session.GetInt32("User");
            resumeManager.TAdd(resume);

            return RedirectToAction("JobList", "Job");
        }

        public IActionResult Quiz(int id)
        {
            var value = jobManager.GetJobByID(id);
            return View(value);
        }
    }
}
