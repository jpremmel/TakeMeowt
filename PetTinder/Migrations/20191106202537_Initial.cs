using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PetTinder.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Swipes",
                columns: table => new
                {
                    SwipeId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SwiperId = table.Column<int>(nullable: false),
                    PetId = table.Column<int>(nullable: false),
                    ISwipedRight = table.Column<bool>(nullable: false),
                    TheySwipedRight = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Swipes", x => x.SwipeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    PetId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Gender = table.Column<string>(nullable: true),
                    Species = table.Column<string>(nullable: true),
                    Breed = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true),
                    LookingFor = table.Column<string>(nullable: true),
                    Photo1 = table.Column<string>(nullable: true),
                    Photo2 = table.Column<string>(nullable: true),
                    Photo3 = table.Column<string>(nullable: true),
                    Photo4 = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.PetId);
                    table.ForeignKey(
                        name: "FK_Pets_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "PetId", "Age", "Bio", "Breed", "Gender", "LookingFor", "Name", "Photo1", "Photo2", "Photo3", "Photo4", "Species", "UserId" },
                values: new object[,]
                {
                    { 1, 6, "Grey, lanky, fluffy, distinct underbite. Favorite things: Chicken, tortellini, beach, snow, her toys, being cozy. Least favorite things: Grooming, vet visits, guitars, being cold, being alone.", "Shih-tzu mix", "Female", "A cuddle buddy who will never leave my side.", "Sylvie", "uploads/sylvie1/sylvie-jacqueline.jpg", "uploads/sylvie1/20190604_125610.jpg", "uploads/sylvie1/20170531_140539.jpg", "uploads/sylvie1/20170531_140534.jpg", "Dog", null },
                    { 17, 5, "#1 Handsy Boy. Favorite things: Wearing clothes and playing with the hose. Least favorite things: strangers, other dogs playing with his toys.", "Dachshund mix", "Male", "", "Levi", "uploads/levi17/levi-jason.jpg", "", "", "", "Dog", null },
                    { 16, 2, "Very sassy when restless but irresistably cute when sleepy. Favorite things: Paper bags, boxes, being gently stroked on the nose while falling asleep. Least favorite things: Sylvie.", "Mixed Breed Maine Coon", "Male", "A calm, stable partner to balance out my erratic tendencies. Someone who wants to play but only when I feel like it.", "Jasper", "uploads/jasper16/jasper-jacqueline.jpg", "uploads/jasper16/20190701_120005.jpg", "", "", "Cat", null },
                    { 15, 6, "Has an adorable moustache. Favorite things: sleeping. Least favorite things: screaming toddlers.", "Domestic short hair", "Male", "", "Ashford", "uploads/ashford15/ashford-anita.jpg", "uploads/ashford15/20191026_201344.jpg", "uploads/ashford15/20190809_114702.jpg", "", "Cat", null },
                    { 14, 3, "The best dog ever. Favorite things: hikes. Least favorite things: shower.", "Coonhound/Lab", "Female", "", "Kima", "uploads/kima14/kima-joel.jpg", "", "", "", "Dog", null },
                    { 13, 1, "Dangerous. Favorite things: Total domination, sleeping. Least favorite things: Being locked up.", "Unknown", "Male", "", "Stripes", "uploads/stripes13/stripes-carrie.jpg", "", "", "", "Cat", null },
                    { 12, 4, "Fluffy, talkative, will steal your cheese. Favorite things: Pets and butt scratches. Least favorite things: Thunder and Vacuums.", "Russian Blue Mix", "Female", "", "Mocha", "uploads/mocha12/mocha-erin.jpg", "", "", "", "Cat", null },
                    { 11, 3, "Very Curious, loves to get into trouble spots. Favorite things: Climbing Branches. Least favorite things: Fast Movement.", "Ball Python", "Female", "", "Uwa", "uploads/uwa11/uwa-erin.jpg", "", "", "", "Snake", null },
                    { 18, 2, "Too much excited. Big love. Likes to wear her work vest to feel important.", "Mut", "female", "durable play mate", "Luna", "uploads/luna18/20190731_094803.jpg", "uploads/luna18/IMG-20190830-WA0000.jpg", "uploads/luna18/Screenshot_20190709-093242_Snapchat.jpg", "", "Dog", null },
                    { 10, 2, "Ridiculously fluffy and adorable, and knows it. Favorite things: All squeeky toys. Least favorite things: Limes.", "Australian Shepherd", "Female", "A playmate with infinite energy.", "Molly", "uploads/molly10/molly-christine.jpg", "", "", "", "Dog", null },
                    { 8, 12, "A scary looking dog that is a true sweetheart. Favorite things: Jasper loves stuffed toys, food, cheese, and water. Least favorite things: Rain. Loud Noises.", "Dutch Shepherd", "Male", "", "Jasper", "uploads/jasper8/jasper-chris.jpg", "", "", "", "Dog", null },
                    { 7, 1, "Mau is friendly to a fault. Favorite things: Mau enjoys taking naps and climbing house plants. Least favorite things: Rain and being told what to do.", "Medium-hair Domestic Feline", "Female", "", "Mau", "uploads/mau7/mau-micah.jpg", "", "", "", "Cat", null },
                    { 6, 5, "A Scooby Doo kinda guy looking for his Nova. Favorite things: Itch, eat all the human food scraps, long walks in the neighborhood, tennis balls. Least favorite things: Boxes, rain, baths, anything outdoors (except snow).", "German Shepard 1st Generation German-American", "Male", "", "Roscoe", "uploads/roscoe6/roscoe-jen.jpg", "", "", "", "Dog", null },
                    { 5, 6, "A fine boi looking for his furrever girl. Favorite things: His blanket, chirping at birds and squirrels, snuggling on your lap, licking his butt. Least favorite things: The vacuum, being picked up, having his nails clipped.", "Short-hair Domestic Feline", "Male", "", "Winston", "uploads/winston5/winston-mike.jpg", "uploads/winston5/Image from iOS.jpg", "uploads/winston5/Image from iOS (2).jpg", "uploads/winston5/Image from iOS (1).jpg", "Cat", null },
                    { 4, 7, "Lovebug, Angel, Shy. Favorite things: Snuggles, Gravy, Treats, Feather. Least favorite things: Loud noises, Strangers, Sudden movements, Vacuum.", "Medium-hair Domestic Feline", "Male", "", "Toad", "uploads/toad4/toad-sofia.jpg", "uploads/toad4/IMG_20171219_183621.jpg", "uploads/toad4/IMG_20190727_151423.jpg", "uploads/toad4/IMG_20180205_214524_1.jpg", "Cat", null },
                    { 3, 5, "Floofy McCuddlebug, Diva. Favorite Things: naps, snacks, being the little spoon, screaming. Least Favorite Things: Toe touches, Watching his brother get affection, Being hungry", "Long-hair Domestic Feline", "Male", "", "Chunk", "uploads/chunk3/chunk-sofia.jpg", "", "", "", "Cat", null },
                    { 2, 7, "lazy bum. favorite things: yogurt, cheese, carrots, sleep. least favorite things: grooming, vet visits, raspberries (not the food), being alone.", "Shih-tzu", "Female", "", "Bridget", "uploads/bridget2/bridget-jason.jpg", "", "", "", "Dog", null },
                    { 9, 4, "Wren is a red heeler that loves to pick on other dogs. Favorite things: Wren loves chasing her favorite toy at the park, she loves belly rubs, and cheese. Least favorite things: Rain and being told what to do", "Australian Cattledog", "Female", "", "Wren", "uploads/wren9/wren-chris.jpg", "", "", "", "Dog", null },
                    { 19, 2, "Very sweet but loves murder. Watch your feet!", "Shorthair", "Female", "A murder pal and snuggles", "Patches", "uploads/patches19/Image from iOS (3).jpg", "", "", "", "Cat", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_UserId",
                table: "Pets",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "Swipes");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
