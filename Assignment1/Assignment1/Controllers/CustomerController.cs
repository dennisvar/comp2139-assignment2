using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers
{
    public class CustomerController : Controller
    {
        private ClassContext context { get; set; }

        public CustomerController(ClassContext ctx)
        {
            context = ctx;
        }

        public IActionResult List()
        {
            var item = context.Customers.ToList();
            return View(item);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("Edit", new Customer()); 
        }


        [HttpGet]
        public IActionResult Edit(int? id)
        {
            ViewBag.Action = "Edit";

            if (id == null || id == 0)
            {
                return NotFound();
            }
            
            var objFromDb = context.Customers.Find(id);
            
            if (objFromDb == null)
            {
                return NotFound();
            }

            return View(objFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Customer customer)
        {
            if (ModelState.IsValid)
            {
                if (ModelState.IsValid)
                {
                    if (customer.CustomerId == 0)
                        context.Customers.Add(customer);
                    else
                        context.Customers.Update(customer);

                    context.SaveChanges();
                    TempData["success"] = "Successfully edited product";
                    return RedirectToAction("List");
                }
                else
                {
                    ViewBag.Action = (customer.CustomerId == 0) ? "Add" : "Edit";
                    ViewBag.Customers = context.Customers.ToList();
                    return View(customer);
                }
            }
            return View(customer);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var objFromDb = context.Customers.Find(id);

            if (objFromDb == null)
            {
                return NotFound();
            }

            return View(objFromDb);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Customer customer)
        {           
            context.Customers.Remove(customer);
            context.SaveChanges();
            TempData["success"] = "Successfully deleted product";
            return RedirectToAction("List");
        }
    }
}
