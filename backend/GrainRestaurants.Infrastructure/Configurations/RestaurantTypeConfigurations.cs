using GrainRestaurants.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace GrainRestaurants.Infrastructure.Configurations
{
    class RestaurantTypeConfigurations : IEntityTypeConfiguration<RestaurantType>
    {
        public void Configure(EntityTypeBuilder<RestaurantType> builder)
        {
            builder.HasIndex(rt => rt.Name).IsUnique();

            var data = new List<RestaurantType>
            {
                new(){ Id = 1, Name="Árabe"},
                new(){ Id = 2, Name="Oriental"},
                new(){ Id = 3, Name="Brasileira"},
                new(){ Id = 4, Name="Italiana"},
                new(){ Id = 5, Name="Lanche"},
                new(){ Id = 6, Name="Pizzaria"},
                new(){ Id = 7, Name="Fast Food"},
                new(){ Id = 8, Name="Sorveteria"},
            };

            builder.HasData(data);

        }
    }
}
