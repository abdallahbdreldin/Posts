using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaInterview.DAL.Data.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public string Comment { get; set; } = string.Empty;

        public int PostId { get; set; } 

        public virtual Post? Post { get; set; } 
    }
}
