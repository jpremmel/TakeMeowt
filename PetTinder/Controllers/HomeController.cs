using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PetTinder.Models;
using PetTinder.ViewModels;

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

        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel();
            model.Pets = _db.Pets.ToList();
            return View(model);  
        }
    }
}
