using MVCApplication30Aug.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication30Aug.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public FileContentResult GetFileContent()
        {
            string path = @"C:\AugustBatch\SImplileranAgustBatch\AspNETDbApplication\MVCApplication30Aug\Downloads\NRLApplication.pdf";
            byte[] fileContent = System.IO.File.ReadAllBytes(path);

            return new FileContentResult(fileContent, "application/pdf");
        }

        //[Route(Name = "getData")]
        //[HttpGet]
        public JsonResult GetStudentJSON()
        {
            Employee emp = new Employee();
            emp.Address = "Jordon";
            emp.EmpAge = 45;
            emp.EmpName = "Mike";

            return Json(emp, JsonRequestBehavior.AllowGet);

        }

        public ContentResult GetStudentContent()
        {
            Employee emp = new Employee();
            emp.Address = "Jordon";
            emp.EmpAge = 45;
            emp.EmpName = "Mike";
            var request = JsonConvert.SerializeObject(emp);
            string myResponse = "Success";
            return Content(myResponse);

        }

    }
}