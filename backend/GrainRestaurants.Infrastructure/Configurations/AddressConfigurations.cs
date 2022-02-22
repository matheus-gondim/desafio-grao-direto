using GrainRestaurants.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace GrainRestaurants.Infrastructure.Configurations
{
    public class AddressConfigurations : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            List<Address> data = new()
            {
                new()
                {
                    Id = 1,
                    Location = "Av Pedro Salomao",
                    Number = "44",
                    AdditionalInfo = "",
                    District = "Santa Maria",
                    City = "Uberaba",
                    Uf = "MG",
                    PostalCode = "38050-490",
                },
                new()
                {
                    Id = 2,
                    Location = "Av Santos Dumont",
                    Number = "10",
                    AdditionalInfo = "",
                    District = "Centro",
                    City = "Uberaba",
                    Uf = "MG",
                    PostalCode = "38010-370",
                },
                new()
                {
                    Id = 3,
                    Location = "Rua Jonas de Carvalho",
                    Number = "55",
                    AdditionalInfo = "",
                    District = "Olinda",
                    City = "Uberaba",
                    Uf = "MG",
                    PostalCode = "38055-440",
                },
                new()
                {
                    Id = 4,
                    Location = "Avenida Quinze de Novembro",
                    Number = "515",
                    AdditionalInfo = "",
                    District = "Estados Unidos",
                    City = "Uberaba",
                    Uf = "MG",
                    PostalCode = "38015-305",
                },
            };

            builder.HasData(data);
        }
    }
}
