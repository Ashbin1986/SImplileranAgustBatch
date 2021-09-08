using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SimpliLearnWCFSample.Models
{
    [DataContract]
    public class Employee
    {
        [DataMember]
        public string EmpName { get; set; }
        
        [DataMember]
        public string EmpId { get; set; }
    }
}
