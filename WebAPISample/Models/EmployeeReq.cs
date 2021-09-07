using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebAPISample.Models
{
    public partial class EmployeeRequest
    {
       
    }

    public partial class EmployeeManagerRequest
    {
        public int EmpId { get; set; }
        public int ManagerEmpId { get; set; }

    }

}