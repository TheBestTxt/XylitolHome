using Microsoft.EntityFrameworkCore;
using XylitolHome.Domain.Entities;

namespace XylitolHome.Infrastructrue.Repository
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<UserEntity> User { get; set; }
    }
}
