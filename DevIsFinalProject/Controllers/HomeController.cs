using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevIsFinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using EntityLayer.Concrete;

namespace DevIsFinalProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        JobCategoryManager jobCategoryManager = new JobCategoryManager(new EFJobCategoryRepository());
        private ContactManager contactManager = new ContactManager(new EfContactRepository());

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var values = jobCategoryManager.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Contact(Contact contact)
        {
            contact.Email = "hakan@gmail.com";
            contactManager.TAdd(contact);
            return View();
        }

    }
}