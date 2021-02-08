using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace IPay88Q2_4API.Models
{
    public class Packages
    {
        public int ID { get; set; }
        [Required]
        public Student My { get; set; }
        public float Salary { get; set; }
    }
}
