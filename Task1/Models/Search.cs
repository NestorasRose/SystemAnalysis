using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Task1.Models
{
    public class Search
    {
        public List<Story> stories { get; set; }
        public List<Task> tasks { get; set; }
        public List<File> files { get; set; }
    }
}