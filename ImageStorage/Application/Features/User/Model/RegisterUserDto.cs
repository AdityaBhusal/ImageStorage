namespace ImageStorage.Application.Features.Image.Model
{
    public class RegisterUserDto
    {
        public Uri UserPP { get; set; }
        public string Name { get; set; }
        public string Email { get; set; } = string.Empty;
        public DateTime UploadTime { get; set; }

    }
}
