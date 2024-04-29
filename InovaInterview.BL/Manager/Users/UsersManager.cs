using InovaInterview.BL.Dtos.Posts;
using InovaInterview.BL.Dtos.Users;
using InovaInterview.DAL.Data.Models;
using InovaInterview.DAL.Data.Repos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace InovaInterview.BL.Manager.Users
{
    public  class UsersManager :IUsersManager
    {
        private readonly IuserRepo _userrepo;

        public UsersManager(IuserRepo userrepo)
        {
            
            _userrepo = userrepo;
        }

        public void Add(UserAddDto user)
        {
            User dbUser = new User
            {

                Username = user.Username

            };

            _userrepo.Add(dbUser);
            _userrepo.SaveChanges();
            
        }

        public List<UserReadDto> GetAllForUser()
        {
            List<User> dbuser = _userrepo.GetAll();

            return dbuser.Select(u => new UserReadDto
            {
                UserId = u.UserId,
                Username = u.Username,
            }).ToList();
        }

        public List<UserPostsDto> GetUsersWithPosts(int id, int pageNumber, int pageSize)
        {
            User userWithPosts = _userrepo.GetUsersWithPosts(id, pageNumber, pageSize);
            if (userWithPosts is null)
            {
                return null;
            }

            var userPostsDto = new List<UserPostsDto>
         {
                  new UserPostsDto
        {
            Username = userWithPosts.Username,
            Posts = userWithPosts.Posts
                .Select(p => new PostTopDto
                {
                    Title = p.Title,
                    Body = p.Body
                }).ToList()
        }
    };

            return userPostsDto;
        }
    }
}
