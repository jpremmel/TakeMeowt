using Microsoft.AspNetCore.Mvc;
using PetTinder.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Http;
using System.Drawing;
using System;

namespace PetTinder.Controllers
{
    [Authorize]
    public class PetsController : Controller
    {
        private readonly PetTinderContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHostingEnvironment _hostingEnvironment;

        public PetsController(UserManager<ApplicationUser> userManager, PetTinderContext db, IHostingEnvironment environment)
        {
            _userManager = userManager;
            _db = db;
            _hostingEnvironment = environment;
        }

        public ActionResult Index()
        {
            var allPets = _db.Pets.ToList();
            return View(allPets);        
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Create(Pet pet)
        {
            //Find the current user's id and set it to the UserId property of the pet that was just created
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            pet.User = currentUser;

            //Create photo directory in "uploads" folder for the pet that was just created
            var photoDirectory = Path.Combine(_hostingEnvironment.WebRootPath, "uploads", $"{pet.Name.ToLower()}{pet.PetId}");
            Directory.CreateDirectory(photoDirectory);

            _db.Pets.Add(pet);
            _db.SaveChanges();
            return RedirectToAction("Details", new { id = pet.PetId });
        }


        //GET PHOTO
        [HttpGet("{id}/photo")] 
        public IActionResult Details(int id, int photo)
        {
            Pet pet = _db.Pets.FirstOrDefault(entry => entry.PetId == id);
            string path = "";
            if (photo == 1)
            {
                path = pet.Photo1;
            }
            else if (photo == 2)
            {
                path = pet.Photo2;
            }
            else if (photo == 3)
            {
                path = pet.Photo3;
            }
            else if (photo == 4)
            {
                path = pet.Photo4;
            }
            FileStream stream = System.IO.File.Open(@path, System.IO.FileMode.Open);
            var Photo = File(stream, "image/jpg");
            return RedirectToAction("Index", new { photo = photo });
        }

        //UPLOAD PHOTO
        [HttpPost("{id}/upload")]
        public async Task<IActionResult> Upload([FromForm] IFormFile file, int id)
        {
            System.Console.WriteLine(">>>>>>   UPLOAD TRIGGERED   <<<<<<");
            string result;
            Pet pet = _db.Pets.FirstOrDefault(entry => entry.PetId == id);
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads", $"{pet.Name.ToLower()}{pet.PetId}");  //directory: wwwroot/uploads/{petname}{petid}
            var guid = Guid.NewGuid().ToString(); //create GUID to append to file name to make sure file names of uploaded photos don't clash
            string photoPath = $"wwwroot/uploads/{pet.Name.ToLower()}{pet.PetId}/{guid}{file.FileName}";
            if (pet.Photo1 == null)
            {
                pet.Photo1 = photoPath;
                result = "Photo 1 uploaded.";
            }
            else if (pet.Photo2 == null)
            {
                pet.Photo2 = photoPath;
                result = "Photo 2 uploaded.";
            }
            else if (pet.Photo3 == null)
            {
                pet.Photo3 = photoPath;
                result = "Photo 3 uploaded.";
            }
            else if (pet.Photo4 == null)
            {
                pet.Photo4 = photoPath;
                result = "Photo 4 uploaded.";
            }
            else
            {
                result = "Too many photos!";
            }
            _db.Entry(pet).State = EntityState.Modified;
            _db.SaveChanges();
            if(file.Length > 0)
            {
                using(var fileStream = new FileStream(Path.Combine(uploads, $"{guid}{file.FileName}"), FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            }
            return RedirectToAction("Details", new { id = pet.PetId });
        }

    }
}