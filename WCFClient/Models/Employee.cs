using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace WCFClient.Models
{
   // [MessageContract]
    public class Employee
    {
     //   [MessageHeader]
        public string EmpName { get; set; }

       // [MessageBodyMember(Order= 2)]
        public string EmpId { get; set; }
    }
}