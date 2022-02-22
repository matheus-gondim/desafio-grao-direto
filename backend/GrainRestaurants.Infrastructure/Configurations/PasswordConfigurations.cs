using GrainRestaurants.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GrainRestaurants.Infrastructure.Configurations
{
    public class PasswordConfigurations : IEntityTypeConfiguration<Password>
    {
        public void Configure(EntityTypeBuilder<Password> builder)
        {
            builder.Property(p => p.CreatedAt).HasDefaultValueSql("now()");
        }
    }
}
