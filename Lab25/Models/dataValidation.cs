using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Lab25.Models
{
    public class dataValidation
    {   [Required]     
        public string Name { get; set; }
       [Required]
        public int age{ get; set; }
    }
}