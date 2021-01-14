using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lr1.Models
{
    public class DTP
    {
        public int Id { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.Resource),
          ErrorMessageResourceName = "NameRequired")]
        [Display(Name = "Name", ResourceType = typeof(Resources.Resource))]
        public string Name { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.Resource),
  ErrorMessageResourceName = "TypeRequired")]
        [Display(Name = "Type", ResourceType = typeof(Resources.Resource))]
        public string Type { get; set; }
        [Required(ErrorMessageResourceType = typeof(Resources.Resource),
  ErrorMessageResourceName = "PriceRequired")]
        [Display(Name = "Price", ResourceType = typeof(Resources.Resource))]
        public int Price { get; set; }

    }
}