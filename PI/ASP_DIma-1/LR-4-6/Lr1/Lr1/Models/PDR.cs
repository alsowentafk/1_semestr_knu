using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lr1.Models
{
    public class PDR
    {

        public int Id { get; set; }
        [Required]
        [Display(Name = "Назва правила")]
        public string Name { get; set; }
        public virtual ICollection<DTP> Dtps { get; set; }

    }
}