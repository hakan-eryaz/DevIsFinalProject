using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DevIsFinalProject.Controllers
{
    public class RegisterController : Controller
    {
        private readonly Context _context;

        public RegisterController(Context context)
        {
            _context = context;
        }

        // GET: /Register
        public IActionResult Index()
            {
                return View();
            }

            // POST: /Register
            [HttpPost]
            public IActionResult Index(string firstName,string lastName,string country, string email, string phone, string password)
            {
                
                var newUser = new User
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Country = country,
                    Email = email,
                    Phone = phone,
                    // Store the hashed password in a secure manner
                    Password = HashPassword(password)
                };

                    _context.Users.Add(newUser);
                    _context.SaveChanges();
            // Redirect to a success page or perform any other desired actions
            return RedirectToAction("RegistrationSuccess");
            }

            // GET: /Register/RegistrationSuccess
            public IActionResult RegistrationSuccess()
            {
                return View();
            }

            // Helper method to hash the password (you can use a more secure hashing mechanism)
            private string HashPassword(string password)
            {
                // Implement your password hashing logic here
                // Example: return password;

                return password;
            }
        }
    


}
