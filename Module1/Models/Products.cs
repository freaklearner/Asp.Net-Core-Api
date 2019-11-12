using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Module1.Models
{
    public class Products
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name can not be null")]
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
