namespace ImageStorage.Application.Features.User.Query
{
    public class GetUserDto
    {
        public Uri UserPP { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
