using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GrainRestaurants.Infrastructure.Migrations
{
    public partial class AddSeedsDish : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Dish",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Dish",
                columns: new[] { "Id", "CreatedAt", "ImageUrl", "Items", "Name", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 1L, new DateTime(2021, 8, 25, 21, 19, 57, 196, DateTimeKind.Local).AddTicks(7742), "https://static-images.ifood.com.br/image/upload/t_medium/pratos/1a003463-20d8-4744-841a-6ac212a66c4b/202108101448_P6S1_f.png", "Frango empanado e dourado com molho suave e cremoso, acompanhado de alface fresquinho, fatias de bacon crocante num pão com gergelim, acompanhamento e bebida.", "Mc Oferta McChicken Bacon", 29.899999999999999, 1L },
                    { 2L, new DateTime(2021, 8, 25, 21, 19, 57, 197, DateTimeKind.Local).AddTicks(5346), "https://static-images.ifood.com.br/image/upload/t_low/pratos/1a003463-20d8-4744-841a-6ac212a66c4b/202108101452_10TW_f.png", "Frango empanado e dourado com o delicioso molho barbecue, cebola fresca, bacon crocante, fatia de queijo cheddar num pão com gergelim, acompanhamento e bebida. Consulte informações nutricionais do refrigerante 400ml em: mcdonalds.com.br/cardapio/bebidas. Não utilize o campo de observações, as alterações devem ser realizadas no pedido.", "McOferta McChicken Barbecue", 28.899999999999999, 1L },
                    { 3L, new DateTime(2021, 8, 25, 21, 19, 57, 197, DateTimeKind.Local).AddTicks(5364), "https://static-images.ifood.com.br/image/upload/t_medium/pratos/1a003463-20d8-4744-841a-6ac212a66c4b/202108101448_P6S1_f.png", "Frango empanado e dourado com o maravilhoso molho cheddar McMelt, cebola shoyo num pão com gergelim, acompanhamento e bebida. Consulte informações nutricionais do refrigerante 400ml em: mcdonalds.com.br/cardapio/bebidas. Não utilize o campo de observações, as alterações devem ser realizadas no pedido.", "Mc Oferta McChicken Cheddar", 23.899999999999999, 1L },
                    { 4L, new DateTime(2021, 8, 25, 21, 19, 57, 197, DateTimeKind.Local).AddTicks(5367), "https://static-images.ifood.com.br/image/upload/t_low/pratos/6306ea52-09eb-4439-97b4-5d353742d884/202003101215_YD7v_1.png", "O maior sanduíche de carne 100% bovina do mcdonald’s agora também com creme de muçarela, 2 deliciosas fatias de queijo cheddar e emental, tomate, alface, cebola e o delicioso molho tasty. Mais acompanhamento e bebida em sua McOferta.", "McOferta Big Tasty turbo queijo", 41.899999999999999, 1L },
                    { 5L, new DateTime(2021, 8, 25, 21, 19, 57, 197, DateTimeKind.Local).AddTicks(5369), "https://static-images.ifood.com.br/image/upload/t_low/pratos/3ec68ed2-db26-4613-827f-ddcdd4777f76/202011121100_ecUL_f.png", "Um delicioso hambúrguer feito com picanha, 4 fatias crocantes de bacon, nosso cremoso cheddar, cebola crispy e pão com gergelim.", "McOferta mcpicanha cheddar bacon", 43.899999999999999, 1L },
                    { 6L, new DateTime(2021, 8, 25, 21, 19, 57, 197, DateTimeKind.Local).AddTicks(5374), "https://static-images.ifood.com.br/image/upload/t_low/pratos/3ec68ed2-db26-4613-827f-ddcdd4777f76/202108101052_1OO2_i.jpg", "A novidade com Kitkat chega para gerar momentos deliciosos... Venha dar um Break com Kitkat e Mcdonald's! Calda de Chocolate!", "McFlurry Kit Kat Chocolate", 13.9, 1L },
                    { 7L, new DateTime(2021, 8, 25, 21, 19, 57, 197, DateTimeKind.Local).AddTicks(5376), "https://static-images.ifood.com.br/image/upload/t_low/pratos/3ec68ed2-db26-4613-827f-ddcdd4777f76/202108101052_18NX_i.jpg", "A novidade com Kitkat chega para gerar momentos deliciosos... Venha dar um Break com Kitkat e Mcdonald's! Calda de Morango!", "McFlurry Kitkat Morango", 13.9, 1L },
                    { 8L, new DateTime(2021, 8, 25, 21, 19, 57, 197, DateTimeKind.Local).AddTicks(5378), "https://static-images.ifood.com.br/image/upload/t_low/pratos/3ec68ed2-db26-4613-827f-ddcdd4777f76/202005311428_3fyS_2.jpg", "Uma delícia gelada sabor baunilha, uma supercamada de cobertura de chocolate, caramelo ou morango e ainda por cima com farofa de paçoca.O canudo completa a tentação.", "Top sunadae de morango", 13.9, 1L },
                    { 9L, new DateTime(2021, 8, 25, 21, 19, 57, 197, DateTimeKind.Local).AddTicks(5379), "https://static-images.ifood.com.br/image/upload/t_low/pratos/3ec68ed2-db26-4613-827f-ddcdd4777f76/202107211616_JD81_i.jpg", "O novo McShake é feito com leite e batido na hora. Você pode escolher nos sabores Ovomaltine , Chocolate Kopenhagen ou morango.", "McShake Morango", 15.9, 1L },
                    { 10L, new DateTime(2021, 8, 25, 21, 19, 57, 197, DateTimeKind.Local).AddTicks(5382), "https://static-images.ifood.com.br/image/upload/t_low/pratos/3ec68ed2-db26-4613-827f-ddcdd4777f76/202108031953_6NW0_i.jpg", "O novo McShake é feito com leite e batido na hora. Você pode escolher nos sabores Ovomaltine , Chocolate Kopenhagen ou morango.", "McShake chocolate Kopenhagen", 15.9, 1L }
                });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2021, 8, 25, 21, 19, 57, 206, DateTimeKind.Local).AddTicks(4021), "https://static-images.ifood.com.br/image/upload/t_thumbnail/logosgde/201901041513_3ec68ed2-db26-4613-827f-ddcdd4777f76.jpg" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 21, 19, 57, 206, DateTimeKind.Local).AddTicks(4932));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 21, 19, 57, 206, DateTimeKind.Local).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 21, 19, 57, 206, DateTimeKind.Local).AddTicks(4940));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 1L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Dish");

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedAt", "ImageUrl" },
                values: new object[] { new DateTime(2021, 8, 25, 20, 19, 41, 723, DateTimeKind.Local).AddTicks(6066), "data:image/png;base64,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" });

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 20, 19, 41, 725, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 20, 19, 41, 725, DateTimeKind.Local).AddTicks(1396));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 20, 19, 41, 725, DateTimeKind.Local).AddTicks(1400));
        }
    }
}
