using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace webAPI.Models
{
    public class book
    {
        [Required]
        [MaxLength(20,ErrorMessage ="Long name")]
        [MinLength(5, ErrorMessage = "short name")]
        public string Title { get; set; }
        [Required]
        public int Pages { get; set; }
        
    }
}