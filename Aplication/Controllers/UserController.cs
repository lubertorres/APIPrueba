using apiPrueba.Domain.Interface;
using apiPrueba.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace apiPrueba.Aplication.Controllers
{

    [Route("/api/v1/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public CreatedResult SaveUser([FromBody] UserCreate user)
        {
            return Created("", _userService.Save(user));
        }

        [HttpGet("all")]
        public OkObjectResult GetAllUsers()
        {
            return Ok(_userService.GetAll());
        }

    }


}
