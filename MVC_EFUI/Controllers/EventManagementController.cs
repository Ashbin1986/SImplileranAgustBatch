using SimpliLearn.BusinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_EFUI.Controllers
{
    public class EventManagementController : Controller
    {
        // GET: EventManagement
        public ActionResult Index()
        {
            return View();
        }

        // GET: EventManagement/Details/5
        public ActionResult Details(int id)
        {
            IService _eventService = new Service();
            var studentLists = _eventService.GetStudentEntities();
            var student = studentLists.FirstOrDefault(c => c.StudentId == id);

            return View(student);
        }

        // GET: EventManagement/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EventManagement/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: EventManagement/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EventManagement/Edit/5
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

        // GET: EventManagement/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EventManagement/Delete/5
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
