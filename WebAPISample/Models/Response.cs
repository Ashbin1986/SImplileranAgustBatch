using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPISample.Models
{
    public class Response
    {
        public string CorrelationId { get; set; }

        public List<string> Errors { get; set; }

        public string Status { get; set; }
    }


}