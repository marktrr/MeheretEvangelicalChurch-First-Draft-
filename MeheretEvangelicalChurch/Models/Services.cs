using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeheretEvangelicalChurch.Models
{
    public class Services
    {
        public int? ServiceId { get; set; }
        public string ServiceTitle { get; set; }
        public string ServiceDescription { get; set; }
        public DateTime? ServiceDate { get; set; }
        public string ServiceImage { get; set; }
    }
}
