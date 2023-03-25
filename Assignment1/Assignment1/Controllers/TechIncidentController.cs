using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class TechIncidentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
