using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class IncidentController : Controller
    {
        //private readonly bool IncidentModel;

        private ClassContext context { get; set; }

        public IncidentController(ClassContext ctx)
        {
            context = ctx;
        }

        public ViewResult List()
        {
            var ivm = new IncidentViewModel
            {
                IncidentModel = context.Incidents.ToList(),
                CustomerModel = context.Customers.ToList(),
                ProductModel = context.Products.ToList(),
                TechnicianModel = context.Technicians.ToList(),
            };
            return View(ivm);
        }

        [HttpPost]
        public RedirectToActionResult List(Incident incident)
        {
            if (incident.IncidentId > 0)
                return RedirectToAction("List", new { id = incident.IncidentId });
            else
                return RedirectToAction("List", new { id = "" });
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Incident()); 
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            ViewBag.Action = "Edit";

            if (id == null || id == 0)
            {
                return NotFound();
            }
            
            var objFromDb = context.Incidents.Find(id);
            
            if (objFromDb == null)
            {
                return NotFound();
            }

            return View(objFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Incident incident)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    if (incident.IncidentId == 0)
                        context.Incidents.Add(incident);
                    else
                        context.Incidents.Update(incident);

                    context.SaveChanges();
                    TempData["success"] = "Successfully edited product";
                    return RedirectToAction("List");
                }
                else
                {
                    ViewBag.Action = (incident.IncidentId == 0) ? "Add" : "Edit";
                    ViewBag.Incidents = context.Incidents.ToList();
                    return View(incident);
                }
            }
            return View(incident);
        }

        [HttpGet]
        public IActionResult DeletePost(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var objFromDb = context.Incidents.Find(id);

            if (objFromDb == null)
            {
                return NotFound();
            }

            return View(objFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Incident incident)
        {           
            context.Incidents.Remove(incident);
            context.SaveChanges();
            TempData["success"] = "Successfully deleted product";
            return RedirectToAction("List");
        }
    }
}
