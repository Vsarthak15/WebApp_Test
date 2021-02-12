using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp_Test.Models
{
    public class BlogModel
    {
        [Display(Name ="Blog number")]
        [Range(1,1000, ErrorMessage="Your blog number should be between 1-1000")]
        [Required(ErrorMessage ="Blog number is mandatory!!")]
        public int ID { get; set; }


        [Display(Name ="Blog heading")]
        [Required(ErrorMessage = "Blog heading is mandatory!!")]
        public string BlogHeader { get; set; }
        
        
        [Display(Name = "Blog Body")]
        [Required(ErrorMessage = "Blog body is mandatory!!")]
        public string BlogBody { get; set; }
    }
}
