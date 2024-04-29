using InovaInterview.BL.Dtos.Posts;
using InovaInterview.BL.Manager.posts;
using Microsoft.AspNetCore.Mvc;

namespace InovaInterview.APIs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IPostsManager _postsManager;

        public PostsController(IPostsManager postsManager)
        {
            _postsManager = postsManager;
        } 
        [HttpPost]
        public ActionResult Add(PostAddDto postAddDto)
        {
            _postsManager.Add(postAddDto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet]
        public ActionResult<List<PostTopDto>> GetAllPost()
        {
            return _postsManager.GetAllForposts();
        }

        [HttpGet("{PageNumber}/{Size}")]
        public ActionResult<List<PostTopDto>> GetTopPosts(int PageNumber , int Size)
        {
            List<PostTopDto> posts = _postsManager.GetTopPosts(PageNumber, Size);
            if(posts is null)
            {
                return NotFound();
            }
            return posts;
        }
    }
}
