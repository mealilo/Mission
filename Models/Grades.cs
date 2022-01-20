using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Mission.Models
{
    public class Grades
    {
        [Required] public double assignment { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal project { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal quiz { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal exam { get; set; }
        [Required]
        [Range(0, 100)]
        public decimal intex { get; set; }

    }
}
