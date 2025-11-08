using ImageStorage.Application.Features.User.Query;
using ImageStorage.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace ImageStorage.Application.Features.User.QueryHandler
{
    public class GetUserImageHandler : IRequestHandler<GetUserImageQuery, string>
    {
        private readonly UserContext _context;
        public GetUserImageHandler(UserContext context)
        {
            _context = context;
        }
        public async Task<string> Handle(GetUserImageQuery request, CancellationToken cancellationToken)
        {
            var result = await _context.Users.SingleOrDefaultAsync(i => i.Email == request.Email);

            if(result != null)
            {
                return result.UserPP.ToString();
            }
            else
            {
                return "User not found.";
            }
        }
    }
}
