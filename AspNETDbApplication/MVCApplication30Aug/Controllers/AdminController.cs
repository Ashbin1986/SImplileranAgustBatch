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
            List<Employee> lstEmployee = new List<Employee>();
            lstEmployee.Add(new Employee { EmpName = "User1" , EmpAge = 45 , Address ="USA" });
            lstEmployee.Add(new Employee { EmpName = "User2", EmpAge = 35, Address = "Singapore" });
            lstEmployee.Add(new Employee { EmpName = "User3", EmpAge = 25, Address = "Canada" });

            return View(lstEmployee);
        }

        public ActionResult AddEmployee()
        {
            // load the UI for you
            
            return View( new Employee());
        }
        public ActionResult SaveEmployee(Employee employee)
        {
            if(ModelState.IsValid)
            {
                //Save
               return RedirectToAction("ViewEmployee");
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
    }
}