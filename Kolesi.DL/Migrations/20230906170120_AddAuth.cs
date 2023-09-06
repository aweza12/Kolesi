using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kolesi.DL.Migrations
{
    /// <inheritdoc />
    public partial class AddAuth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3510a3d6-f379-4995-94be-6473a2584ead", null, "Role", "Admin", null },
                    { "481a5640-755d-49d7-83b0-53cdd37e34cb", null, "Role", "User", null }
                });

            migrationBuilder.InsertData(
                table: "Bicycles",
                columns: new[] { "Id", "Name" },
                values: new object[] { new Guid("6766e27d-fcee-468e-90d5-648776c1d61c"), "My" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3510a3d6-f379-4995-94be-6473a2584ead");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "481a5640-755d-49d7-83b0-53cdd37e34cb");

            migrationBuilder.DeleteData(
                table: "Bicycles",
                keyColumn: "Id",
                keyValue: new Guid("6766e27d-fcee-468e-90d5-648776c1d61c"));

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

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
    }
}
