using Microsoft.EntityFrameworkCore.Migrations;

namespace PetTinder.Migrations
{
    public partial class Seeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 4,
                columns: new[] { "Photo2", "Photo3", "Photo4" },
                values: new object[] { "uploads/toad4/IMG_20171219_183621.jpg", "uploads/toad4/IMG_20190727_151423.jpg", "uploads/toad4/IMG_20180205_214524_1.jpg" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 5,
                columns: new[] { "Photo2", "Photo3", "Photo4" },
                values: new object[] { "uploads/winston5/Image from iOS.jpg", "uploads/winston5/Image from iOS (2).jpg", "uploads/winston5/Image from iOS (1).jpg" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 15,
                columns: new[] { "Photo2", "Photo3" },
                values: new object[] { "uploads/ashford15/20191026_201344.jpg", "uploads/ashford15/20190809_114702.jpg" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Age", "Bio", "Breed", "Gender", "LookingFor", "Name", "Photo1", "Photo2", "Photo3", "Photo4", "Species", "UserId" },
                values: new object[,]
                {
                    { 18, 2, "Too much excited. Big love. Likes to wear her work vest to feel important.", "Mut", "female", "durable play mate", "Luna", "uploads/luna18/20190731_094803.jpg", "uploads/luna18/IMG-20190830-WA0000.jpg", "uploads/luna18/Screenshot_20190709-093242_Snapchat.jpg", "", "Dog", null },
                    { 19, 2, "Very sweet but loves murder. Watch your feet!", "Shorthair", "Female", "A murder pal and snuggles", "Patches", "uploads/patches19/Image from iOS (3).jpg", "", "", "", "Cat", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 19);

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 4,
                columns: new[] { "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 5,
                columns: new[] { "Photo2", "Photo3", "Photo4" },
                values: new object[] { "", "", "" });

            migrationBuilder.UpdateData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 15,
                columns: new[] { "Photo2", "Photo3" },
                values: new object[] { "", "" });
        }
    }
}
