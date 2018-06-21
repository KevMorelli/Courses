using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Entities
{
    public class Person
    {
        [Required]
        [MaxLength(50,ErrorMessage ="50 caracteres maximo.")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "50 caracteres maximo.")]
        public string Surname { get; set; }

        [Required]
        public int Age { get; set; }
    }
}