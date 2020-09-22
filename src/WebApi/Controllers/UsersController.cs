using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace FaculOop.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        static IDictionary<int, string> _users = new Dictionary<int, string>();

        [HttpGet]
        public IActionResult GetAll() {
            return Ok(_users.Values);
        }

        [HttpGet("{userId}")]
        public IActionResult GetById(int userId)
        {
            if (_users.TryGetValue(userId, out string user))
            {
                return Ok(user);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateUserDTO createUser)
        {
            if (_users.TryAdd(createUser.UserId, createUser.User))
            {
                return new ObjectResult(createUser.User)
                {
                    StatusCode = (int) HttpStatusCode.Created
                };
            }
            return BadRequest("Usuário já existe.");
        }
    }

    public class CreateUserDTO
    {
        public int UserId { get; set; }
        public string User { get; set; }
    }
}