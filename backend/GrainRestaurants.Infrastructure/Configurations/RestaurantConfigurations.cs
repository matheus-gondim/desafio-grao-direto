using GrainRestaurants.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System;

namespace GrainRestaurants.Infrastructure.Configurations
{
    public class RestaurantConfigurations : IEntityTypeConfiguration<Restaurant>
    {
        public void Configure(EntityTypeBuilder<Restaurant> builder)
        {
            builder.HasIndex(r => r.Name).IsUnique();
            builder.HasIndex(r => r.FederalDocument).IsUnique();
            builder.Property(r => r.CreatedAt).HasDefaultValueSql("now()");
            builder.HasQueryFilter(r => r.DeletedAt == null);

            builder.HasMany(r => r.Menu)
                .WithOne(r => r.Restaurant)
                .HasForeignKey(r => r.RestaurantId);

            builder.HasOne(r => r.Type)
                .WithMany(r => r.Restaurant)
                .HasForeignKey(r => r.RestaurantTypeId);


            List<Restaurant> data = new()
            {
                new()
                {
                    Id = 1,
                    Name = "Mcdonald's",
                    Score = 4.7,
                    FederalDocument = "01631311000464",
                    RestaurantTypeId = 7,
                    Resume = "Líder no segmento de serviço rápido de alimentação, o McDonalds se destaca pela qualidade dos produtos e do atendimento. Sempre temos uma Mc Oferta especial (promoção) de Hamburguer, lanches, sanduíche, batata e sorvete. Aproveite!",
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_thumbnail/logosgde/201901041513_3ec68ed2-db26-4613-827f-ddcdd4777f76.jpg",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    IsOpen = true,
                    Phone = "33333333",
                    AddressId = 1,
                },
                new()
                {
                    Id = 2,
                    Name = "Habib's",
                    Score = 4.4,
                    FederalDocument = "03640022000104",
                    RestaurantTypeId = 1,
                    Resume = "O Habib’s é a maior rede de restaurantes do mundo de comida árabe. Delícias como a exclusiva esfiha, kibe, beirute, pastel, pizzas, bolinho de bacalhau e sobremesas como sorvetes, pastel de belém, pudim e refrigerantes e sucos completam seu pedido",
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_high/logosgde/b3e531ca-e1ff-4767-9868-edde3d624366/202103031204_JOYV_i.jpg",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    IsOpen = true,
                    Phone = "33333333",
                    AddressId = 2,
                },
                new()
                {
                    Id = 3,
                    Name = "Macarrão e Cia",
                    Score = 4.5,
                    FederalDocument = "10504193000171",
                    RestaurantTypeId = 4,
                    Resume = "Macarrão e CIA começa em 2005 quando o adquirimos numa oportunidade de negócio. Inicialmente havia um pequeno carro de cachorro quente e uma chapa, localizado na Praça Pôr do Sol em Uberaba.Em janeiro de 2010 seguimos a expansão e abrimos o serviço de \"delivery\".",
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_high/logosgde/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202101301033_SQbY_i.png",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    IsOpen = true,
                    Phone = "33333333",
                    AddressId = 3,
                },
                new()
                {
                    Id = 4,
                    Name = "Los Shakes",
                    Score = 4.9,
                    FederalDocument = "26187594000185",
                    RestaurantTypeId = 8,
                    Resume = "Deliciosa linha de Sorvetes , Milkshakes , Açaí e Açaí Zero Açúcar !!!!! Venha saborear o verdadeiro sabor do Açaí.",
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_high/logosgde/f9ea38f4-c7db-4525-b92d-1798e0629aa4/201909101527_hhaI_.jpeg",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    IsOpen = true,
                    Phone = "33333333",
                    AddressId = 4,
                },
            };

            builder.HasData(data);
        }
    }
}
