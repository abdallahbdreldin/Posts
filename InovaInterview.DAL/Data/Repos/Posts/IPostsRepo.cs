using InovaInterview.DAL.Data.Models;
using InovaInterview.DAL.Data.Repos.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaInterview.DAL.Data.Repos.Posts
{
    public interface IPostsRepo : IGenericRepo<Post>
    {
        List<Post> GetTopPosts(int pageNumber, int pageSize);
        int SaveChanges();
    }
}
