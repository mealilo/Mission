using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Mission.Models
{
    public class Grades
    {

        [Required]
        [Range(0, 100)]
        public string assignment { get; set; }
        [Required]
        [Range(0, 100)]
        public string group { get; set; }
        [Required]
        [Range(0, 100)]
        public string quiz { get; set; }
        [Required]
        [Range(0, 100)]
        public string exam { get; set; }
        [Required]
        [Range(0, 100)]
        public string intex { get; set; }

    }
}
