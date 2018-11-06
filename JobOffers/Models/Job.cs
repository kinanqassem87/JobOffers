using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobOffers.Models
{
    public class Job
    {
        public int Id { get; set; }
        [DisplayName("اسم الوظيفة")]
        public string JobTitle { get; set; }

        [DisplayName("وصف الوظيفة")]
        [AllowHtml]
        public string JobContent { get; set; }
        [DisplayName("صورة الوظيفة")]
        public string JobImage { get; set; }

        [DisplayName("نوع الوظيفة")]
        public int CategoryId { get; set; }

        public string UserId { get; set; }


        public virtual Category Category { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}