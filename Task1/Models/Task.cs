using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Task1.Models
{
    [Table("Task")]
    public class Task
    {
        [Key]
        public int id { get; set; }
        [AllowHtml]
        [Required]
        public string name { get; set; }
        [AllowHtml]
        [Required]
        public string why { get; set; }
        [AllowHtml]
        [Required]
        public string what { get; set; }
        [AllowHtml]
        [Required]
        public string how { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int eta { get; set; }
        [AllowHtml]
        public virtual ICollection<File> Files { get; set; }
        public int? StoryId { get; set; }
        public virtual Story story { get; set; }
    }
}