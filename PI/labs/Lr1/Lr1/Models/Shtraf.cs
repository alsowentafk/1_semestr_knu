using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lr1.Models
{
    public class Shtraf
    {
        public int ShtrafId { get; set; } 
        public string Person { get; set; }
        public string Address { get; set; }
        public int dtpId { get; set; }
        public DateTime Date { get; set; }

    }
}