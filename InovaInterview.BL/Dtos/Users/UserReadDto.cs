using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaInterview.BL.Dtos.Users
{
    public class UserReadDto
    {
        public int UserId { get; set; }

        
        public string Username { get; set; } = string.Empty;
    }
}
