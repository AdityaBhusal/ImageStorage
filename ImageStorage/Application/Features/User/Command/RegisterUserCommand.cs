using ImageStorage.Application.Features.Image.Model;
using MediatR;

namespace ImageStorage.Application.Features.Image.Command
{
    public record RegisterUserCommand ( RegisterUserDto Dto) : IRequest<string>;
}
