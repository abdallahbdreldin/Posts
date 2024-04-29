using InovaInterview.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaInterview.BL.Dtos.Posts
{
    public class PostTopDto
    {
        public string Title { get; set; } = string.Empty;

        [Required]
        public string Body { get; set; } = string.Empty;
        //public virtual ICollection<Review>? Reviews { get; set; }
    }
}
