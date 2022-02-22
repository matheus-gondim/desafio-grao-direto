using GrainRestaurants.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;

namespace GrainRestaurants.Infrastructure.Configurations
{
    public class DishConfigurations : IEntityTypeConfiguration<Dish>
    {
        public void Configure(EntityTypeBuilder<Dish> builder)
        {
            builder.Property(d => d.CreatedAt).HasDefaultValueSql("now()");
            builder.HasIndex(d => new { d.Name, d.RestaurantId }).IsUnique();

            List<Dish> data = new()
            {
                #region Restaurant 1
                new()
                {
                    Id = 1,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_medium/pratos/1a003463-20d8-4744-841a-6ac212a66c4b/202108101448_P6S1_f.png",
                    Price = 29.90,
                    Name = "Mc Oferta McChicken Bacon",
                    Description = "Frango empanado e dourado com molho suave e cremoso, acompanhado de alface fresquinho, fatias de bacon crocante num pão com gergelim, acompanhamento e bebida.",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 1
                },
                new()
                {
                    Id = 2,
                    Name = "McOferta McChicken Barbecue",
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/1a003463-20d8-4744-841a-6ac212a66c4b/202108101452_10TW_f.png",
                    Price = 28.90,
                    Description = "Frango empanado e dourado com o delicioso molho barbecue, cebola fresca, bacon crocante, fatia de queijo cheddar num pão com gergelim, acompanhamento e bebida. Consulte informações nutricionais do refrigerante 400ml em: mcdonalds.com.br/cardapio/bebidas. Não utilize o campo de observações, as alterações devem ser realizadas no pedido.",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 1
                },
                new()
                {
                    Id = 3,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_medium/pratos/1a003463-20d8-4744-841a-6ac212a66c4b/202108101448_P6S1_f.png",
                    Price = 23.90,
                    Name = "Mc Oferta McChicken Cheddar",
                    Description = "Frango empanado e dourado com o maravilhoso molho cheddar McMelt, cebola shoyo num pão com gergelim, acompanhamento e bebida. Consulte informações nutricionais do refrigerante 400ml em: mcdonalds.com.br/cardapio/bebidas. Não utilize o campo de observações, as alterações devem ser realizadas no pedido.",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 1
                },
                new()
                {
                    Id = 4,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/6306ea52-09eb-4439-97b4-5d353742d884/202003101215_YD7v_1.png",
                    Price = 41.90,
                    Name = "McOferta Big Tasty turbo queijo",
                    Description = "O maior sanduíche de carne 100% bovina do mcdonald’s agora também com creme de muçarela, 2 deliciosas fatias de queijo cheddar e emental, tomate, alface, cebola e o delicioso molho tasty. Mais acompanhamento e bebida em sua McOferta.",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 1
                },
                new()
                {
                    Id = 5,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/3ec68ed2-db26-4613-827f-ddcdd4777f76/202011121100_ecUL_f.png",
                    Name = "McOferta mcpicanha cheddar bacon",
                    Price = 43.90,
                    Description = "Um delicioso hambúrguer feito com picanha, 4 fatias crocantes de bacon, nosso cremoso cheddar, cebola crispy e pão com gergelim.",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 1
                },
                new()
                {
                    Id = 6,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/3ec68ed2-db26-4613-827f-ddcdd4777f76/202108101052_1OO2_i.jpg",
                    Name = "McFlurry Kit Kat Chocolate",
                    Price = 13.90,
                    Description = "A novidade com Kitkat chega para gerar momentos deliciosos... Venha dar um Break com Kitkat e Mcdonald's! Calda de Chocolate!",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 1
                },
                new()
                {
                    Id = 7,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/3ec68ed2-db26-4613-827f-ddcdd4777f76/202108101052_18NX_i.jpg",
                    Name = "McFlurry Kitkat Morango",
                    Price = 13.90,
                    Description = "A novidade com Kitkat chega para gerar momentos deliciosos... Venha dar um Break com Kitkat e Mcdonald's! Calda de Morango!",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 1
                },
                new()
                {
                    Id = 8,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/3ec68ed2-db26-4613-827f-ddcdd4777f76/202005311428_3fyS_2.jpg",
                    Name = "Top sunadae de morango",
                    Price = 13.90,
                    Description = "Uma delícia gelada sabor baunilha, uma supercamada de cobertura de chocolate, caramelo ou morango e ainda por cima com farofa de paçoca.O canudo completa a tentação.",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 1
                },
                new()
                {
                    Id = 9,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/3ec68ed2-db26-4613-827f-ddcdd4777f76/202107211616_JD81_i.jpg",
                    Name = "McShake Morango",
                    Price = 15.90,
                    Description = "O novo McShake é feito com leite e batido na hora. Você pode escolher nos sabores Ovomaltine , Chocolate Kopenhagen ou morango.",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 1
                },
                new()
                {
                    Id = 10,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/3ec68ed2-db26-4613-827f-ddcdd4777f76/202108031953_6NW0_i.jpg",
                    Name = "McShake chocolate Kopenhagen",
                    Price = 15.90,
                    Description = "O novo McShake é feito com leite e batido na hora. Você pode escolher nos sabores Ovomaltine , Chocolate Kopenhagen ou morango.",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 1
                },
                #endregion

                #region Restaurant 2
                new()
                {
                    Id = 11,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/65c38aa8-b094-413d-9a80-ddc256bfcc78/202106301908_6MWF_.jpeg",
                    Name = "4 Bib'sfihas Clássicas",
                    Price = 8.99,
                    Description = "Aproveite a promoção pra levar as bib’sfihas mais amadas do brasil: 4 Bib’sfihas Clássicas: Carne, Frango ou Calabresa.com Mussarela",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 2
                },
                new()
                {
                    Id = 12,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/65c38aa8-b094-413d-9a80-ddc256bfcc78/202106071735_75H5_.jpeg",
                    Name = "10 Bib'sfihas Clássicas + 10 Baby Churros",
                    Price = 25.9,
                    Description = "Aproveite a promoção pra levar as bib’sfihas mais amadas do brasil: 10 Bib’sfihas Clássicas: Carne, Frango ou Calabresa com Mussarela + 10 Baby Churros de Doce de Leite argentino.",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 2
                },
                new()
                {
                    Id = 13,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/65c38aa8-b094-413d-9a80-ddc256bfcc78/202106071716_6D06_.jpeg",
                    Name = "10 Bib'sfihas Clássicas",
                    Price = 19.9,
                    Description = "Aproveite a promoção pra levar as bib’sfihas mais amadas do brasil: 10 Bib’sfihas Clássicas: Carne, Frango ou Calabresa com Mussarela",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 2
                },
                new()
                {
                    Id = 14,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/65c38aa8-b094-413d-9a80-ddc256bfcc78/202106071710_P5W8_.jpeg",
                    Name = "10 Baby Churros de Doce de Leite",
                    Price = 6.9,
                    Description = "Recheado com doce de leite argentino, apaixonante. Peça já!",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 2
                },
                new()
                {
                    Id = 15,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/65c38aa8-b094-413d-9a80-ddc256bfcc78/202102181841_PWs0_.jpeg",
                    Name = "3 Esfihas folhadas de Chocolate",
                    Price = 4.99,
                    Description = "Massa folhada crocante coberta de chocolate com avelã cremoso. Aproveite",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 2
                },
                new()
                {
                    Id = 16,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/65c38aa8-b094-413d-9a80-ddc256bfcc78/202104011033_Dmia_.jpeg",
                    Name = "5 Bib’sfihas Clássicas ou Especiais",
                    Price = 4.99,
                    Description = "Aproveite a promoção para levar as bib’sfihas mais amadas do brasil: carne, calabresa com mussarela, frango, italianinha, carne com mussarela, frango com cremely e/ou queijo.",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 2
                },
                new()
                {
                    Id = 17,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/65c38aa8-b094-413d-9a80-ddc256bfcc78/202104011034_C242_.jpeg",
                    Name = "7 Bib’sfihas Clássicas",
                    Price = 4.99,
                    Description = "Aproveite a promoção para levar as bib’sfihas mais pedidas do brasil: carne, calabresa com mussarela e/ou frango.",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 2
                },
                new()
                {
                    Id = 18,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/cfa08fd6-f079-4ef5-a49f-4d2e8afe3f79/202103141901_esVr_.jpeg",
                    Name = "Bib’sfiha de calabresa com mussarela",
                    Price = 2.28,
                    Description = "A bib’sfiha mais vendida do brasil. Um verdadeiro clássico do Habib’s.",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 2
                },
                new()
                {
                    Id = 19,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/8802d01a-e149-4ec7-b746-938852a07ce7/202105201817_A3HC_.jpeg",
                    Name = "Bib'sfiha de Frango",
                    Price = 2.28,
                    Description = "Recheio de frango desfiado temperado, tomate, cebola.",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 2
                },
                new()
                {
                    Id = 20,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/cfa08fd6-f079-4ef5-a49f-4d2e8afe3f79/202103141901_k77P_.jpeg",
                    Name = "Bib’sfiha de carne com mussarela",
                    Price = 2.28,
                    Description = "Aquela clássica que vai bem em todos os momentos",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 2
                },
                #endregion

                #region Restaurant 3
                new()
                {
                    Id = 21,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202102021053_aAT3_.jpeg",
                    Name = "Alho e Óleo Simprão",
                    Price = 22.01,
                    Description = "Spaghetti, azeite de oliva extra virgem, alho.",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 3
                },
                new()
                {
                    Id = 22,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202102091147_V33s_.jpeg",
                    Name = "Alho e Óleo Veg",
                    Price = 25.51,
                    Description = "Spaghetti, azeite de oliva extra virgem, alho, brócolis e cenoura",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 3
                },
                new()
                {
                    Id = 23,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202009280838_86GA_n.jpg",
                    Name = "Alho e óleo",
                    Price = 26.01,
                    Description = "Spaghetti, azeite de oliva extra virgem, bacon e azeitona",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 3
                },
                new()
                {
                    Id = 24,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202102021048_XAkS_.jpeg",
                    Name = "Ao Molho Pesto",
                    Price = 27.51,
                    Description = "Spaghetti, azeite de oliva extra virgem, manjericão, alho queijo ralado e nozes.",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 3
                },
                new()
                {
                    Id = 25,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202010230859_ld1z_.jpeg",
                    Name = "Ao molho branco",
                    Price = 30.01,
                    Description = "Spaghetti, bacon, molho branco, frango desfiado, Catupiry, mussarela temperada e queijo ralado",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 3
                },
                new()
                {
                    Id = 26,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202010191304_An9n_.jpeg",
                    Name = "Calabresa",
                    Price = 32.01,
                    Description = "Spaghetti, bacon, calabresa, molho de tomate, molho branco, queijo ralado, mussarela temperada, Catupiry e azeitona",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 3
                },
                new()
                {
                    Id = 27,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202010230858_nQId_.jpeg",
                    Name = "Frango com Catupiry",
                    Price = 29.01,
                    Description = "Spaghetti, molho de tomate, Catupiry, bacon, frango desfiado e queijo ralado",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 3
                },
                new()
                {
                    Id = 28,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202009280836_gber_n.jpg",
                    Name = "Mutante",
                    Price = 35.01,
                    Description = "Spaghetti, bacon, molho de tomate, frango desfiado, Catupiry, champignon, tomate verde, mussarela temperada, tomate seco e queijo ralado",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 3
                },
                new()
                {
                    Id = 29,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202010191304_a3vc_.jpeg",
                    Name = "Spaguetti hot dog",
                    Price = 31.01,
                    Description = "Spaghetti, molho de tomate, Catupiry, mussarela temperada, queijo ralado, milho verde, batata palha, bacon e salsicha",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 3
                },
                new()
                {
                    Id = 30,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202010191303_DMpr_.jpeg",
                    Name = "Spaguetti pizza",
                    Price = 33.01,
                    Description = "Spaghetti, bacon, molho de tomate, molho branco, presunto, Catupiry, queijo ralado, mussarela temperada, palmito, azeitona e orégano",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 3
                },
                #endregion

                #region Restaurant 4                
                new()
                {
                    Id = 31,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/f9ea38f4-c7db-4525-b92d-1798e0629aa4/202106151232_AQHU_i.jpg",
                    Name = "1000 ml !!! Faça o melhor açai no pote !!!!",
                    Price = 41.80,
                    Description = "1000 ml faça o melhor açaí da cidade no pote ( são 500 ml + 500 ml ) com ate 9 adicionais !!!!!",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 4
                },
                new()
                {
                    Id = 32,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/f9ea38f4-c7db-4525-b92d-1798e0629aa4/202106151235_MIN2_i.jpg",
                    Name = "Açaí trifásico",
                    Price = 15.50,
                    Description = "Delicioso Açai \"Los Shakes\"",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 4
                },
                new()
                {
                    Id = 33,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/f9ea38f4-c7db-4525-b92d-1798e0629aa4/202106151237_IBB3_i.jpg",
                    Name = "Açai Gold",
                    Price = 14.00,
                    Description = "Granola, leite Ninho, Morango , banana & leite condensado",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 4
                },
                new()
                {
                    Id = 34,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/f9ea38f4-c7db-4525-b92d-1798e0629aa4/202106151228_Q5L8_i.jpg",
                    Name = "Açai Light",
                    Price = 15.00,
                    Description = "Banana & Morango",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 4
                },
                new()
                {
                    Id = 35,
                    ImageUrl = "https://static-images.ifood.com.br/image/upload/t_low/pratos/f9ea38f4-c7db-4525-b92d-1798e0629aa4/202106151229_1NUU_i.jpg",
                    Name = "Açai Sensação",
                    Price = 14,
                    Description = "Diamante negro & morango",
                    CreatedAt = DateTime.Now.ToLocalTime(),
                    RestaurantId = 4
                },
                #endregion
            };

            builder.HasData(data);
        }
    }
}