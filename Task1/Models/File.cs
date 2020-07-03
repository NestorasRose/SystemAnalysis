using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1.Enums;

namespace Task1.Models
{
    [Table("File")]
    public class File
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public FileTypeEnum FileType { get; set; }
        [AllowHtml]
        [Required]
        public string Name { get; set; }
        [AllowHtml]
        [Required]
        public string Description { get; set; }

        public int? TaskId { get; set; }
        public Task Task { get; set; }

    }
}