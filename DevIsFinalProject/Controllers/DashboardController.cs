using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevIsFinalProject.Controllers
{
    public class DashboardController : Controller
    {
        JobManager jobManager = new JobManager(new EFJobRepository());
        ContactManager contactManager = new ContactManager(new EfContactRepository());
        private SkillManager skillManager = new SkillManager(new EfSkillsRepository());
        JobCategoryManager jobCategoryManager = new JobCategoryManager(new EFJobCategoryRepository());
        private ResumeManager resumeManager = new ResumeManager(new EfResumeRepository());
        private JobSeekerManager jobSeekerManager = new JobSeekerManager(new EfJobSeekerRepository());
        public IActionResult Index()
        {
            var values = jobManager.GetJobWithCategory();
            return View(values);
        }
        [HttpGet]
        public IActionResult JobCategoryAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult JobCategoryAdd(JobCategory jobCategory)
        {
            jobCategoryManager.TAdd(jobCategory);

            return RedirectToAction("JobPost", "Dashboard");
        }
        [HttpGet]
        public IActionResult JobPost()
        {
            var veriler =jobCategoryManager.GetAll();
            ViewBag.Veriler = veriler;
            
            return View();
        }
        [HttpPost]
        public IActionResult JobPost(Job job)
        {
            job.PostedDate= DateTime.Now;
            job.ExpirationDate= job.PostedDate.AddDays(30);
            job.EmployerID = 1;
            job.JobStatus = 1;
            jobManager.TAdd(job);
            return RedirectToAction("Index", "Dashboard");
        }

        [HttpGet]
        public IActionResult JobUpdate(int id)
        {
            var veriler = jobCategoryManager.GetAll();
            ViewBag.Veriler = veriler;
            var value = jobManager.GetJobByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult JobUpdate(Job job)
        {
            job.EmployerID = 1;
            job.JobStatus = 1;
            jobManager.TUpdate(job);
            return RedirectToAction("Index", "Dashboard");
        }
        [HttpGet]
        public IActionResult ContactList()
        {

            var value = contactManager.GetAll();
            return View(value);
        }
        [HttpPost]
        public IActionResult ContactList(Contact contact)
        {
            
            return RedirectToAction("Index", "Dashboard");
        }
        [HttpGet]
        [HttpPost]
        public IActionResult JobDelete(int id)
        {
            var job = jobManager.GetById(id);
            jobManager.TRemove(job);
            
            return RedirectToAction("Index", "Dashboard");
        }
        [HttpGet]
        public IActionResult SkillAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SkillAdd(Skill skill)
        {
            skillManager.TAdd(skill);

            return RedirectToAction("JobPost", "Dashboard");
        }
        [HttpGet]
        public IActionResult JobSeekerList()
        {
            var result=jobSeekerManager.GetAll();
            return View(result);
        }
        [HttpPost]
        public IActionResult JobSeekerList(JobSeeker jobSeeker)
        {
            jobSeekerManager.TAdd(jobSeeker);

            return RedirectToAction("JobPost", "Dashboard");
        }

        [HttpGet]
        public IActionResult JobSeekerDetail(int id)
        {
            var result = jobSeekerManager.GetListWithSkill(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult JobSeekerDetail(JobSeeker jobSeeker)
        {
            jobSeekerManager.TAdd(jobSeeker);

            return RedirectToAction("JobPost", "Dashboard");
        }
    }
}
