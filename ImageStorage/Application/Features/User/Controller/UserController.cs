using ImageStorage.Application.Features.Image.Command;
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

        [HttpPost("upload")]
        public async Task<IActionResult> UploadImage([FromBody] RegisterUserCommand cmd)
        {
            var result = await _mediator.Send(cmd);

            
        }
    }
}
