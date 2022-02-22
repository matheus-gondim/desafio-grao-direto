using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace GrainRestaurants.Infrastructure.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PostalCode = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: true),
                    Number = table.Column<string>(type: "text", nullable: true),
                    District = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Uf = table.Column<string>(type: "text", nullable: true),
                    AdditionalInfo = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RestaurantType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RestaurantType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "text", nullable: false),
                    RefreshToken = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Restaurant",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    FederalDocument = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    RestaurantTypeId = table.Column<long>(type: "bigint", nullable: false),
                    Score = table.Column<double>(type: "double precision", nullable: false),
                    Phone = table.Column<string>(type: "text", nullable: false),
                    IsOpen = table.Column<bool>(type: "boolean", nullable: false),
                    AddressId = table.Column<long>(type: "bigint", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    Resume = table.Column<string>(type: "text", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restaurant_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Restaurant_RestaurantType_RestaurantTypeId",
                        column: x => x.RestaurantTypeId,
                        principalTable: "RestaurantType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Password",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Hash = table.Column<string>(type: "text", nullable: false),
                    Salt = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Password", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Password_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dish",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()"),
                    RestaurantId = table.Column<long>(type: "bigint", nullable: false),
                    Items = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dish", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dish_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "AdditionalInfo", "City", "Country", "District", "Location", "Number", "PostalCode", "Uf" },
                values: new object[,]
                {
                    { 1L, "", "Uberaba", null, "Santa Maria", "Av Pedro Salomao", "44", "38050-490", "MG" },
                    { 2L, "", "Uberaba", null, "Centro", "Av Santos Dumont", "10", "38010-370", "MG" },
                    { 3L, "", "Uberaba", null, "Olinda", "Rua Jonas de Carvalho", "55", "38055-440", "MG" },
                    { 4L, "", "Uberaba", null, "Estados Unidos", "Avenida Quinze de Novembro", "515", "38015-305", "MG" }
                });

            migrationBuilder.InsertData(
                table: "RestaurantType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Árabe" },
                    { 2L, "Oriental" },
                    { 3L, "Brasileira" },
                    { 4L, "Italiana" },
                    { 5L, "Lanche" },
                    { 6L, "Pizzaria" },
                    { 7L, "Fast Food" },
                    { 8L, "Sorveteria" }
                });

            migrationBuilder.InsertData(
                table: "Restaurant",
                columns: new[] { "Id", "AddressId", "CreatedAt", "DeletedAt", "FederalDocument", "ImageUrl", "IsOpen", "Name", "Phone", "RestaurantTypeId", "Resume", "Score", "UpdatedAt" },
                values: new object[,]
                {
                    { 2L, 2L, new DateTime(2021, 8, 25, 20, 19, 41, 725, DateTimeKind.Local).AddTicks(1359), null, "03640022000104", "https://static-images.ifood.com.br/image/upload/t_high/logosgde/b3e531ca-e1ff-4767-9868-edde3d624366/202103031204_JOYV_i.jpg", true, "Habib's", "33333333", 1L, "O Habib’s é a maior rede de restaurantes do mundo de comida árabe. Delícias como a exclusiva esfiha, kibe, beirute, pastel, pizzas, bolinho de bacalhau e sobremesas como sorvetes, pastel de belém, pudim e refrigerantes e sucos completam seu pedido", 4.4000000000000004, null },
                    { 3L, 3L, new DateTime(2021, 8, 25, 20, 19, 41, 725, DateTimeKind.Local).AddTicks(1396), null, "10504193000171", "https://static-images.ifood.com.br/image/upload/t_high/logosgde/3fb30be0-33de-4ac9-a7af-a3434bea1f7d/202101301033_SQbY_i.png", true, "Macarrão e Cia", "33333333", 4L, "Macarrão e CIA começa em 2005 quando o adquirimos numa oportunidade de negócio. Inicialmente havia um pequeno carro de cachorro quente e uma chapa, localizado na Praça Pôr do Sol em Uberaba.Em janeiro de 2010 seguimos a expansão e abrimos o serviço de \"delivery\".", 4.5, null },
                    { 1L, 1L, new DateTime(2021, 8, 25, 20, 19, 41, 723, DateTimeKind.Local).AddTicks(6066), null, "01631311000464", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAAOEAAADhCAMAAAAJbSJIAAAAclBMVEXcCxz/txvaABz/uRv/uxv/vxv/wBv/vRvcABz3mxv+tBv9rRvxghvlShzyhRv6ohvoVxztcRz7qBv3lxv5oBvgKhzkQhz9sBvoXBzraBzvehznURziORzzihvxfxveHRz1kBvpYhzhMxzudRz/yBvsbBsWFK+CAAAJWElEQVR4nO1caVciSwy1q7cad1BU0Bl0GP//X3wIYmepJQWk4byT+22ETCdVWW5S1VxcGAwGg8FgMBgMBoPBYDAYDAaDwWAwGAwGg8FgMBgMBoPBYDAYDAZDFH6Lk0iPAe+W95PFYn5z4crV9O7iZr5YTO6XewiPA+8/p23frNH3jy+Fanr38thvhdvp59ra84N386qvdqj75xIb1/Y99/WPdF/Nz28f/Ww62LdBe7eUaumXdy0W7qezM9tG99rUFUFdv8q0dK81F27uz8pE99lRFb/QTSRauklY+POMTIzouNZykdfSLWLCovUZBe4jouM6GLMmulUbE+7mZ2KivwE61n3XNgVa4tVp2g6k1KoVBrIy/Awk0X768fa0ugQ2dk+pjOqfgIHN5erp7eMO/nezcyga/mpY9Xbi1qzL+XegZZ0oGn4Jdqx/9xvpyeAS9dUZWOh+DxvWfnx7lbsFxf8u7mruDpT5253wx2Bi8/vkfgqDsB/SintoQn8mcKthIZqHQXgx/Lm9OfUu+svwZoG/V/3fsJb+L3DmS/AduLWXJ7bQ3Q571cG0APe2noY30U1BBMO98rMh/zS3J/VTmEeba6SKewAhFqQnbg6C9QELXwMnj3jAOHC/BjNq/BHcB/rZN0Ae7WhZAP/vrxNuon8FWe+aKAKTbMjVoIOzlOn+gAz9erpNhIHU07KHmEDLSjcmCvRjvwQeHAnjEeDvQTZ5Z2rASCRxlv30wr2DLHR/qk10V2CTODlDfLUl+cL/hR/youefwOdXJ9pEuIVBJeAK0G2CW5gVPtUmwrrchHiLm0AGjkINZdom1Ai61SCcIn6KQH7Esv3mG0tIwFG6dL8h5Q5xc78EaxCIgRGAUkV4keEuVw2wwy/B7gqEA6lIHyjbN5PgGvtPYAh0ZLeAH3yGhaGPn6JRRErycrcB8jTIoSEvr7pwA4mXUDDwOTaQkrF0jty0f9lZ4l9ggMYKOsymJ2gxUKmI8n+/gvH2uPuWe4TxuYpZeA29ZPSCATl31cfaVP8GB2k7X/Yz9Ne3mDCacI3Nv3GE1dH1Rb68CyYUwgn/83ASHolWNaBEl1hfSC/XxnxbCM0OENofYegnkXStBthVpB7u5/C8Zss/kfdV/TwujJZx3A4DZfIU48Bf3PIaxGdihWYj/BSK4nGAI6lJPNo9gy9uYw7FZvWc2BqPnjJqSUSlKsmLcSD263bdv6JtjYchKaej9lCouauaP6ltmDfEHuykTTwM8SyDt5iaQCmg6lPFGFfEqlrvIfp3tBpuhNF2j5lNsfd0ye+iorbOpg6lj0Qp3QBV3TG7RKRkKlfQ1WiuERfLaY3ivWqPa0QC/kOcKwi7/EoXSGk2gyTCOE99jOWmaMayZs7J56I+4ivu0P4P/UZYGAX8eH0wzhVR2v395Rk6Aq+nKC6D0w8gfIOWJxO0RwOmGuEpC4CrUkjvCpr0jDeugVOwKt+bomaQYGgZI/CIEo1Fa3B2zDZu8HyCInt0htqL8eoF0jjJaL6A2wuMRGOxBWY1VXM8I1IaI6KRT+EkbBGygUUycT/KMRRZ1iTt2mCZ2MNlRpaQvkz5PBJwGAocBzdQCM/5LUHLOVIg4tSY72niyTSbSilvixwmHxckrAQzsHgyrfO3EDB/GqUiYiIliQzcIiLh8DwfgtDaMToosqjJDnYLQr0AMoRvI4yXZwxqikaBMiVnUQvzwyW2POoWEiKdo85bmYiBEia9z/MOAynBVS94oJtGLJSMQD15XrrdOgJoYpQMwEjoDlsoCSpSLvQvgZHiJjowiZULkbaYe0tK6IEgMSWoaOQoGFqYLxaB5VH2UpoXRfXJ34eTaXIM+SNMlkf7vJsqK1PyLdxd5En7vk88APjAQqjkxTJiYa6z+AKer+v3+TQt9jKpSBzKdMV7qM1qWCckchmS8XeQHbXgo6rcAPpg0G5WpmS4fxImfro82a75INCJhPD+AD5u+hFOD8t/hHFBVG6g6FRJqKT/EwrE5o/MxcnyZKdXB4F0a9LEFu4QBY3X5pkkfevOaqjHiFhJrOQLKxtdHt2bNSzqhUoGS74woNjyqJ52+3o/JZehFxSFd4DYvFXzfIa2o/IbIME4lD6UWKjZBJNxt3zKTqv2BuLrhmR5NAffrA2SKhkkNdJ4ossjTG97gfVqUgYVIjXiXpYyRVFPuidosZArGZhjiCk0XR7NckGdTa5kgLbV0tdD2fIolgtH87bUX1yAtmUPHn+EaWy0ehbSsibuRv0qYGH6DscAR4U7te6C1V5xVgudA4sZNMvget0FnQbLx7MhYioeuOz/2GKQYyfRocW35A0npgXClGeoHUDxkBfNoS7C1LtAmFqoVhDxLbOqYHbJuGVVwGnZ2ZWw794D5AT/62UtoaQPzBNb+esFxHX0TvMZu0xd8E4rWZXcjaE9m17JZ+eA8peRQkeIcmHWmahRb7oR8rUM3DgR3DTZCTPf2U/9LNDPWGwgf8kjZKFceEoznNKddj5OkJ/lMSWLlof2XlqkhhGTgiME3iCWLA9tLrTOn9jUs6Au8QaxZHloHdbq8hnHF3d4ASWLLKTdZfSlzAPBSFvB9DlgYYED0O5Si7ZxZ1nIE/4ts1DuAH6xf3gUgU5pSjg+b/ILHID1NFqTGpbxCwKeHq8UnVazFljrbUtWtRv5Oyx8jCEeYtB3dL6gdA7M6GFBWWKOVuLifEKg9HY+Y88F43V+aajAxdlhghb1ZjfSC34tjp+RCs9HN8JsBqJzls+72PSPPmJhFkoFL6Khn4/crq3Ky/n06s7aQumkJTAvKxmY+TdmoUpzwadJnfw5PFmUpCl6bCmfYhWBR0PBDznwZFFiITtC1vm9SK5k+gXgjHDROSe1UOeQlDtaiYXsvn6Jkp5ZqNIg8nTYFejILSxwNG6hyhvB/HTlhBaq3IvixKuTs8PDLHTUQp2TC06ex7OQZvEC2l4A1odWfYGFT8zCgnkZu4Fb0HsXINDilezhvw7jX8ke0gGBzlVobmHJO0jeURTsAnvhXclCNoi4HOsnDhztTMW3HMoec0IL2XRBx8JraqHynXLwaGahyi1as1ARZuGxHnPb1xgjWkie3KuM9f3k8RfGaD+I497Jkx91btTwoq3xlCAOoQsGg8FgMBgMBoPBYDAYDAaDwWAwGAwGg8FgMBgMBoPBYDAYDAaD4f+F/wDlFm79dgoNpQAAAABJRU5ErkJggg==", true, "Mcdonald's", "33333333", 7L, "Líder no segmento de serviço rápido de alimentação, o McDonalds se destaca pela qualidade dos produtos e do atendimento. Sempre temos uma Mc Oferta especial (promoção) de Hamburguer, lanches, sanduíche, batata e sorvete. Aproveite!", 4.7000000000000002, null },
                    { 4L, 4L, new DateTime(2021, 8, 25, 20, 19, 41, 725, DateTimeKind.Local).AddTicks(1400), null, "26187594000185", "https://static-images.ifood.com.br/image/upload/t_high/logosgde/f9ea38f4-c7db-4525-b92d-1798e0629aa4/201909101527_hhaI_.jpeg", true, "Los Shakes (Sorvete e Açaí)", "33333333", 8L, "Deliciosa linha de Sorvetes , Milkshakes , Açaí e Açaí Zero Açúcar !!!!! Venha saborear o verdadeiro sabor do Açaí.", 4.9000000000000004, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dish_Name_RestaurantId",
                table: "Dish",
                columns: new[] { "Name", "RestaurantId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Dish_RestaurantId",
                table: "Dish",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Password_UserId",
                table: "Password",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_AddressId",
                table: "Restaurant",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_FederalDocument",
                table: "Restaurant",
                column: "FederalDocument",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_Name",
                table: "Restaurant",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Restaurant_RestaurantTypeId",
                table: "Restaurant",
                column: "RestaurantTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_RestaurantType_Name",
                table: "RestaurantType",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_Email",
                table: "User",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dish");

            migrationBuilder.DropTable(
                name: "Password");

            migrationBuilder.DropTable(
                name: "Restaurant");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "RestaurantType");
        }
    }
}
