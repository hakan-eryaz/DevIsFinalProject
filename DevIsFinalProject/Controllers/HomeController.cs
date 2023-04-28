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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}