using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SC601_MVC.Models
{
    public class Brand
    {
        [Display(Name ="Brand ID")]
        public int brand_id { get; set; }
        [Display(Name = "Brand Name")]
        public string brand_Name { get; set; }
    }
}