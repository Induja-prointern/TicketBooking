using Microsoft.AspNetCore.Mvc;
using Ticket.Models.Model;
using Ticket.Services.Implementation;
using Ticket.Services.Interface;

namespace Ticket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet("getAll")]
        public async Task<IActionResult> GetAll()
        {
            List<UserModel> user = await _userService.GetAll();
            return Ok(user);
        }
        [HttpGet("getById/{{uid}}")]
        public async Task<IActionResult> GetByid(Guid uid)
        {
            UserModel user = await _userService.GetByid(uid);
            return Ok(user);
        }
        [HttpPost]

        public async Task<IActionResult> CreateUser([FromBody] UserModel userModel)
        {
            if (userModel == null)
            {
                return BadRequest("User data is null.");
            }


            UserModel createduser = await _userService.AddUser(userModel);
            return CreatedAtAction(nameof(GetByid), new { id = createduser.uid }, createduser);
        }
    }
}
