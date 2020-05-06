using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AEIS.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime UsageStart { get; set; }

        public ICollection<Point> Points { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
