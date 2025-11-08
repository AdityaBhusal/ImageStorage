using MediatR;

namespace ImageStorage.Application.Features.User.Query
{
    public record GetUserImageQuery ( string Email) : IRequest<string>;
    
}
