using SimpliLearnWCFSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SimpliLearnWCFSample
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public List<Employee> AddRecord(Employee employee)
        {
            throw new NotImplementedException();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            //Pull data from DB
            employees.Add(new Employee { EmpId = "101" , EmpName ="Ashbin" });
            employees.Add(new Employee { EmpId = "102", EmpName = "Zubair" });

            return employees;
        }
    }
}
