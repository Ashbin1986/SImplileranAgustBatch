using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPISample.Models
{
    public partial class EmployeeRequest
    {
        [Required]
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string DateOfJoining { get; set; }
    }

    public class EmployeeResponse
    {
        public string EmployeeName { get; set; }
        public string Email { get; set; }
        public string DateOfJoining { get; set; }

        public string ManagerName { get; set; }

        public int EmpId{ get; set; }


    }
    public class EmployeeResponseData
    {
        public List<EmployeeResponse> GetEmpResponse { get; set; }
        public Response ResponseRecord { get; set; }
    }
}