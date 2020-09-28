using FaculOop.WebApi.Infrastructure.UserAggregate.Configurations;
using Microsoft.EntityFrameworkCore;

namespace FaculOop.WebApi.Infrastructure.Shared
{

    public class EFContext : DbContext
    {
        public EFContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserEntityMapping());
        }
    }
}