using Microsoft.EntityFrameworkCore.Migrations;

namespace PetTinder.Migrations
{
    public partial class SylviePics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 1,
                columns: new[] { "Photo2", "Photo3", "Photo4" },
                values: new object[] { "uploads/sylvie1/20190604_125610.jpg", "uploads/sylvie1/20170531_140539.jpg", "uploads/sylvie1/20170531_140534.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 1,
                columns: new[] { "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "", "" });
        }
    }
}
