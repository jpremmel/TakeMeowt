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
            this.Pets = new List<Pet> {};
            this.RightSwipes = new List<bool> {};
        }
    }
}