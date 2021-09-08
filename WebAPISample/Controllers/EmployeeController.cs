
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web.Http;
using WebAPISample.Models;

namespace WebAPISample.Controllers
{
    
    public class EmployeeController : ApiController
    {


        //[HttpPost]
        //public HttpResponseMessage SaveEmployee(EmployeeRequest employeeRequest)
        //{

        //    try
        //    {
        //        if(employeeRequest == null)
        //        {
        //            return Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, GetBadResponse("Employee Request should not be null."));
        //        }
        //        var employee = GetEmployee(employeeRequest);

        //        using (OrgDBEntities dbContext = new OrgDBEntities())
        //        {
        //            dbContext.Employees.Add(employee);
        //            dbContext.SaveChanges();
        //        }

        //        var response = GetResponse();

        //        return Request.CreateResponse(System.Net.HttpStatusCode.OK, response);

        //    }
        //    catch(Exception ex)
        //    {
        //        return Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, ex.Message);
        //    }
        //}


        [HttpPost]
        [Route("api/employee/register")]
        public HttpResponseMessage RegisterEmpManager(EmployeeManagerRequest employeeManagerRequest)
        {

            try
            {
                if (employeeManagerRequest == null)
                {
                    return Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, GetBadResponse("EmployeeManagerRequest Request should not be null."));
                }
              
                using (OrgDBEntities dbContext = new OrgDBEntities())
                {
                    dbContext.EmpManagerMappings.Add(new EmpManagerMapping { EmpId = employeeManagerRequest.EmpId , ManagerId = employeeManagerRequest.ManagerEmpId });
                    dbContext.SaveChanges();
                }

                var response = GetResponse();

                return Request.CreateResponse(System.Net.HttpStatusCode.OK, response);

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpGet]
        [Route("{empid:int:min(1):max(100)}")]
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
                        int? managerId = 0;
                        string managerName = string.Empty;

                        var managerMappingRecord = dbContext.EmpManagerMappings.Where(c => c.EmpId == employee.EmpId);

                        if (managerMappingRecord != null && managerMappingRecord.Count() > 0)
                        {
                            managerId = managerMappingRecord.FirstOrDefault().ManagerId;
                        }

                        if (dbContext.Employees.Where(c => c.EmpId == managerId).Count() > 0)
                        {
                            managerName = dbContext.Employees.Where(c => c.EmpId == managerId).FirstOrDefault().EmpName;
                        }
                        employeeResponseData.GetEmpResponse.Add(new EmployeeResponse
                        {
                            Email = employee.Email,
                            DateOfJoining = employee.DateOfJoining.ToString(),
                            EmployeeName = employee.EmpName,
                            EmpId = employee.EmpId,
                            ManagerName = managerName
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
                            int? managerId = 0;

                            string managerName = string.Empty;

                            var managerMappingRecord = dbContext.EmpManagerMappings.Where(c => c.EmpId == employee.EmpId);

                            if(managerMappingRecord != null && managerMappingRecord.Count() > 0)
                            {
                                managerId = managerMappingRecord.FirstOrDefault().ManagerId;
                            }

                            if(dbContext.Employees.Where(c => c.EmpId == managerId).Count() > 0)
                            {
                                managerName = dbContext.Employees.Where(c => c.EmpId == managerId).FirstOrDefault().EmpName;
                            }
                            employeeResponseData.GetEmpResponse.Add(new EmployeeResponse
                            {
                                Email = employee.Email,
                                DateOfJoining = employee.DateOfJoining.ToString(),
                                EmployeeName = employee.EmpName,
                                EmpId = employee.EmpId,
                                ManagerName = managerName
                            });
                        }
                    }
                }
            }

            employeeResponseData.ResponseRecord = GetResponse();


            return Request.CreateResponse(System.Net.HttpStatusCode.OK, employeeResponseData);

        }

        // DELETE api/employee/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                if(id <= 0)
                {
                    throw new ArgumentNullException("Id should not be null");
                    //return Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, "Id should not be null");
                }

                using(OrgDBEntities dbContext = new OrgDBEntities())
                {
                    var employeeRecord = dbContext.Employees.Where(c => c.EmpId == id).FirstOrDefault();
                    
                    if(employeeRecord == null)
                    {
                        return Request.CreateResponse(System.Net.HttpStatusCode.NotFound, "Record not found for requested id : "+ id);
                    }

                    if (dbContext.EmpManagerMappings.Where(c => c.EmpId == id).Count() > 0)
                    {
                        var record = dbContext.EmpManagerMappings.Where(c => c.EmpId == id).FirstOrDefault();

                        dbContext.EmpManagerMappings.Remove(record);

                        dbContext.SaveChanges();
                      
                    }

                    dbContext.Employees.Remove(employeeRecord);

                    dbContext.SaveChanges();

                }

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, ex.Message);
            }

            return Request.CreateResponse(System.Net.HttpStatusCode.OK, "Record deleted successfully!."); ;
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