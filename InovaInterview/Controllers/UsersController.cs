using InovaInterview.BL.Dtos.Users;
using InovaInterview.BL.Manager.Users;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Headers;

namespace InovaInterview.APIs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController :ControllerBase
    {
        private readonly IUsersManager _usersmanager;

        public UsersController(IUsersManager usersmanager)
        {
            _usersmanager = usersmanager;
        }

        [HttpPost]
        public ActionResult Add(UserAddDto userAddDto)
        {
            _usersmanager.Add(userAddDto);
            return StatusCode(StatusCodes.Status201Created);
        }

        [HttpGet]
        public ActionResult<List<UserReadDto>> GetAll()
        {
            return _usersmanager.GetAllForUser();
        }

        [HttpGet("{id}/{pageNumber}/{size}")]
        public ActionResult<List<UserPostsDto>> GetAllPosts(int id, int pageNumber, int size)
        {
            List<UserPostsDto> userPosts = _usersmanager.GetUsersWithPosts(id, pageNumber, size);
            if (userPosts is null )
            {
                return NotFound();
            }
            return userPosts;
        }

    }
}
