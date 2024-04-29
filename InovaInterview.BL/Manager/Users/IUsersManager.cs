using InovaInterview.BL.Dtos.Users;
using InovaInterview.DAL.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaInterview.BL.Manager.Users
{
    public  interface IUsersManager
    {
        List<UserReadDto> GetAllForUser();
        void Add(UserAddDto user);

        List<UserPostsDto> GetUsersWithPosts(int id, int pageNumber, int pageSize);
    }
}
