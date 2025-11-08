using ImageStorage.Application.Features.Image.Model;
using MediatR;

namespace ImageStorage.Application.Features.Image.Command
{
    public class RegisterUserCommand : IRequest<string>
    {
        public Uri UserPP { get; set; }
        public string Name { get; set; }
        public string Email { get; set; } = string.Empty;
        public DateTime UploadTime { get; set; }
    }

}
