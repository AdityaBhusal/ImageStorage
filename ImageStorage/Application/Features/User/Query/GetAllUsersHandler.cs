using MediatR;
using ImageStorage.Domain.Entity;
using ImageStorage.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace ImageStorage.Application.Features.User.Query
{
    public class GetAllUsersHandler : IRequestHandler<GetAllUsersQuery, List<GetUserDto>>
    {
        private readonly UserContext _context;
        public GetAllUsersHandler(UserContext context)
        {
            _context = context;
        }
        public async Task<List<GetUserDto>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {

            var users = await _context.Users
                .AsNoTracking()
                .Select(u => new GetUserDto
                {
                    UserPP = u.UserPP,
                    Name = u.Name,
                    Email = u.Email,
                    CreatedTime = u.CreatedTime
                }).ToListAsync();

            return users;
        }
    }
}
