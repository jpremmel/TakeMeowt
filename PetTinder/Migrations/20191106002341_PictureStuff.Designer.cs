﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PetTinder.Models;

namespace PetTinder.Migrations
{
    [DbContext(typeof(PetTinderContext))]
    [Migration("20191106002341_PictureStuff")]
    partial class PictureStuff
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("PetTinder.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("PetTinder.Models.Pet", b =>
                {
                    b.Property<int>("PetId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Age");

                    b.Property<string>("Bio");

                    b.Property<string>("Breed");

                    b.Property<string>("Gender");

                    b.Property<string>("LookingFor");

                    b.Property<string>("Name");

                    b.Property<string>("Photo1");

                    b.Property<string>("Photo2");

                    b.Property<string>("Photo3");

                    b.Property<string>("Photo4");

                    b.Property<string>("Species");

                    b.Property<byte[]>("TestPhoto1");

                    b.Property<string>("UserId");

                    b.HasKey("PetId");

                    b.HasIndex("UserId");

                    b.ToTable("Pets");

                    b.HasData(
                        new
                        {
                            PetId = 1,
                            Age = 6,
                            Bio = "Grey, lanky, fluffy, distinct underbite. Favorite things: Chicken, tortellini, beach, snow, her toys, being cozy. Least favorite things: Grooming, vet visits, guitars, being cold, being alone.",
                            Breed = "Shih-tzu mix",
                            Gender = "Female",
                            Name = "Sylvie",
                            Species = "Dog"
                        },
                        new
                        {
                            PetId = 2,
                            Age = 7,
                            Bio = "lazy bum. favorite things: yogurt, cheese, carrots, sleep. least favorite things: grooming, vet visits, raspberries (not the food), being alone.",
                            Breed = "Shih-tzu",
                            Gender = "Female",
                            Name = "Bridget",
                            Species = "Dog"
                        },
                        new
                        {
                            PetId = 3,
                            Age = 5,
                            Bio = "Floofy McCuddlebug, Diva. Favorite Things: naps, snacks, being the little spoon, screaming. Least Favorite Things: Toe touches, Watching his brother get affection, Being hungry",
                            Breed = "Long-hair Domestic Feline",
                            Gender = "Male",
                            Name = "Chunk",
                            Species = "Cat"
                        },
                        new
                        {
                            PetId = 4,
                            Age = 7,
                            Bio = "Lovebug, Angel, Shy. Favorite things: Snuggles, Gravy, Treats, Feather. Least favorite things: Loud noises, Strangers, Sudden movements, Vacuum.",
                            Breed = "Medium-hair Domestic Feline",
                            Gender = "Male",
                            Name = "Toad",
                            Species = "Cat"
                        },
                        new
                        {
                            PetId = 5,
                            Age = 6,
                            Bio = "A fine boi looking for his furrever girl. Favorite things: His blanket, chirping at birds and squirrels, snuggling on your lap, licking his butt. Least favorite things: The vacuum, being picked up, having his nails clipped.",
                            Breed = "Short-hair Domestic Feline",
                            Gender = "Male",
                            Name = "Winston",
                            Species = "Cat"
                        },
                        new
                        {
                            PetId = 6,
                            Age = 5,
                            Bio = "A Scooby Doo kinda guy looking for his Nova. Favorite things: Itch, eat all the human food scraps, long walks in the neighborhood, tennis balls. Least favorite things: Boxes, rain, baths, anything outdoors (except snow).",
                            Breed = "German Shepard 1st Generation German-American",
                            Gender = "Male",
                            Name = "Roscoe",
                            Species = "Dog"
                        },
                        new
                        {
                            PetId = 7,
                            Age = 1,
                            Bio = "Mau is friendly to a fault. Favorite things: Mau enjoys taking naps and climbing house plants. Least favorite things: Rain and being told what to do.",
                            Breed = "Medium-hair Domestic Feline",
                            Gender = "Female",
                            Name = "Mau",
                            Species = "Cat"
                        },
                        new
                        {
                            PetId = 8,
                            Age = 12,
                            Bio = "A scary looking dog that is a true sweetheart. Favorite things: Jasper loves stuffed toys, food, cheese, and water. Least favorite things: Rain. Loud Noises.",
                            Breed = "Dutch Shepherd",
                            Gender = "Male",
                            Name = "Jasper",
                            Species = "Dog"
                        },
                        new
                        {
                            PetId = 9,
                            Age = 4,
                            Bio = "Wren is a red heeler that loves to pick on other dogs. Favorite things: Wren loves chasing her favorite toy at the park, she loves belly rubs, and cheese. Least favorite things: Rain and being told what to do",
                            Breed = "Australian Cattledog",
                            Gender = "Female",
                            Name = "Wren",
                            Species = "Dog"
                        },
                        new
                        {
                            PetId = 10,
                            Age = 2,
                            Bio = "Ridiculously fluffy and adorable, and knows it. Favorite things: All squeeky toys. Least favorite things: Limes.",
                            Breed = "Australian Shepherd",
                            Gender = "Female",
                            Name = "Molly",
                            Species = "Dog"
                        },
                        new
                        {
                            PetId = 11,
                            Age = 3,
                            Bio = "Very Curious, loves to get into trouble spots. Favorite things: Climbing Branches. Least favorite things: Fast Movement.",
                            Breed = "Ball Python",
                            Gender = "Female",
                            Name = "Uwa",
                            Species = "Snake"
                        },
                        new
                        {
                            PetId = 12,
                            Age = 4,
                            Bio = "Fluffy, talkative, will steal your cheese. Favorite things: Pets and butt scratches. Least favorite things: Thunder and Vacuums.",
                            Breed = "Russian Blue Mix",
                            Gender = "Female",
                            Name = "Mocha",
                            Species = "Cat"
                        },
                        new
                        {
                            PetId = 13,
                            Age = 1,
                            Bio = "Dangerous. Favorite things: Total domination, sleeping. Least favorite things: Being locked up.",
                            Breed = "Unknown",
                            Gender = "Male",
                            Name = "Stripes",
                            Species = "Cat"
                        },
                        new
                        {
                            PetId = 14,
                            Age = 3,
                            Bio = "The best dog ever. Favorite things: hikes. Least favorite things: shower.",
                            Breed = "Coonhound/Lab",
                            Gender = "Female",
                            Name = "Kima",
                            Species = "Dog"
                        },
                        new
                        {
                            PetId = 15,
                            Age = 6,
                            Bio = "Has an adorable moustache. Favorite things: sleeping. Least favorite things: screaming toddlers.",
                            Breed = "Domestic short hair",
                            Gender = "Male",
                            Name = "Ashford",
                            Species = "Cat"
                        },
                        new
                        {
                            PetId = 16,
                            Age = 2,
                            Bio = "Very sassy when restless but irresistably cute when sleepy. Favorite things: Paper bags, boxes, being gently stroked on the nose while falling asleep. Least favorite things: Sylvie.",
                            Breed = "Mixed Breed Maine Coon",
                            Gender = "Male",
                            Name = "Jasper",
                            Species = "Cat"
                        },
                        new
                        {
                            PetId = 17,
                            Age = 5,
                            Bio = "#1 Handsy Boy. Favorite things: Wearing clothes and playing with the hose. Least favorite things: strangers, other dogs playing with his toys.",
                            Breed = "Dachshund mix",
                            Gender = "Male",
                            Name = "Levi",
                            Species = "Dog"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("PetTinder.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("PetTinder.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("PetTinder.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("PetTinder.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("PetTinder.Models.Pet", b =>
                {
                    b.HasOne("PetTinder.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}
