using FaculOop.WebApi.Domain.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FaculOop.WebApi.Infrastructure.UserAggregate.Configurations
{
    public class UserEntityMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("usuario");
            builder.HasKey(user => user.Id);

            builder.Property(user => user.Username)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("nome_usuario");
            builder.Property(user => user.Password)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("senha_usuario");
        }
    }
}