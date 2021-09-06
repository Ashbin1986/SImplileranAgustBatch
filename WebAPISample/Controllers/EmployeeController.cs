using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using WebAPISample.Models;

namespace WebAPISample.Controllers
{
    public class EmployeeController : ApiController
    {


        [System.Web.Http.HttpPost]
        public HttpResponseMessage SaveEmployee(EmployeeRequest employeeRequest)
        {
            try
            {
                if(employeeRequest == null)
                {
                    return Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, GetBadResponse("Employee Request should not be null."));
                }
                var employee = GetEmployee(employeeRequest);

                using (OrgDBEntities dbContext = new OrgDBEntities())
                {
                    dbContext.Employees.Add(employee);
                    dbContext.SaveChanges();
                }

                var response = GetResponse();

                return Request.CreateResponse(System.Net.HttpStatusCode.OK, response);

            }
            catch(Exception ex)
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [System.Web.Http.HttpGet]
        public HttpResponseMessage GetEmployees(int empId)
        {
            EmployeeResponseData employeeResponseData = new EmployeeResponseData();

            employeeResponseData.GetEmpResponse = new List<EmployeeResponse>();

            if (empId > 0)
            {
                using (OrgDBEntities dbContext = new OrgDBEntities())
                {
                    var employee = dbContext.Employees.Where(c => c.EmpId == empId).FirstOrDefault();

                    if (employee != null)
                    {
                        employeeResponseData.GetEmpResponse.Add(new EmployeeResponse
                        {
                            Email = employee.Email,
                            DateOfJoining = employee.DateOfJoining.ToString(),
                            EmployeeName = employee.EmpName
                        });
                    }
                }
            }
            else
            {
                using (OrgDBEntities dbContext = new OrgDBEntities())
                {
                    var employeeList = dbContext.Employees.ToList();

                    if (employeeList != null && employeeList.Count > 0)
                    {
                        foreach (var employee in employeeList)
                        {
                            employeeResponseData.GetEmpResponse.Add(new EmployeeResponse
                            {
                                Email = employee.Email,
                                DateOfJoining = employee.DateOfJoining.ToString(),
                                EmployeeName = employee.EmpName
                            });
                        }
                    }
                }
            }

            employeeResponseData.ResponseRecord = GetResponse();

            return Request.CreateResponse(System.Net.HttpStatusCode.OK, employeeResponseData);

        }

        private Employee GetEmployee(EmployeeRequest employeeRequest)
        {
            Employee emp = new Employee();
            emp.Email = employeeRequest.Email;
            emp.EmpName = employeeRequest.EmployeeName;
            emp.CreatedDate = DateTime.Now;
            emp.DateOfJoining = Convert.ToDateTime(employeeRequest.DateOfJoining);

            return emp;

        }

        private Response GetResponse()
        {
            return new Response()
            {
                CorrelationId = Guid.NewGuid().ToString(),
                Status = "Success"
            };
        }
        private Response GetBadResponse(string errorMsg)
        {

            var res = new Response();
            res.Errors = new List<string>();
            res.Errors.Add(errorMsg);
            res.CorrelationId = Guid.NewGuid().ToString();
            res.Status = "Failure";
            return res;
        }
    }
}