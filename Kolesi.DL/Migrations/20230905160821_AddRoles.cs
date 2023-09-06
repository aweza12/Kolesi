using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kolesi.DL.Migrations
{
    /// <inheritdoc />
    public partial class AddRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bicycles",
                keyColumn: "Id",
                keyValue: new Guid("15ff79c4-00c1-4d84-8188-78caaded4959"));

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1fbc0c1d-aed4-4461-8494-d7db400a3bf6", null, "Role", "User", null },
                    { "b81fae67-adee-46b3-b13c-ee05da003bf4", null, "Role", "Admin", null }
                });

            migrationBuilder.InsertData(
                table: "Bicycles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("35bdc05c-da5b-4d62-9df9-7ae504b0cb77"), "My" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fbc0c1d-aed4-4461-8494-d7db400a3bf6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b81fae67-adee-46b3-b13c-ee05da003bf4");

            migrationBuilder.DeleteData(
                table: "Bicycles",
                keyColumn: "Id",
                keyValue: new Guid("35bdc05c-da5b-4d62-9df9-7ae504b0cb77"));

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Bicycles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("15ff79c4-00c1-4d84-8188-78caaded4959"), "My" });
        }
    }
}
