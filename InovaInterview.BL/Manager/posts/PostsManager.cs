using InovaInterview.BL.Dtos.Posts;
using InovaInterview.BL.Dtos.Users;
using InovaInterview.DAL.Data.Models;
using InovaInterview.DAL.Data.Repos.Posts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InovaInterview.BL.Manager.posts
{
    public class PostsManager : IPostsManager
    {
        private readonly IPostsRepo _postrepo;

        public PostsManager(IPostsRepo postrepo)
        {
            _postrepo = postrepo;
        }

        public void Add(PostAddDto post)
        {
            Post dbPost = new Post
            {

                Title = post.Title,
                Body = post.Body,
                UserId = post.UserId

            };

           _postrepo.Add(dbPost);
            _postrepo.SaveChanges();
        }

        public List<PostTopDto> GetAllForposts()
        {
            List<Post> dbpost = _postrepo.GetAll();

            return dbpost.Select(u => new PostTopDto
            {
                Title = u.Title,
                Body = u.Body,
            }).ToList();
        }

        public List<PostTopDto> GetTopPosts(int pageNumber, int pageSize)
        {
            List<Post> topPosts = _postrepo.GetTopPosts(pageNumber, pageSize);
            if (topPosts == null || !topPosts.Any())
            {
                return new List<PostTopDto>();
            }

            return topPosts.Select(p => new PostTopDto
            {
                Title = p.Title,
                Body = p.Body,
                
            }).ToList();
        }
    }
}
