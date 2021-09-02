using SimpliLearn.BusinessLayer;
using SimpliLearn.BusinessLayer.Models;
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
            IService _eventService = new Service();
            var studentLists = _eventService.GetStudentEntities();
            studentLists.Take(2);
            studentLists.Skip(2);

            ViewData["TotalRecords"] = studentLists.Count();
            return View(studentLists);
        }

        // GET: EventManagement/Details/5
        public ActionResult Details(int id)
        {
            IService _eventService = new Service();
            var studentLists = _eventService.GetStudentEntities();
            //var student = studentLists.FirstOrDefault(c => c.StudentId == id);
            var itesm = studentLists.ElementAt(2);
            var response = _eventService.GetStudentById(id);

            return View(response);
        }

        // GET: EventManagement/Create
        public ActionResult Create()
        {
            StudentEntity student = new StudentEntity();

            return View(student);
        }

        // POST: EventManagement/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                IService service = new Service();

                service.AddStudent(new StudentEntity()
                {
                    StudentName = collection["StudentName"],
                    Gender = collection["Gender"],
                    Email = collection["Email"],
                    IsActive = true,
                });

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
