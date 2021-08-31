using MVCApplication30Aug.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication30Aug.Controllers
{
    public class HRMSController : Controller
    {
        // GET: HRMS
        public ActionResult Index()
        {
            return View();
        }

        // GET: HRMS/Details/5
        public ActionResult Details(int id)
        {
            Employee emp = new Employee();
            emp.Address = "Jordon";
            emp.EmpAge = 45;
            emp.EmpName = "Mike";
            return View(emp);
        }

        // GET: HRMS/Create
        public ActionResult Create()
        {
            
            return View(new Employee());
        }

        // POST: HRMS/Create
        [HttpPost]
        [HandleError(View = "Error")]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                int x = Convert.ToInt32(collection["EmpName"]);
                // TODO: Add insert logic here

                //return RedirectToAction("Index");
            }
            catch(Exception ex)
            {

                return View("Error");
            }

            return View();
        }

        // GET: HRMS/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HRMS/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HRMS/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HRMS/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
