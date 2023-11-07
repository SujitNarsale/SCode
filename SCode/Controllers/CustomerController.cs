using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SCode.Models;
using System.Data.Entity;
using System.Threading.Tasks;

namespace SCode.Controllers
{
    public class CustomerController : Controller
    {
        AssignmentEntities db= new AssignmentEntities();
        public async Task<ActionResult> Index()
        {
            List<Customer> lst = await db.Customers.ToListAsync();
            return View(lst);
        }


        public ActionResult Create()
        {
            Customer model = new Customer();
            model.Created_On = DateTime.Now;
            return View(model);
        }


        [HttpPost]
        public ActionResult Create(Customer c)
        {
            if (ModelState.IsValid)
            {
                db.Customers.Add(c);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }



        [HttpGet]
        public ActionResult Edit(int id)
        {
            Customer cs=db.Customers.Find(id);
            return View(cs);
        }

        [HttpPost]
        public ActionResult Edit(Customer cs)
        {
            db.Entry<Customer>(cs).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            Customer cu = db.Customers.Find(id);
            db.Customers.Remove(cu);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}