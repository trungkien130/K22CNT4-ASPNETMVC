using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ltk.Lesson4.Models;
namespace Ltk.Lesson4.Controllers
{
    public class LtkCustomerScaffdingController : Controller
    {
        private static List<LtkCustomer> listCustomer = new List<LtkCustomer>()
            {
                new LtkCustomer()
        {
            CustomerId = 1,
                FirstName = "Lê Trung",
                LastName = " Kiên",
                Address = "K22Cnt4",
                YearOfBirth = 2004
                },
                new LtkCustomer()
        {
            CustomerId = 2,
                FirstName = "Đinh Tiến",
                LastName = "Lực",
                Address = "K22CNT4",
                YearOfBirth = 2004
                },
                  new LtkCustomer()
        {
            CustomerId = 3,
                FirstName = "Đinh Tiến",
                LastName = "Lực1",
                Address = "K22CNT4",
                YearOfBirth = 2004
                },
                    new LtkCustomer()
        {
            CustomerId = 4,
                FirstName = "Đinh Tiến",
                LastName = "Lực2",
                Address = "K22CNT4",
                YearOfBirth = 2004
                }
        };
        // GET: LtkCustomerScaffding
        public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult LtkCreate()
        {
            var model = new LtkCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult LtkCreate(LtkCustomer model)
        {

            listCustomer.Add(model);
            /*            return View(model);*/
            return RedirectToAction("Index");

        }
        public ActionResult LtkEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerId==id);
            return View(customer);
        }
    }
}