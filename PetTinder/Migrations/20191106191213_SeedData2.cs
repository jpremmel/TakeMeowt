using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetTinder.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestPhoto1",
                table: "Pets");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Pets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Pets");

            migrationBuilder.AddColumn<byte[]>(
                name: "TestPhoto1",
                table: "Pets",
                nullable: true);
        }
    }
}
