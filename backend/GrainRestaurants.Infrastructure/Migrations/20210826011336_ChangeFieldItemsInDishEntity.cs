using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GrainRestaurants.Infrastructure.Migrations
{
    public partial class ChangeFieldItemsInDishEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Items",
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
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 22, 13, 35, 900, DateTimeKind.Local).AddTicks(2072));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Itens",
                table: "Dish",
                newName: "Items");

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 21, 19, 57, 196, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 2L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 21, 19, 57, 197, DateTimeKind.Local).AddTicks(5346));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 3L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 21, 19, 57, 197, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 4L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 21, 19, 57, 197, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 5L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 21, 19, 57, 197, DateTimeKind.Local).AddTicks(5369));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 6L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 21, 19, 57, 197, DateTimeKind.Local).AddTicks(5374));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 7L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 21, 19, 57, 197, DateTimeKind.Local).AddTicks(5376));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 8L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 21, 19, 57, 197, DateTimeKind.Local).AddTicks(5378));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 9L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 21, 19, 57, 197, DateTimeKind.Local).AddTicks(5379));

            migrationBuilder.UpdateData(
                table: "Dish",
                keyColumn: "Id",
                keyValue: 10L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 21, 19, 57, 197, DateTimeKind.Local).AddTicks(5382));

            migrationBuilder.UpdateData(
                table: "Restaurant",
                keyColumn: "Id",
                keyValue: 1L,
                column: "CreatedAt",
                value: new DateTime(2021, 8, 25, 21, 19, 57, 206, DateTimeKind.Local).AddTicks(4021));

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
    }
}
