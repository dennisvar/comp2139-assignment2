using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class TechnicianController : Controller
    {
        private ClassContext context { get; set; }

        public TechnicianController(ClassContext ctx)
        {
            context = ctx;
        }

        public IActionResult List()
        {
            var item = context.Technicians.ToList();
            return View(item);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Technician()); 
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            ViewBag.Action = "Edit";

            if (id == null || id == 0)
            {
                return NotFound();
            }
            
            var objFromDb = context.Technicians.Find(id);
            
            if (objFromDb == null)
            {
                return NotFound();
            }

            return View(objFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Technician technician)
        {
            if (ModelState.IsValid)
            {
                if (technician.TechnicianId == 0)
                    context.Technicians.Add(technician);
                else
                    context.Technicians.Update(technician);

                context.SaveChanges();
                TempData["success"] = "Successfully edited product";
                return RedirectToAction("List");
            }
            else
            {
                ViewBag.Action = (technician.TechnicianId == 0) ? "Add" : "Edit";
                ViewBag.Technicians = context.Technicians.ToList();
                return View(technician);
            }
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            // find an item from products by id and return it if found.
            var objFromDb = context.Technicians.Find(id);

            if (objFromDb == null)
            {
                return NotFound();
            }

            return View(objFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Technician technician)
        {
            context.Technicians.Remove(technician);
            context.SaveChanges();
            TempData["success"] = "Successfully deleted product";
            return RedirectToAction("List");
        }
    }
}
