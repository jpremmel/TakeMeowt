using System.Collections.Generic;
using PetTinder.Models;

namespace PetTinder.ViewModels
{
    public class IndexViewModel
    {
        public List<Pet> Pets { get; set; }
        public List<bool> RightSwipes { get; set; }

        public IndexViewModel()
        {
            Pets = new List<Pet> { };
            RightSwipes = new List<bool> { };
        }
    }
}