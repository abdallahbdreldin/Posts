using InovaInterview.DAL.Data.Context;
using InovaInterview.DAL.Data.Models;
using InovaInterview.DAL.Data.Repos.Generic;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaInterview.DAL.Data.Repos.Posts
{
    public class PostRepo : GenericRepo<Post> , IPostsRepo
    {
        private readonly PostsContext _context;

        public PostRepo(PostsContext context) : base(context)
        {
            _context = context;
        }

        public List<Post> GetTopPosts(int pageNumber, int pageSize)
        {
            return _context.Posts
            .OrderByDescending(p => p.Reviews.Average(r => r.Rating)) 
            .Include(p => p.User) 
            .ToList();
        }
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
