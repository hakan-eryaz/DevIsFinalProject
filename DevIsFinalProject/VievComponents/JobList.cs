using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace DevIsFinalProject.VievComponents
{
    public class JobList:ViewComponent
    {
        JobManager jobManager = new JobManager(new EFJobRepository());
        public IViewComponentResult Invoke()
        {
            var values = jobManager.GetJobWithCategory();
            return View(values);
        }
    }
}
