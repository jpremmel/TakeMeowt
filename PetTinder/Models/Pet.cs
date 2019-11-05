using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;

namespace PetTinder.Models
{
    public class Pet
    {
        public int PetId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Species { get; set; }
        public string Breed { get; set; }
        public string Bio { get; set; }
        public string LookingFor { get; set; }
        public string Photo1 { get; set; }
        public string Photo2 { get; set; }
        public string Photo3 { get; set; }
        public string Photo4 { get; set; }
        // public ICollection<Pet> Interested { get; }
        // public ICollection<Match> Matches { get; }
        public virtual ApplicationUser User { get; set; }

        // public Pet()
        // {
        //     this.Interested = new HashSet<Pet>();
        // }


    }
}