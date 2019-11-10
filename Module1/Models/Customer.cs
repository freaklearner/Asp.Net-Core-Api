using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Module1.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name cannot be empty"),RegularExpression("^[a-ZA-Z]+[a-zA-Z\\s]$",ErrorMessage ="Name should be alphabets only"),StringLength(100)]
        public string Name { get; set; }
        [RegularExpression("^[A-Z0-9._%+-]+@[A-Z0-9.-]+\\.[A-Z]{2,6}$",ErrorMessage ="Email is not in valid format")]
        public string Email { get; set; }
        [RegularExpression("^[0-9]{10}$",ErrorMessage ="Mobile number should be in format")]
        public string Mobile { get; set; }

    }
}
