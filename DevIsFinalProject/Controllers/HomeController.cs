using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevIsFinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevIsFinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        JobCategoryManager jobCategoryManager = new JobCategoryManager(new EFJobCategoryRepository());

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var values = jobCategoryManager.GetAll();
            return View(values);
        }

        public IActionResult Contact()
        {
            return View();
        }

    }
}