using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task1.Models
{
    public class Story
    {
        [Key]
        public int id { get; set; }
        [AllowHtml]
        [Required]
        public string name { get; set; }
        [AllowHtml]
        [Required]
        public string description { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int iteration { get; set; }
        [AllowHtml]
        public string diagram { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }
    }
}