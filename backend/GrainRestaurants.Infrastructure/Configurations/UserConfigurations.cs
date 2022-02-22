using GrainRestaurants.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GrainRestaurants.Infrastructure.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(u => u.CreatedAt)
              .HasDefaultValueSql("now()");

            builder.HasIndex(u => u.Email).IsUnique();

            builder.HasMany(u => u.Passwords)
                .WithOne(p => p.User)
                .HasForeignKey(p => p.UserId);
        }
    }
}
