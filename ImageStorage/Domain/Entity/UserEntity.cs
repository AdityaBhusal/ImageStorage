namespace ImageStorage.Domain.Entity
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public Uri UserPP { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
