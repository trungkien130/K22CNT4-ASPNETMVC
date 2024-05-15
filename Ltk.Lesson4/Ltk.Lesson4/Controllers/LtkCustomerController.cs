using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ltk.Lesson4.Models;

namespace Ltk.Lesson4.Controllers
{
    public class LtkCustomerController : Controller
    {
        // GET: LtkCustomer
        public ActionResult Index()
        {
            return View();
        }
        //Action : LtkCustomerDetail
        public ActionResult LtkCustomerDetail()
        {
            var customer = new LtkCustomer()
            {
                CustomerId = 1,
                FirstName = "Lê Trung",
                LastName = " Kiên",
                Address = "K22Cnt4",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;
            return View();
        }
        //GET: LtkListCustomer
        public ActionResult LtkListCustomer()
        {
            var list = new List<LtkCustomer>()
            {
                new LtkCustomer(){
                 CustomerId = 1,
                FirstName = "Lê Trung",
                LastName = " Kiên",
                Address = "K22Cnt4",
                YearOfBirth = 2004
                },
                new LtkCustomer(){
                CustomerId=2,
                FirstName="Đinh Tiến",
                LastName="Lực",
                Address="K22CNT4",
                YearOfBirth=2004
                },
                  new LtkCustomer(){
                CustomerId=3,
                FirstName="Đinh Tiến",
                LastName="Lực1",
                Address="K22CNT4",
                YearOfBirth=2004
                },
                    new LtkCustomer(){
                CustomerId=4,
                FirstName="Đinh Tiến",
                LastName="Lực2",
                Address="K22CNT4",
                YearOfBirth=2004
                },

            };
            ViewBag.list = list;
            return View();
        }
    }
}