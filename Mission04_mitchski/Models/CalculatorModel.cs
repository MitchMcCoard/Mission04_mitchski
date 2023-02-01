using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mission04_mitchski.Models
{
    public class CalculatorModel
    {
        [Required]
        [Range(0, 100)]
        public int Assignments { get; set; }
        // {get; set;} creates getters and setters for us

        [Required]
        [Range(0, 100)]
        public int Projects { get; set; }

        [Required]
        [Range(0, 100)]
        public int Quizzes { get; set; }

        [Required]
        [Range(0, 100)]
        public int Midterm { get; set; }

        [Required]
        [Range(0, 100)]
        public int Final { get; set; }

        [Required]
        [Range(0, 100)]
        public int Intex { get; set; }

            
    }
}