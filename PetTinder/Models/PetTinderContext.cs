using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PetTinder.Models
{
    public class PetTinderContext : IdentityDbContext<ApplicationUser>
    {
        public PetTinderContext(DbContextOptions options) : base(options) {}

        public DbSet<Pet> Pets { get; set; }

        //SEED DATA
        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //     builder.Entity<Pet>()
        //         .HasData(
        //             new Pet { PetId = 1, Name = "Sylvie", Species = "Dog", Breed = "Shih-tzu mix", Age = 6, Gender = "Female", Bio = "Grey, lanky, fluffy, distinct underbite. Favorite things: Chicken, tortellini, beach, snow, her toys, being cozy. Least favorite things: Grooming, vet visits, guitars, being cold, being alone." },

        //             new Pet { PetId = 2, Name = "Bridget", Species = "Dog", Breed = "Shih-tzu", Age = 7, Gender = "Female", Bio = "lazy bum. favorite things: yogurt, cheese, carrots, sleep. least favorite things: grooming, vet visits, raspberries (not the food), being alone." },

        //             new Pet { PetId = 3, Name = "Chunk", Species = "Cat", Breed = "Long-hair Domestic Feline", Age = 5, Gender = "Male", Bio = "Floofy McCuddlebug, Diva. Favorite Things: naps, snacks, being the little spoon, screaming. Least Favorite Things: Toe touches, Watching his brother get affection, Being hungry" },

        //             new Pet { PetId = 4, Name = "Toad", Species = "Cat", Breed = "Medium-hair Domestic Feline", Age = 7, Gender = "Male", Bio = "Lovebug, Angel, Shy. Favorite things: Snuggles, Gravy, Treats, Feather. Least favorite things: Loud noises, Strangers, Sudden movements, Vacuum." },

        //             new Pet { PetId = 5, Name = "Winston", Species = "Cat", Breed = "Short-hair Domestic Feline", Age = 6, Gender = "Male", Bio = "A fine boi looking for his furrever girl. Favorite things: His blanket, chirping at birds and squirrels, snuggling on your lap, licking his butt. Least favorite things: The vacuum, being picked up, having his nails clipped." },

        //             new Pet { PetId = 6, Name = "Roscoe", Species = "Dog", Breed = "German Shepard 1st Generation German-American", Age = 5, Gender = "Male", Bio = "A Scooby Doo kinda guy looking for his Nova. Favorite things: Itch, eat all the human food scraps, long walks in the neighborhood, tennis balls. Least favorite things: Boxes, rain, baths, anything outdoors (except snow)." },

        //             new Pet { PetId = 7, Name = "Mau", Species = "Cat", Breed = "Medium-hair Domestic Feline", Age = 1, Gender = "Female", Bio = "Mau is friendly to a fault. Favorite things: Mau enjoys taking naps and climbing house plants. Least favorite things: Rain and being told what to do." },

        //             new Pet { PetId = 8, Name = "Jasper", Species = "Dog", Breed = "Dutch Shepherd", Age = 12, Gender = "Male", Bio = "A scary looking dog that is a true sweetheart. Favorite things: Jasper loves stuffed toys, food, cheese, and water. Least favorite things: Rain. Loud Noises." },

        //             new Pet { PetId = 9, Name = "Wren", Species = "Dog", Breed = "Australian Cattledog", Age = 4, Gender = "Female", Bio = "Wren is a red heeler that loves to pick on other dogs. Favorite things: Wren loves chasing her favorite toy at the park, she loves belly rubs, and cheese. Least favorite things: Rain and being told what to do" },

        //             new Pet { PetId = 10, Name = "Molly", Species = "Dog", Breed = "Australian Shepherd", Age = 2, Gender = "Female", Bio = "Ridiculously fluffy and adorable, and knows it. Favorite things: All squeeky toys. Least favorite things: Limes." },

        //             new Pet { PetId = 11, Name = "Uwa", Species = "Snake", Breed = "Ball Python", Age = 3, Gender = "Female", Bio = "Very Curious, loves to get into trouble spots. Favorite things: Climbing Branches. Least favorite things: Fast Movement." },

        //             new Pet { PetId = 12, Name = "Mocha", Species = "Cat", Breed = "Russian Blue Mix", Age = 4, Gender = "Female", Bio = "Fluffy, talkative, will steal your cheese. Favorite things: Pets and butt scratches. Least favorite things: Thunder and Vacuums." },

        //             new Pet { PetId = 13, Name = "Stripes", Species = "Cat", Breed = "Unknown", Age = 1, Gender = "Male", Bio = "Dangerous. Favorite things: Total domination, sleeping. Least favorite things: Being locked up." },

        //             new Pet { PetId = 14, Name = "Kima", Species = "Dog", Breed = "Coonhound/Lab", Age = 3, Gender = "Female", Bio = "The best dog ever. Favorite things: hikes. Least favorite things: shower." },

        //             new Pet { PetId = 15, Name = "Ashford", Species = "Cat", Breed = "Domestic short hair", Age = 6, Gender = "Male", Bio = "Has an adorable moustache. Favorite things: sleeping. Least favorite things: screaming toddlers." },

        //             new Pet { PetId = 16, Name = "Jasper", Species = "Cat", Breed = "Mixed Breed Maine Coon", Age = 2, Gender = "Male", Bio = "Very sassy when restless but irresistably cute when sleepy. Favorite things: Paper bags, boxes, being gently stroked on the nose while falling asleep. Least favorite things: Sylvie." },

        //             new Pet { PetId = 17, Name = "Levi", Species = "Dog", Breed = "Dachshund mix", Age = 5, Gender = "Male", Bio = "#1 Handsy Boy. Favorite things: Wearing clothes and playing with the hose. Least favorite things: strangers, other dogs playing with his toys." }
        //         );
        // }
    }
}