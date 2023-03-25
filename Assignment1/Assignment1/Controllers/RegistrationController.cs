using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class RegistrationController : Controller
    {
        private ClassContext context { get; set; }

        public RegistrationController(ClassContext ctx)
        {
            context = ctx;
        }
        public IActionResult GetCustomer()
        {

            return View();
        }
    }
}
