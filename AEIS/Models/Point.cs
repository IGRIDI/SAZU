using System;
using System.ComponentModel.DataAnnotations;

namespace AEIS.Models
{
    public class Point
    {
        public int Id { get; set; }
        [Required]
        public Project Project { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
    }
}
