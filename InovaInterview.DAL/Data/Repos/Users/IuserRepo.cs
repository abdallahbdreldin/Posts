using InovaInterview.DAL.Data.Models;
using InovaInterview.DAL.Data.Repos.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaInterview.DAL.Data.Repos.Users
{
    public interface IuserRepo : IGenericRepo<User>
    {
        User GetUsersWithPosts(int id, int pageNumber, int pageSize);
        int SaveChanges();
    }
}
