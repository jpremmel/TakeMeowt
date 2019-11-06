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
        public async Task<ActionResult> Create(Pet pet, IFormFile file1, IFormFile file2, IFormFile file3, IFormFile file4)
        {
            //Find the currently logged in user and save it to the newly created pet's "User" property
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var currentUser = await _userManager.FindByIdAsync(userId);
            pet.User = currentUser;

            //Create photo directory in "uploads" folder for the pet that was just created
            var photoDirectory = Path.Combine(_hostingEnvironment.WebRootPath, "uploads", $"{pet.Name.ToLower()}{pet.PetId}");
            Directory.CreateDirectory(photoDirectory);

            //Construct path string for where the photo will be saved: wwwroot/uploads/{petname}{petid}/
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads", $"{pet.Name.ToLower()}{pet.PetId}");

            if (file1 != null)
            {
                var guid1 = Guid.NewGuid().ToString();
                string photoPath1 = $"wwwroot/uploads/{pet.Name.ToLower()}{pet.PetId}/{guid1}{file1.FileName}";
                if (String.IsNullOrEmpty(pet.Photo1))
                {
                    pet.Photo1 = photoPath1;
                }
                _db.Entry(pet).State = EntityState.Modified;
                _db.SaveChanges();
                if(file1.Length > 0)
                {
                    using(var fileStream = new FileStream(Path.Combine(uploads, $"{guid}{file1.FileName}"), FileMode.Create))
                    {
                        await file1.CopyToAsync(fileStream);
                    }
                }
            }
            if (file2 != null)
            {
                var guid2 = Guid.NewGuid().ToString();
                string photoPath2 = $"wwwroot/uploads/{pet.Name.ToLower()}{pet.PetId}/{guid2}{file2.FileName}";
                if (String.IsNullOrEmpty(pet.Photo2))
                {
                    pet.Photo2 = photoPath2;
                }
                _db.Entry(pet).State = EntityState.Modified;
                _db.SaveChanges();
                if(file2.Length > 0)
                {
                    using(var fileStream = new FileStream(Path.Combine(uploads, $"{guid}{file2.FileName}"), FileMode.Create))
                    {
                        await file2.CopyToAsync(fileStream);
                    }
                }
            }
            if (file3 != null)
            {
                var guid3 = Guid.NewGuid().ToString();
                string photoPath3 = $"wwwroot/uploads/{pet.Name.ToLower()}{pet.PetId}/{guid3}{file3.FileName}";
                if (String.IsNullOrEmpty(pet.Photo3))
                {
                    pet.Photo3 = photoPath3;
                }
                _db.Entry(pet).State = EntityState.Modified;
                _db.SaveChanges();
                if(file3.Length > 0)
                {
                    using(var fileStream = new FileStream(Path.Combine(uploads, $"{guid}{file3.FileName}"), FileMode.Create))
                    {
                        await file3.CopyToAsync(fileStream);
                    }
                }
            }
            if (file4 != null)
            {
                var guid4 = Guid.NewGuid().ToString();
                string photoPath4 = $"wwwroot/uploads/{pet.Name.ToLower()}{pet.PetId}/{guid4}{file4.FileName}";
                if (String.IsNullOrEmpty(pet.Photo4))
                {
                    pet.Photo4 = photoPath4;
                }
                _db.Entry(pet).State = EntityState.Modified;
                _db.SaveChanges();
                if(file4.Length > 0)
                {
                    using(var fileStream = new FileStream(Path.Combine(uploads, $"{guid}{file4.FileName}"), FileMode.Create))
                    {
                        await file4.CopyToAsync(fileStream);
                    }
                }
            }

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
        public async Task<IActionResult> Edit(Pet pet, IFormFile file1, IFormFile file2, IFormFile file3, IFormFile file4)
        {
            //Construct path string for where the photo will be saved: wwwroot/uploads/{petname}{petid}/
            var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads", $"{pet.Name.ToLower()}{pet.PetId}");

            if (file1 != null)
            {
                var guid1 = Guid.NewGuid().ToString();
                string photoPath1 = $"wwwroot/uploads/{pet.Name.ToLower()}{pet.PetId}/{guid1}{file1.FileName}";
                if (String.IsNullOrEmpty(pet.Photo1))
                {
                    pet.Photo1 = photoPath1;
                }
                _db.Entry(pet).State = EntityState.Modified;
                _db.SaveChanges();
                if(file1.Length > 0)
                {
                    using(var fileStream = new FileStream(Path.Combine(uploads, $"{guid}{file1.FileName}"), FileMode.Create))
                    {
                        await file1.CopyToAsync(fileStream);
                    }
                }
            }
            if (file2 != null)
            {
                var guid2 = Guid.NewGuid().ToString();
                string photoPath2 = $"wwwroot/uploads/{pet.Name.ToLower()}{pet.PetId}/{guid2}{file2.FileName}";
                if (String.IsNullOrEmpty(pet.Photo2))
                {
                    pet.Photo2 = photoPath2;
                }
                _db.Entry(pet).State = EntityState.Modified;
                _db.SaveChanges();
                if(file2.Length > 0)
                {
                    using(var fileStream = new FileStream(Path.Combine(uploads, $"{guid}{file2.FileName}"), FileMode.Create))
                    {
                        await file2.CopyToAsync(fileStream);
                    }
                }
            }
            if (file3 != null)
            {
                var guid3 = Guid.NewGuid().ToString();
                string photoPath3 = $"wwwroot/uploads/{pet.Name.ToLower()}{pet.PetId}/{guid3}{file3.FileName}";
                if (String.IsNullOrEmpty(pet.Photo3))
                {
                    pet.Photo3 = photoPath3;
                }
                _db.Entry(pet).State = EntityState.Modified;
                _db.SaveChanges();
                if(file3.Length > 0)
                {
                    using(var fileStream = new FileStream(Path.Combine(uploads, $"{guid}{file3.FileName}"), FileMode.Create))
                    {
                        await file3.CopyToAsync(fileStream);
                    }
                }
            }
            if (file4 != null)
            {
                var guid4 = Guid.NewGuid().ToString();
                string photoPath4 = $"wwwroot/uploads/{pet.Name.ToLower()}{pet.PetId}/{guid4}{file4.FileName}";
                if (String.IsNullOrEmpty(pet.Photo4))
                {
                    pet.Photo4 = photoPath4;
                }
                _db.Entry(pet).State = EntityState.Modified;
                _db.SaveChanges();
                if(file4.Length > 0)
                {
                    using(var fileStream = new FileStream(Path.Combine(uploads, $"{guid}{file4.FileName}"), FileMode.Create))
                    {
                        await file4.CopyToAsync(fileStream);
                    }
                }
            }            
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

        // //UPLOAD PHOTO
        // [HttpPost]
        // public async Task<IActionResult> Upload([FromForm] IFormFile file1, IFormFile file2, IFormFile file3, IFormFile file4)
        // {
        //     //Find pet that belongs to the currently logged in user
        //     var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        //     var currentUser = await _userManager.FindByIdAsync(userId);
        //     Pet pet = _db.Pets.FirstOrDefault(p => p.User.Id == currentUser.Id);

        //     //Construct path string for where the photo will be saved: wwwroot/uploads/{petname}{petid}/
        //     var uploads = Path.Combine(_hostingEnvironment.WebRootPath, "uploads", $"{pet.Name.ToLower()}{pet.PetId}");

        //     if (file1 != null)
        //     {
        //         var guid1 = Guid.NewGuid().ToString();
        //         string photoPath1 = $"wwwroot/uploads/{pet.Name.ToLower()}{pet.PetId}/{guid1}{file1.FileName}";
        //         if (String.IsNullOrEmpty(pet.Photo1))
        //         {
        //             pet.Photo1 = photoPath1;
        //         }
        //         _db.Entry(pet).State = EntityState.Modified;
        //         _db.SaveChanges();
        //         if(file1.Length > 0)
        //         {
        //             using(var fileStream = new FileStream(Path.Combine(uploads, $"{guid}{file1.FileName}"), FileMode.Create))
        //             {
        //                 await file1.CopyToAsync(fileStream);
        //             }
        //         }
        //     }
        //     if (file2 != null)
        //     {
        //         var guid2 = Guid.NewGuid().ToString();
        //         string photoPath2 = $"wwwroot/uploads/{pet.Name.ToLower()}{pet.PetId}/{guid2}{file2.FileName}";
        //         if (String.IsNullOrEmpty(pet.Photo2))
        //         {
        //             pet.Photo2 = photoPath2;
        //         }
        //         _db.Entry(pet).State = EntityState.Modified;
        //         _db.SaveChanges();
        //         if(file2.Length > 0)
        //         {
        //             using(var fileStream = new FileStream(Path.Combine(uploads, $"{guid}{file2.FileName}"), FileMode.Create))
        //             {
        //                 await file2.CopyToAsync(fileStream);
        //             }
        //         }
        //     }
        //     if (file3 != null)
        //     {
        //         var guid3 = Guid.NewGuid().ToString();
        //         string photoPath3 = $"wwwroot/uploads/{pet.Name.ToLower()}{pet.PetId}/{guid3}{file3.FileName}";
        //         if (String.IsNullOrEmpty(pet.Photo3))
        //         {
        //             pet.Photo3 = photoPath3;
        //         }
        //         _db.Entry(pet).State = EntityState.Modified;
        //         _db.SaveChanges();
        //         if(file3.Length > 0)
        //         {
        //             using(var fileStream = new FileStream(Path.Combine(uploads, $"{guid}{file3.FileName}"), FileMode.Create))
        //             {
        //                 await file3.CopyToAsync(fileStream);
        //             }
        //         }
        //     }
        //     if (file4 != null)
        //     {
        //         var guid4 = Guid.NewGuid().ToString();
        //         string photoPath4 = $"wwwroot/uploads/{pet.Name.ToLower()}{pet.PetId}/{guid4}{file4.FileName}";
        //         if (String.IsNullOrEmpty(pet.Photo4))
        //         {
        //             pet.Photo4 = photoPath4;
        //         }
        //         _db.Entry(pet).State = EntityState.Modified;
        //         _db.SaveChanges();
        //         if(file4.Length > 0)
        //         {
        //             using(var fileStream = new FileStream(Path.Combine(uploads, $"{guid}{file4.FileName}"), FileMode.Create))
        //             {
        //                 await file4.CopyToAsync(fileStream);
        //             }
        //         }
        //     }            
        //     return RedirectToAction("Details");
        // }

        //UPLOAD PHOTO
        [HttpPost("{id}/upload")]
        public async Task<IActionResult> Upload([FromForm] IFormFile file)
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
            if (file.Length > 0)
            {
                using (var fileStream = new FileStream(Path.Combine(uploads, $"{guid}{file.FileName}"), FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
            }
            return RedirectToAction("Details");
        }

    }
}