using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExamWebApp.Models;

namespace ExamWebApp.Controllers
{
    public class MVCController : Controller
    {
        public ViewResult Display()
        {
            var context = new MyDatabase();
            var model = context.CustTables.ToArray();
            return View(model);
        }
        public ActionResult Find(string id)
        {
            int CustId = int.Parse(id);
            var context = new MyDatabase();
            var model = context.custTables.FirstOrDefault((e) => e.CustId == CustId);
            return View(model);
        }
      
        public ActionResult Find(CustTable customer)
        {
            var context = new MyDatabase();
            var model = context.custTables.FirstOrDefault((e) => e.CustId == Customer.CustId);
            model.CustName = customer.EmpName;
            model.CustAddress = customer.EmpAddress;
            model.CustSalary = customer.EmpSalary;
            context.SaveChanges();
            return RedirectToAction("Display");
        }
        public ViewResult AddCustomer()
        {
            var model = new CustTable();
            return View(model);
        }
        public ActionResult AddCustomer(CustTable emp)
        {
            var context = new MyDatabase();
            context.CustTables.Add(Customer);
            context.SaveChanges();
            return RedirectToAction("Display");
        }
        public ActionResult DeleteCustomer(string id)
        {
            int EmpId = int.Parse(id);
            var context = new MyDatabase();
            var model = context.EmpTables.FirstOrDefault((e) => e.CustID == CustId);
            context.CustTables.Remove(model);
            context.SaveChanges();
            return RedirectToAction("Display");
        }
    }
}