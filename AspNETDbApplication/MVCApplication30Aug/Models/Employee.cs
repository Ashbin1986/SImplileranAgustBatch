using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCApplication30Aug.Models
{
    public class Employee
    {
        [Required]
        public string EmpName { get; set; }

        [Required]
        [Range(18,35, ErrorMessage ="Age must be between 18 to 35")]
        public int EmpAge { get; set; }

        [Required]
        [StringLength(10,ErrorMessage ="Address should nnot be more than 10 chars.")]
        public string Address { get; set; }
    }
}