using CloudinaryDotNet;
using CourseProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Controllers
{
    [Authorize]
    public class CollectionsController : Controller
    {
        Account account = new Account("eternalq", "656832557845289", "gSxFRaWStjUL-J_U6dS2klLeYt4");

        private readonly ILogger<CollectionsController> _logger;
        private readonly AppDbContext db;

        public CollectionsController(ILogger<CollectionsController> logger, AppDbContext db)
        {
            _logger = logger;
            this.db = db;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Account()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCollection()
        {
            Cloudinary cloudinary = new Cloudinary(account);
            
            return RedirectToAction("Account");
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
