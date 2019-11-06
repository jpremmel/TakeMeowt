using Microsoft.EntityFrameworkCore.Migrations;

namespace PetTinder.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Age", "Bio", "Breed", "Gender", "LookingFor", "Name", "Photo1", "Photo2", "Photo3", "Photo4", "Species", "UserId" },
                values: new object[,]
                {
                    { 1, 6, "Grey, lanky, fluffy, distinct underbite. Favorite things: Chicken, tortellini, beach, snow, her toys, being cozy. Least favorite things: Grooming, vet visits, guitars, being cold, being alone.", "Shih-tzu mix", "Female", null, "Sylvie", null, null, null, null, "Dog", null },
                    { 15, 6, "Has an adorable moustache. Favorite things: sleeping. Least favorite things: screaming toddlers.", "Domestic short hair", "Male", null, "Ashford", null, null, null, null, "Cat", null },
                    { 14, 3, "The best dog ever. Favorite things: hikes. Least favorite things: shower.", "Coonhound/Lab", "Female", null, "Kima", null, null, null, null, "Dog", null },
                    { 13, 1, "Dangerous. Favorite things: Total domination, sleeping. Least favorite things: Being locked up.", "Unknown", "Male", null, "Stripes", null, null, null, null, "Cat", null },
                    { 12, 4, "Fluffy, talkative, will steal your cheese. Favorite things: Pets and butt scratches. Least favorite things: Thunder and Vacuums.", "Russian Blue Mix", "Female", null, "Mocha", null, null, null, null, "Cat", null },
                    { 11, 3, "Very Curious, loves to get into trouble spots. Favorite things: Climbing Branches. Least favorite things: Fast Movement.", "Ball Python", "Female", null, "Uwa", null, null, null, null, "Snake", null },
                    { 10, 2, "Ridiculously fluffy and adorable, and knows it. Favorite things: All squeeky toys. Least favorite things: Limes.", "Australian Shepherd", "Female", null, "Molly", null, null, null, null, "Dog", null },
                    { 16, 2, "Very sassy when restless but irresistably cute when sleepy. Favorite things: Paper bags, boxes, being gently stroked on the nose while falling asleep. Least favorite things: Sylvie.", "Mixed Breed Maine Coon", "Male", null, "Jasper", null, null, null, null, "Cat", null },
                    { 9, 4, "Wren is a red heeler that loves to pick on other dogs. Favorite things: Wren loves chasing her favorite toy at the park, she loves belly rubs, and cheese. Least favorite things: Rain and being told what to do", "Australian Cattledog", "Female", null, "Wren", null, null, null, null, "Dog", null },
                    { 7, 1, "Mau is friendly to a fault. Favorite things: Mau enjoys taking naps and climbing house plants. Least favorite things: Rain and being told what to do.", "Medium-hair Domestic Feline", "Female", null, "Mau", null, null, null, null, "Cat", null },
                    { 6, 5, "A Scooby Doo kinda guy looking for his Nova. Favorite things: Itch, eat all the human food scraps, long walks in the neighborhood, tennis balls. Least favorite things: Boxes, rain, baths, anything outdoors (except snow).", "German Shepard 1st Generation German-American", "Male", null, "Roscoe", null, null, null, null, "Dog", null },
                    { 5, 6, "A fine boi looking for his furrever girl. Favorite things: His blanket, chirping at birds and squirrels, snuggling on your lap, licking his butt. Least favorite things: The vacuum, being picked up, having his nails clipped.", "Short-hair Domestic Feline", "Male", null, "Winston", null, null, null, null, "Cat", null },
                    { 4, 7, "Lovebug, Angel, Shy. Favorite things: Snuggles, Gravy, Treats, Feather. Least favorite things: Loud noises, Strangers, Sudden movements, Vacuum.", "Medium-hair Domestic Feline", "Male", null, "Toad", null, null, null, null, "Cat", null },
                    { 3, 5, "Floofy McCuddlebug, Diva. Favorite Things: naps, snacks, being the little spoon, screaming. Least Favorite Things: Toe touches, Watching his brother get affection, Being hungry", "Long-hair Domestic Feline", "Male", null, "Chunk", null, null, null, null, "Cat", null },
                    { 2, 7, "lazy bum. favorite things: yogurt, cheese, carrots, sleep. least favorite things: grooming, vet visits, raspberries (not the food), being alone.", "Shih-tzu", "Female", null, "Bridget", null, null, null, null, "Dog", null },
                    { 8, 12, "A scary looking dog that is a true sweetheart. Favorite things: Jasper loves stuffed toys, food, cheese, and water. Least favorite things: Rain. Loud Noises.", "Dutch Shepherd", "Male", null, "Jasper", null, null, null, null, "Dog", null },
                    { 17, 5, "#1 Handsy Boy. Favorite things: Wearing clothes and playing with the hose. Least favorite things: strangers, other dogs playing with his toys.", "Dachshund mix", "Male", null, "Levi", null, null, null, null, "Dog", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Pets",
                keyColumn: "PetId",
                keyValue: 17);
        }
    }
}
