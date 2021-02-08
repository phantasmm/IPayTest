using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace IPay88Q2_4API.Models
{
    public class Bank
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        public bool IsVISA { get; set; }
        [Required]
        public int typeNumber { get; set; }
    }
}
