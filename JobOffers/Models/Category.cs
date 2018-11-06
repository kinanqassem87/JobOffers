using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JobOffers.Models
{
    public class Category
    {
        public int id { get; set; }
        [Required]
        [Display(Name ="نوع الوظيفة")]
        public string CategoryName { get; set; }
        [Required]
        [Display(Name ="وصف الوظيفة")]
        public string CategoryDescription { get; set; }

        
        public virtual ICollection<Job> Jobs { get; set; }
    }
}