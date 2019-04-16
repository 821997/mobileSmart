using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MobileProject.Models
{
    public class SmartWatch
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string color { get; set; }
        [Required]
        public int price { get; set; }
        [Required]
        public int model { get; set; }
    }
}