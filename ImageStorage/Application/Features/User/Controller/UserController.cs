using ImageStorage.Application.Features.Image.Command;
using ImageStorage.Application.Features.User.Query;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ImageStorage.Application.Features.Image.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //post the image 
        [HttpPost("upload")]
        public async Task<IActionResult> UploadImage([FromBody] RegisterUserCommand cmd)
        {
            var result = await _mediator.Send(cmd);

            if(result == "COMPLETED")
            {
                return Ok(new { Message = "User registered successfully." });
            }
            else
            {
                return BadRequest(result);
            }
        }


        // get all users
        [HttpGet("all")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await _mediator.Send(new GetAllUsersQuery());

            if(users == null || !users.Any())
            {
                return NotFound("No users found.");
            }
            return Ok(users);
        }
    }
}
