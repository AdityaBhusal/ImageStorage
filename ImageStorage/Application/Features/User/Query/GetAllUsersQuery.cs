using MediatR;

namespace ImageStorage.Application.Features.User.Query
{
    public record GetAllUsersQuery : IRequest<List<GetUserDto>>;  
}
