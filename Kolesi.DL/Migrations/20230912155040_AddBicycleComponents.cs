using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Kolesi.DL.Migrations
{
    /// <inheritdoc />
    public partial class AddBicycleComponents : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<Guid>(
                name: "ChainId",
                table: "Bicycles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedOn",
                table: "Bicycles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "ForkId",
                table: "Bicycles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FrameId",
                table: "Bicycles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "FrontWheelId",
                table: "Bicycles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "Bicycles",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "RearWheelId",
                table: "Bicycles",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Manufacturer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Chain",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Links = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chain", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chain_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fork",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Length = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fork", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fork_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Frame",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Size = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Frame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Frame_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wheel",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Size = table.Column<float>(type: "real", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ItemCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ManufacturerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wheel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wheel_Manufacturer_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bb9146e3-eb3e-4530-9bf2-89ae1936d192", null, "Role", "Admin", null },
                    { "cab49761-4357-4a00-bbb2-4b6da0b53289", null, "Role", "User", null }
                });

            migrationBuilder.InsertData(
                table: "Bicycles",
                columns: new[] { "Id", "ChainId", "CreatedOn", "ForkId", "FrameId", "FrontWheelId", "ModifiedOn", "Name", "RearWheelId" },
                values: new object[] { new Guid("ae078c31-e972-4167-a573-dcbe6dba67cf"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, "My", null });

            migrationBuilder.CreateIndex(
                name: "IX_Bicycles_ChainId",
                table: "Bicycles",
                column: "ChainId");

            migrationBuilder.CreateIndex(
                name: "IX_Bicycles_ForkId",
                table: "Bicycles",
                column: "ForkId");

            migrationBuilder.CreateIndex(
                name: "IX_Bicycles_FrameId",
                table: "Bicycles",
                column: "FrameId");

            migrationBuilder.CreateIndex(
                name: "IX_Bicycles_FrontWheelId",
                table: "Bicycles",
                column: "FrontWheelId");

            migrationBuilder.CreateIndex(
                name: "IX_Bicycles_RearWheelId",
                table: "Bicycles",
                column: "RearWheelId");

            migrationBuilder.CreateIndex(
                name: "IX_Chain_ManufacturerId",
                table: "Chain",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Fork_ManufacturerId",
                table: "Fork",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Frame_ManufacturerId",
                table: "Frame",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Wheel_ManufacturerId",
                table: "Wheel",
                column: "ManufacturerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bicycles_Chain_ChainId",
                table: "Bicycles",
                column: "ChainId",
                principalTable: "Chain",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bicycles_Fork_ForkId",
                table: "Bicycles",
                column: "ForkId",
                principalTable: "Fork",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bicycles_Frame_FrameId",
                table: "Bicycles",
                column: "FrameId",
                principalTable: "Frame",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bicycles_Wheel_FrontWheelId",
                table: "Bicycles",
                column: "FrontWheelId",
                principalTable: "Wheel",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Bicycles_Wheel_RearWheelId",
                table: "Bicycles",
                column: "RearWheelId",
                principalTable: "Wheel",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bicycles_Chain_ChainId",
                table: "Bicycles");

            migrationBuilder.DropForeignKey(
                name: "FK_Bicycles_Fork_ForkId",
                table: "Bicycles");

            migrationBuilder.DropForeignKey(
                name: "FK_Bicycles_Frame_FrameId",
                table: "Bicycles");

            migrationBuilder.DropForeignKey(
                name: "FK_Bicycles_Wheel_FrontWheelId",
                table: "Bicycles");

            migrationBuilder.DropForeignKey(
                name: "FK_Bicycles_Wheel_RearWheelId",
                table: "Bicycles");

            migrationBuilder.DropTable(
                name: "Chain");

            migrationBuilder.DropTable(
                name: "Fork");

            migrationBuilder.DropTable(
                name: "Frame");

            migrationBuilder.DropTable(
                name: "Wheel");

            migrationBuilder.DropTable(
                name: "Manufacturer");

            migrationBuilder.DropIndex(
                name: "IX_Bicycles_ChainId",
                table: "Bicycles");

            migrationBuilder.DropIndex(
                name: "IX_Bicycles_ForkId",
                table: "Bicycles");

            migrationBuilder.DropIndex(
                name: "IX_Bicycles_FrameId",
                table: "Bicycles");

            migrationBuilder.DropIndex(
                name: "IX_Bicycles_FrontWheelId",
                table: "Bicycles");

            migrationBuilder.DropIndex(
                name: "IX_Bicycles_RearWheelId",
                table: "Bicycles");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb9146e3-eb3e-4530-9bf2-89ae1936d192");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cab49761-4357-4a00-bbb2-4b6da0b53289");

            migrationBuilder.DeleteData(
                table: "Bicycles",
                keyColumn: "Id",
                keyValue: new Guid("ae078c31-e972-4167-a573-dcbe6dba67cf"));

            migrationBuilder.DropColumn(
                name: "ChainId",
                table: "Bicycles");

            migrationBuilder.DropColumn(
                name: "CreatedOn",
                table: "Bicycles");

            migrationBuilder.DropColumn(
                name: "ForkId",
                table: "Bicycles");

            migrationBuilder.DropColumn(
                name: "FrameId",
                table: "Bicycles");

            migrationBuilder.DropColumn(
                name: "FrontWheelId",
                table: "Bicycles");

            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "Bicycles");

            migrationBuilder.DropColumn(
                name: "RearWheelId",
                table: "Bicycles");

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
    }
}
