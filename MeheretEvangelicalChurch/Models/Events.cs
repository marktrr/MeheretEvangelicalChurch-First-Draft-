using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeheretEvangelicalChurch.Models
{
    public class Events
    {
        public int EventId { get; set; }
        public string EventTitle { get; set; }
        public string EventDescription { get; set; }
        public DateTime? EventDate { get; set; }
        public string EventImage { get; set; }
    }
}
