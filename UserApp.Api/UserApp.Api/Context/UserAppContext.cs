using Microsoft.EntityFrameworkCore;
using UserApp.Api.Entities;

namespace UserApp.Api.Context
{
    public class UserAppContext : DbContext
    {
        public UserAppContext(DbContextOptions<UserAppContext> options) : base(options) 
        {
            
        }

        public DbSet<User> Users { get; set; }
    }
}
