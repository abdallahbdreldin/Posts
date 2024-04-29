using InovaInterview.BL.Dtos.Posts;
using InovaInterview.BL.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaInterview.BL.Manager.posts
{
    public interface IPostsManager
    {
        List<PostTopDto> GetAllForposts();
        void Add(PostAddDto post);

        List<PostTopDto> GetTopPosts( int pageNumber, int pageSize);
    }
}
