using Microsoft.EntityFrameworkCore.Migrations;

namespace PetTinder.Migrations
{
    public partial class UpdatePhotoPaths : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 1,
                column: "Photo1",
                value: "uploads/sylvie1/sylvie-jacqueline.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 2,
                column: "Photo1",
                value: "uploads/bridget2/bridget-jason.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 3,
                column: "Photo1",
                value: "uploads/chunk3/chunk-sofia.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 4,
                column: "Photo1",
                value: "uploads/toad4/toad-sofia.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 5,
                column: "Photo1",
                value: "uploads/winston5/winston-mike.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 6,
                column: "Photo1",
                value: "uploads/roscoe6/roscoe-jen.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 7,
                column: "Photo1",
                value: "uploads/mau7/mau-micah.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 8,
                column: "Photo1",
                value: "uploads/jasper8/jasper-chris.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 9,
                column: "Photo1",
                value: "uploads/wren9/wren-chris.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 10,
                column: "Photo1",
                value: "uploads/molly10/molly-christine.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 11,
                column: "Photo1",
                value: "uploads/uwa11/uwa-erin.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 12,
                column: "Photo1",
                value: "uploads/mocha12/mocha-erin.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 13,
                column: "Photo1",
                value: "uploads/stripes13/stripes-carrie.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 14,
                column: "Photo1",
                value: "uploads/kima14/kima-joel.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 15,
                column: "Photo1",
                value: "uploads/ashford15/ashford-anita.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 16,
                column: "Photo1",
                value: "uploads/jasper16/jasper-jacqueline.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 17,
                column: "Photo1",
                value: "uploads/levi17/levi-jason.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 1,
                column: "Photo1",
                value: "~/uploads/sylvie1/sylvie-jacqueline.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 2,
                column: "Photo1",
                value: "~/uploads/bridget2/bridget-jason.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 3,
                column: "Photo1",
                value: "~/uploads/chunk3/chunk-sofia.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 4,
                column: "Photo1",
                value: "~/uploads/toad4/toad-sofia.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 5,
                column: "Photo1",
                value: "~/uploads/winston5/winston-mike.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 6,
                column: "Photo1",
                value: "~/uploads/roscoe6/roscoe-jen.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 7,
                column: "Photo1",
                value: "~/uploads/mau7/mau-micah.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 8,
                column: "Photo1",
                value: "~/uploads/jasper8/jasper-chris.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 9,
                column: "Photo1",
                value: "~/uploads/wren9/wren-chris.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 10,
                column: "Photo1",
                value: "~/uploads/molly10/molly-christine.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 11,
                column: "Photo1",
                value: "~/uploads/uwa11/uwa-erin.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 12,
                column: "Photo1",
                value: "~/uploads/mocha12/mocha-erin.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 13,
                column: "Photo1",
                value: "~/uploads/stripes13/stripes-carrie.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 14,
                column: "Photo1",
                value: "~/uploads/kima14/kima-joel.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 15,
                column: "Photo1",
                value: "~/uploads/ashford15/ashford-anita.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 16,
                column: "Photo1",
                value: "~/uploads/jasper16/jasper-jacqueline.jpg");

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 17,
                column: "Photo1",
                value: "~/uploads/levi17/levi-jason.jpg");
        }
    }
}
