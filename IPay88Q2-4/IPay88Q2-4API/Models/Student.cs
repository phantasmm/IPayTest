using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace IPay88Q2_4API.Models
{
    public class Student
    {
        public int ID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
    }
}
