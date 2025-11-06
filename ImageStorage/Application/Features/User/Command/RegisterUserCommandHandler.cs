using ImageStorage.Application.Features.Image.Command;
using ImageStorage.Domain.Entity;
using ImageStorage.Infrastructure.Persistence;
using MediatR;
using Microsoft.EntityFrameworkCore;


namespace ImageStorage.Application.Features.User.Command
{
    public class RegisterUserCommandHandler(UserContext context) : IRequestHandler<RegisterUserCommand, string>
    {
        private readonly UserContext _context = context;

        public async Task<string> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            if(request.Dto.UserPP == null)
            {
                return "User Profile Picture is required.";
            }

            if(request.Dto.Name == null)
            {
                return "User Name is required.";
            }
            if(request.Dto.Email == null)
            {
                return "User Email is required.";
            }
            
            // Fix: DateTime is a non-nullable value type, so check for default value instead of null
            if(request.Dto.UploadTime == default)
            {
                return "Upload Time is required.";
            }

            var result = await _context.Users.SingleOrDefaultAsync(u => u.Email == request.Dto.Email);
            if (result != null)
            { return "User with this email already exists."; }
            else
            {
                result = new UserEntity
                {
                    UserPP = request.Dto.UserPP,
                    Name = request.Dto.Name,
                    Email = request.Dto.Email,
                    CreatedTime = request.Dto.UploadTime
                };
            await _context.Users.AddAsync(result);
                await _context.SaveChangesAsync();
                return "COMPLETED";

            }



        }
    }
}
