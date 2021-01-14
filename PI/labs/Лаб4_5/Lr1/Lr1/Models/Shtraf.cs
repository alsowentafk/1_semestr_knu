using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lr1.Models
{
    public class Shtraf
    {
        public int ShtrafId { get; set; }
        [Required]
        public string Person { get; set; }
        [Required]
        public string Address { get; set; }
        public int dtpId { get; set; }
        public DateTime Date { get; set; }

    }
}