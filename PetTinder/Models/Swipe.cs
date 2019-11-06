using Microsoft.AspNetCore.Identity;

namespace PetTinder.Models
{
    public class Swipe
    {
        public int SwipeId { get; set; }
        public int SwiperId { get; set; } //me, the signed in user
        public int PetId { get; set; } //them, the pet that I am swiping left or right on
        public bool ISwipedRight { get; set; }
        public bool TheySwipedRight { get; set; }
    }
}