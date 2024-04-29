using InovaInterview.BL.Dtos.Posts;
using InovaInterview.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaInterview.BL.Dtos.Users
{
    public class UserPostsDto
    {
        public string Username { get; set; } = string.Empty;

        public List<PostTopDto> Posts { get; set; } = new List<PostTopDto>();
    }
}
