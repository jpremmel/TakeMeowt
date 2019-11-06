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
            //Find the currently logged in user and save it to the newly created pet's "User" property
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            pet.User = currentUser;

            //Create photo directory in "uploads" folder for the pet that was just created
            var photoDirectory = Path.Combine(_hostingEnvironment.WebRootPath, "uploads", $"{pet.Name.ToLower()}{pet.PetId}");
            Directory.CreateDirectory(photoDirectory);

            _db.Pets.Add(pet);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit()
        {
            //Find pet that belongs to the currently logged in user and pass it to the Edit view
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            var pet = _db.Pets.FirstOrDefault(p => p.User.Id == currentUser.Id);
            return View(pet);
        }

        [HttpPost]
        public ActionResult Edit(Pet pet)
        {
            _db.Entry(pet).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Details");
        }

        public async Task<IActionResult> Details()
        {
            //Find pet that belongs to the currently logged in user and pass it to the Details view
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            Pet pet = _db.Pets.FirstOrDefault(p => p.User.Id == currentUser.Id);
            return View(pet);
        }

        //UPLOAD PHOTO
        [HttpPost("{id}/upload")]
        public async Task<IActionResult> Upload([FromForm] IFormFile file, int id)
        {
            //Find pet that belongs to the currently logged in user
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            Pet pet = _db.Pets.FirstOrDefault(p => p.User.Id == currentUser.Id);

            //Construct path string for where the photo will be saved: wwwroot/uploads/{petname}{petid}/
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads", $"{pet.Name.ToLower()}{pet.PetId}");
            //Create GUID and append it to file name to make sure file names of uploaded photos are unique
            var guid = Guid.NewGuid().ToString();
            string photoPath = $"wwwroot/uploads/{pet.Name.ToLower()}{pet.PetId}/{guid}{file.FileName}";
            //Save photo path string to pet's Photo1, Photo2, Photo3, or Photo4 property (whichever is null or empty)
            if (String.IsNullOrEmpty(pet.Photo1))
            {
                pet.Photo1 = photoPath;
            }
            else if (String.IsNullOrEmpty(pet.Photo2))
            {
                pet.Photo2 = photoPath;
            }
            else if (String.IsNullOrEmpty(pet.Photo3))
            {
                pet.Photo3 = photoPath;
            }
            else if (String.IsNullOrEmpty(pet.Photo4))
            {
                pet.Photo4 = photoPath;
            }
            _db.Entry(pet).State = EntityState.Modified;
            _db.SaveChanges();
            //Save file to local project uploads directory
            if(file.Length > 0)
            {
                using(var fileStream = new FileStream(Path.Combine(uploads, $"{guid}{file.FileName}"), FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            }
            return RedirectToAction("Details");
        }

    }
}