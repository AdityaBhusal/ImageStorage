using ImageStorage.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace ImageStorage.Infrastructure.Persistence
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions<UserContext> options) : base (options)
        {
        }
        public DbSet<User> Users => Set<User>();
    }
}
