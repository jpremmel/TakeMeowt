using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PetTinder.Models;

namespace PetTinder.Controllers
{
    public class HomeController : Controller
    {
        private readonly PetTinderContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IHostingEnvironment _hostingEnvironment;

        public HomeController(UserManager<ApplicationUser> userManager, PetTinderContext db, IHostingEnvironment environment)
        {
            _userManager = userManager;
            _db = db;
            _hostingEnvironment = environment;
        }
        [Authorize]
        public IActionResult Index()
        {
            var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var allPets = _db.Pets.Where(p=>p.User.Id != userId).ToList();
            return View(allPets);        
        }
    }
}
