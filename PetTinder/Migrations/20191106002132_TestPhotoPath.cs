using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetTinder.Migrations
{
    public partial class TestPhotoPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "TestPhoto1",
                table: "Pets",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TestPhoto1",
                table: "Pets");
        }
    }
}
