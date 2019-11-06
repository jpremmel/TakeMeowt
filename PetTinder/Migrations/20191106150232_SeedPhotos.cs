using Microsoft.EntityFrameworkCore.Migrations;

namespace PetTinder.Migrations
{
    public partial class SeedPhotos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 1,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "A cuddle buddy who will never leave my side.", "~/uploads/sylvie1/sylvie-jacqueline.jpg", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 2,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "~/uploads/bridget2/bridget-jason.jpg", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 3,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "~/uploads/chunk3/chunk-sofia.jpg", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 4,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "~/uploads/toad4/toad-sofia.jpg", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 5,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "~/uploads/winston5/winston-mike.jpg", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 6,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "~/uploads/roscoe6/roscoe-jen.jpg", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 7,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "~/uploads/mau7/mau-micah.jpg", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 8,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "~/uploads/jasper8/jasper-chris.jpg", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 9,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "~/uploads/wren9/wren-chris.jpg", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 10,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "~/uploads/molly10/molly-christine.jpg", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 11,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "~/uploads/uwa11/uwa-erin.jpg", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 12,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "~/uploads/mocha12/mocha-erin.jpg", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 13,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "~/uploads/stripes13/stripes-carrie.jpg", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 14,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "~/uploads/kima14/kima-joel.jpg", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 15,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "~/uploads/ashford15/ashford-anita.jpg", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 16,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "~/uploads/jasper16/jasper-jacqueline.jpg", "", "", "" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 17,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "~/uploads/levi17/levi-jason.jpg", "", "", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 1,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 2,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 3,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 4,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 5,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 6,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 7,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 8,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 9,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 10,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 11,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 12,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 13,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 14,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 15,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 16,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 17,
                columns: new[] { "LookingFor", "Photo1", "Photo2", "Photo3", "Photo4" },
                values: new object[] { null, null, null, null, null });
        }
    }
}
