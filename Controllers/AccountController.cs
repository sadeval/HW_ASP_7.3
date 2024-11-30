using Microsoft.AspNetCore.Mvc;
using Registration.Models;

namespace Registration.Controllers
{
    public class AccountController : Controller
    {
        [HttpPost]
        public IActionResult Register([FromBody] UserRegistration model)
        {
            Console.WriteLine($"Username: {model.Username}, Email: {model.Email}, Password: {model.Password}");

            if (string.IsNullOrEmpty(model.Username) || string.IsNullOrEmpty(model.Email) || string.IsNullOrEmpty(model.Password))
            {
                return Json(new { success = false, message = "All fields are required." });
            }

            return Json(new { success = true, message = "Registration successful!" });
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}
