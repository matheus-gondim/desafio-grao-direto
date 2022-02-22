using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GrainRestaurants.Infrastructure.Migrations
{
    public partial class SeedsDish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Itens",
                table: "Dish",
                newName: "Description");

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(643));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9892));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9894));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9900));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9906));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9909));

            migrationBuilder.InsertData(
                table: "Dish",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageUrl", "Name", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 32L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9997), "Delicioso Açai \"Los Shakes\"", "https://static-images.ifood.com.br/image/upload/t_low/pratos/f9ea38f4-c7db-4525-b92d-1798e0629aa4/202106151235_MIN2_i.jpg", "Açaí trifásico", 15.5, 4L },
                    { 33L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9998), "Granola, leite Ninho, Morango , banana & leite condensado", "https://static-images.ifood.com.br/image/upload/t_low/pratos/f9ea38f4-c7db-4525-b92d-1798e0629aa4/202106151237_IBB3_i.jpg", "Açai Gold", 14.0, 4L },
                    { 11L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9955), "Aproveite a promoção pra levar as bib’sfihas mais amadas do brasil: 4 Bib’sfihas Clássicas: Carne, Frango ou Calabresa.com Mussarela", "https://static-images.ifood.com.br/image/upload/t_low/pratos/65c38aa8-b094-413d-9a80-ddc256bfcc78/202106301908_6MWF_.jpeg", "4 Bib'sfihas Clássicas", 8.9900000000000002, 2L },
                    { 35L, new DateTime(2021, 8, 26, 10, 39, 48, 770, DateTimeKind.Local).AddTicks(2), "Diamante negro & morango", "https://static-images.ifood.com.br/image/upload/t_low/pratos/f9ea38f4-c7db-4525-b92d-1798e0629aa4/202106151229_1NUU_i.jpg", "Açai Sensação", 14.0, 4L },
                    { 31L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9995), "1000 ml faça o melhor açaí da cidade no pote ( são 500 ml + 500 ml ) com ate 9 adicionais !!!!!", "https://static-images.ifood.com.br/image/upload/t_low/pratos/f9ea38f4-c7db-4525-b92d-1798e0629aa4/202106151232_AQHU_i.jpg", "1000 ml !!! Faça o melhor açai no pote !!!!", 41.799999999999997, 4L },
                    { 34L, new DateTime(2021, 8, 26, 10, 39, 48, 770, DateTimeKind.Local).AddTicks(1), "Banana & Morango", "https://static-images.ifood.com.br/image/upload/t_low/pratos/f9ea38f4-c7db-4525-b92d-1798e0629aa4/202106151228_Q5L8_i.jpg", "Açai Light", 15.0, 4L },
                    { 29L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9992), "Spaghetti, molho de tomate, Catupiry, mussarela temperada, queijo ralado, milho verde, batata palha, bacon e salsicha", "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202010191304_a3vc_.jpeg", "Spaguetti hot dog", 31.010000000000002, 3L },
                    { 30L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9993), "Spaghetti, bacon, molho de tomate, molho branco, presunto, Catupiry, queijo ralado, mussarela temperada, palmito, azeitona e orégano", "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202010191303_DMpr_.jpeg", "Spaguetti pizza", 33.009999999999998, 3L },
                    { 27L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9988), "Spaghetti, molho de tomate, Catupiry, bacon, frango desfiado e queijo ralado", "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202010230858_nQId_.jpeg", "Frango com Catupiry", 29.010000000000002, 3L },
                    { 12L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9958), "Aproveite a promoção pra levar as bib’sfihas mais amadas do brasil: 10 Bib’sfihas Clássicas: Carne, Frango ou Calabresa com Mussarela + 10 Baby Churros de Doce de Leite argentino.", "https://static-images.ifood.com.br/image/upload/t_low/pratos/65c38aa8-b094-413d-9a80-ddc256bfcc78/202106071735_75H5_.jpeg", "10 Bib'sfihas Clássicas + 10 Baby Churros", 25.899999999999999, 2L },
                    { 13L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9961), "Aproveite a promoção pra levar as bib’sfihas mais amadas do brasil: 10 Bib’sfihas Clássicas: Carne, Frango ou Calabresa com Mussarela", "https://static-images.ifood.com.br/image/upload/t_low/pratos/65c38aa8-b094-413d-9a80-ddc256bfcc78/202106071716_6D06_.jpeg", "10 Bib'sfihas Clássicas", 19.899999999999999, 2L },
                    { 14L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9962), "Recheado com doce de leite argentino, apaixonante. Peça já!", "https://static-images.ifood.com.br/image/upload/t_low/pratos/65c38aa8-b094-413d-9a80-ddc256bfcc78/202106071710_P5W8_.jpeg", "10 Baby Churros de Doce de Leite", 6.9000000000000004, 2L },
                    { 15L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9965), "Massa folhada crocante coberta de chocolate com avelã cremoso. Aproveite", "https://static-images.ifood.com.br/image/upload/t_low/pratos/65c38aa8-b094-413d-9a80-ddc256bfcc78/202102181841_PWs0_.jpeg", "3 Esfihas folhadas de Chocolate", 4.9900000000000002, 2L },
                    { 16L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9967), "Aproveite a promoção para levar as bib’sfihas mais amadas do brasil: carne, calabresa com mussarela, frango, italianinha, carne com mussarela, frango com cremely e/ou queijo.", "https://static-images.ifood.com.br/image/upload/t_low/pratos/65c38aa8-b094-413d-9a80-ddc256bfcc78/202104011033_Dmia_.jpeg", "5 Bib’sfihas Clássicas ou Especiais", 4.9900000000000002, 2L },
                    { 17L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9969), "Aproveite a promoção para levar as bib’sfihas mais pedidas do brasil: carne, calabresa com mussarela e/ou frango.", "https://static-images.ifood.com.br/image/upload/t_low/pratos/65c38aa8-b094-413d-9a80-ddc256bfcc78/202104011034_C242_.jpeg", "7 Bib’sfihas Clássicas", 4.9900000000000002, 2L },
                    { 28L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9990), "Spaghetti, bacon, molho de tomate, frango desfiado, Catupiry, champignon, tomate verde, mussarela temperada, tomate seco e queijo ralado", "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202009280836_gber_n.jpg", "Mutante", 35.009999999999998, 3L },
                    { 19L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9973), "Recheio de frango desfiado temperado, tomate, cebola.", "https://static-images.ifood.com.br/image/upload/t_low/pratos/8802d01a-e149-4ec7-b746-938852a07ce7/202105201817_A3HC_.jpeg", "Bib'sfiha de Frango", 2.2799999999999998, 2L },
                    { 18L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9972), "A bib’sfiha mais vendida do brasil. Um verdadeiro clássico do Habib’s.", "https://static-images.ifood.com.br/image/upload/t_low/pratos/cfa08fd6-f079-4ef5-a49f-4d2e8afe3f79/202103141901_esVr_.jpeg", "Bib’sfiha de calabresa com mussarela", 2.2799999999999998, 2L },
                    { 21L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9976), "Spaghetti, azeite de oliva extra virgem, alho.", "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202102021053_aAT3_.jpeg", "Alho e Óleo Simprão", 22.010000000000002, 3L },
                    { 22L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9979), "Spaghetti, azeite de oliva extra virgem, alho, brócolis e cenoura", "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202102091147_V33s_.jpeg", "Alho e Óleo Veg", 25.510000000000002, 3L },
                    { 23L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9981), "Spaghetti, azeite de oliva extra virgem, bacon e azeitona", "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202009280838_86GA_n.jpg", "Alho e óleo", 26.010000000000002, 3L },
                    { 24L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9984), "Spaghetti, azeite de oliva extra virgem, manjericão, alho queijo ralado e nozes.", "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202102021048_XAkS_.jpeg", "Ao Molho Pesto", 27.510000000000002, 3L },
                    { 25L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9985), "Spaghetti, bacon, molho branco, frango desfiado, Catupiry, mussarela temperada e queijo ralado", "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202010230859_ld1z_.jpeg", "Ao molho branco", 30.010000000000002, 3L },
                    { 26L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9987), "Spaghetti, bacon, calabresa, molho de tomate, molho branco, queijo ralado, mussarela temperada, Catupiry e azeitona", "https://static-images.ifood.com.br/image/upload/t_low/pratos/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202010191304_An9n_.jpeg", "Calabresa", 32.009999999999998, 3L },
                    { 20L, new DateTime(2021, 8, 26, 10, 39, 48, 769, DateTimeKind.Local).AddTicks(9975), "Aquela clássica que vai bem em todos os momentos", "https://static-images.ifood.com.br/image/upload/t_low/pratos/cfa08fd6-f079-4ef5-a49f-4d2e8afe3f79/202103141901_k77P_.jpeg", "Bib’sfiha de carne com mussarela", 2.2799999999999998, 2L }
                });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 26, 10, 39, 48, 777, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 26, 10, 39, 48, 777, DateTimeKind.Local).AddTicks(4883));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 26, 10, 39, 48, 777, DateTimeKind.Local).AddTicks(4889));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2021, 8, 26, 10, 39, 48, 777, DateTimeKind.Local).AddTicks(4891), "Los Shakes" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 12L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 13L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 14L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 15L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 16L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 17L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 18L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 19L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 20L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 21L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 22L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 23L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 24L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 25L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 26L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 27L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 28L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 29L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 30L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 31L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 32L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 33L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 34L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 35L);

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Dish",
                newName: "Itens");

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 22, 13, 35, 891, DateTimeKind.Local).AddTicks(6421));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 22, 13, 35, 892, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 22, 13, 35, 892, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 22, 13, 35, 892, DateTimeKind.Local).AddTicks(4307));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 22, 13, 35, 892, DateTimeKind.Local).AddTicks(4309));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 22, 13, 35, 892, DateTimeKind.Local).AddTicks(4314));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 22, 13, 35, 892, DateTimeKind.Local).AddTicks(4316));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 22, 13, 35, 892, DateTimeKind.Local).AddTicks(4317));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 22, 13, 35, 892, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 22, 13, 35, 892, DateTimeKind.Local).AddTicks(4322));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 22, 13, 35, 900, DateTimeKind.Local).AddTicks(989));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 22, 13, 35, 900, DateTimeKind.Local).AddTicks(2029));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 22, 13, 35, 900, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2021, 8, 25, 22, 13, 35, 900, DateTimeKind.Local).AddTicks(2072), "Los Shakes (Sorvete e Açaí)" });
        }
    }
}
