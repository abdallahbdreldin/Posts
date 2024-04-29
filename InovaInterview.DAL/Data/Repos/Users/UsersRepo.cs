using InovaInterview.DAL.Data.Context;
using InovaInterview.DAL.Data.Models;
using InovaInterview.DAL.Data.Repos.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaInterview.DAL.Data.Repos.Users
{
    public class UsersRepo : GenericRepo<User> , IuserRepo
    {
        private readonly PostsContext _context;

        public UsersRepo(PostsContext context):base(context)
        {
            _context = context;
        }

       

        public User GetUsersWithPosts(int id, int pageNumber, int pageSize)
        {
            return _context.Users
        .Include(u => u.Posts)
        .Where(u => u.UserId == id)
        .Skip((pageNumber - 1) * pageSize)
        .Take(pageSize)
        .FirstOrDefault();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
