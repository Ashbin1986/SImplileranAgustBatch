using MVCApplication30Aug.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCApplication30Aug.Controllers
{
    public class AdminController : Controller
    {
        
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewEmployee()
        {
            List<Student> studentRecord = new List<Student>();

            using (SchoolManagementEntities dbContext = new SchoolManagementEntities())
            {
                studentRecord = dbContext.Students.ToList();
            }



            List<Employee> lstEmployee = new List<Employee>();
            lstEmployee.Add(new Employee { EmpName = "User1" , EmpAge = 45 , Address ="USA" });
            lstEmployee.Add(new Employee { EmpName = "User2", EmpAge = 35, Address = "Singapore" });
            lstEmployee.Add(new Employee { EmpName = "User3", EmpAge = 25, Address = "Canada" });

            var count = TempData["NoofRecords"];

            ViewData["EmployeeList"] = lstEmployee;
            ViewBag.EmployeeRecords = lstEmployee;
            TempData["Employee"] = lstEmployee;
            ViewBag.PageTitle = "Employee Records";
            ViewBag.Count = count;
            return View();
        }

        
        public ActionResult AddEmployee()
        {
            // load the UI for you
            Employee emp = new Employee();
            emp.Address = "Canada";
            emp.EmpAge = 100;
            emp.EmpName = "Test User";
            
            return View( emp);
        }
        

        public ActionResult SaveEmployee(Employee employee)
        {
            if(ModelState.IsValid)
            {
                TempData["NoofRecords"] = 100;
                //Save
                //return RedirectToAction("ViewEmployee");

                return RedirectToRoute("testView");

            }
            else
            {
                return View("AddEmployee", new Employee());
            }
            //Save employee record
            return View("AddEmployee", new Employee());
        }

        public ActionResult EditViewEmployee()
        {
            // load the UI for you
            Employee employee = new Employee();
            employee.EmpName = "John";
            employee.Address = "London";
            employee.EmpAge = 55;

            return View(employee);
        }

        public ActionResult UpdateEmployee(Employee employee)
        {
            if (ModelState.IsValid)
            {
                //Save
            }
            else
            {
                return View("AddEmployee", new Employee());
            }
            //Save employee record
            return View("AddEmployee", new Employee());
        }
        //public ActionResult LoginView()
        //{
        //    return 
        //}
    }
}