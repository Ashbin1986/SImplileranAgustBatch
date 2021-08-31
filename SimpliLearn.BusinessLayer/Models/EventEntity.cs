using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpliLearn.BusinessLayer.Models
{
   public class EventEntity
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime? EventDate { get; set; }

    }
}
