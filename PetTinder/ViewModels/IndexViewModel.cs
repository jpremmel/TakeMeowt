using System.Collections.Generic;

namespace PetTinder.ViewModels
{
    public class IndexViewModel
    {
        public List<int> PetIds { get; set; }
        public List<bool> RightSwipes { get; set; }

        public IndexViewModel()
        {
            this.PetIds = new List<int> {};
            this.RightSwipes = new List<bool> {};
        }
    }
}