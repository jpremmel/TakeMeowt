using Microsoft.EntityFrameworkCore.Migrations;

namespace PetTinder.Migrations
{
    public partial class MoreSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 16,
                columns: new[] { "LookingFor", "Photo2" },
                values: new object[] { "A calm, stable partner to balance out my erratic tendencies. Someone who wants to play but only when I feel like it.", "uploads/jasper16/20190701_120005.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 16,
                columns: new[] { "LookingFor", "Photo2" },
                values: new object[] { "", "" });
        }
    }
}
