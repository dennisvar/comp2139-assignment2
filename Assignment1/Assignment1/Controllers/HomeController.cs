using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private ClassContext context { get; set; }
        public HomeController(ClassContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}