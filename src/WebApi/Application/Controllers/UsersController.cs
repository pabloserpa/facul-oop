using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using FaculOop.WebApi.Application.Contracts;
using FaculOop.WebApi.Domain.UserAggregate;
using FaculOop.WebApi.Infrastructure.Shared;
using Microsoft.AspNetCore.Mvc;

namespace FaculOop.WebApi.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        static IDictionary<int, string> _users = new Dictionary<int, string>();
        private readonly EFContext _context;

        public UsersController(EFContext context)
        {
            _context = context ?? throw new System.ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Cria um usuário.
        /// </summary>
        /// <param name="createUser">Contrato de criação.</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create([FromBody] CreateUserDTO createUser)
        {
            var user = new User();
            user.Id = createUser.UserId;
            user.Username = createUser.User;
            user.Password = Guid.NewGuid().ToString();
            _context.Add(user);
            _context.SaveChanges();
            return new ObjectResult(createUser.User)
            {
                StatusCode = (int) HttpStatusCode.Created
            };
            /*
            if (_users.TryAdd(createUser.UserId, createUser.User))
            {
                return new ObjectResult(createUser.User)
                {
                    StatusCode = (int) HttpStatusCode.Created
                };
            }
            return BadRequest("Usuário já existe.");
            */
        }

        /// <summary>
        /// Obtém todos os usuários.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetAll() {
            return Ok(_context.Set<User>().ToList());
        }

        /// <summary>
        /// Obtém um usuário pelo identificador.
        /// </summary>
        /// <param name="userId">Identificador do usuário.</param>
        /// <returns></returns>
        // [HttpGet("{userId}")]
        public IActionResult GetById(int userId)
        {
            if (_users.TryGetValue(userId, out string user))
            {
                return Ok(user);
            }
            return NotFound();
        }

        /// <summary>
        /// Atualiza um usuário pelo identificador.
        /// </summary>
        /// <param name="userId">Identificador do usuário.</param>
        /// <param name="updateUser">Contrato de atualização.</param>
        /// <returns></returns>
        [HttpPut("{userId}")]
        public IActionResult UpdateById(int userId, [FromBody] UpdateUserDTO updateUser)
        {
            if (_users.ContainsKey(userId))
            {
                _users[userId] = updateUser.User;
                return Ok();
            }
            return NotFound();
        }

        /// <summary>
        /// Remove um usuário através do identificador.
        /// </summary>
        /// <param name="userId">Identificador do usuário</param>
        /// <returns></returns>
        [HttpDelete("{userId}")]
        public IActionResult DeleteById(int userId)
        {
            if (_users.Remove(userId))
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}