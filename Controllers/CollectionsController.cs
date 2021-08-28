﻿using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using CourseProject.Models;
using CourseProject.Models.Entities;
using CourseProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        private readonly UserManager<IUser> userMgr;
        private readonly Cloudinary cloudinary;

        public CollectionsController(ILogger<CollectionsController> logger, AppDbContext db, UserManager<IUser> userMgr)
        {
            _logger = logger;
            this.db = db;
            this.userMgr = userMgr;
            cloudinary = new Cloudinary(account);
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/Collections/ColManager")]
        public async Task<IActionResult> CollectionsManager()
        {
            IUser user = await userMgr.FindByNameAsync(User.Identity.Name);
            ViewBag.Collections = db.CustomCollections.Include(c => c.Items).Where(c=>c.UserId == user.Id).ToList();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCollection(AddCollectionViewModel model)
        {
            IUser user = await userMgr.FindByNameAsync(User.Identity.Name);

            if (ModelState.IsValid)
            {
                var uploadParams = new ImageUploadParams()
                {
                    File = new FileDescription($"{user.Id}-collection-{DateTime.Now.ToString("dd-MM-yyyy--HH-mm-ss")}", model.File.OpenReadStream()),
                    Transformation = new Transformation().Width(245).Height(154).Crop("fill2")
                };
                var uploadResult = await cloudinary.UploadAsync(uploadParams);

                CustomCollection collection = new CustomCollection()
                {
                    Name = model.Name,
                    Descrip = model.Description,
                    Subject = await db.Subjects.FirstOrDefaultAsync(s => s.Name == model.Subject),
                    ImageURL = uploadResult.Url.AbsoluteUri,
                    ImagePublicId = uploadResult.PublicId,

                    Check1_name = model.Check1_name,
                    Check2_name = model.Check2_name,
                    Check3_name = model.Check3_name,
                    Check1_visibility = model.Check1_visibility,
                    Check2_visibility = model.Check2_visibility,
                    Check3_visibility = model.Check3_visibility,
                    Date1_name = model.Date1_name,
                    Date2_name = model.Date2_name,
                    Date3_name = model.Date3_name,
                    Date1_visibility = model.Date1_visibility,
                    Date2_visibility = model.Date2_visibility,
                    Date3_visibility = model.Date3_visibility,
                    Num1_name = model.Num1_name,
                    Num2_name = model.Num2_name,
                    Num3_name = model.Num3_name,
                    Num1_visibility = model.Num1_visibility,
                    Num2_visibility = model.Num2_visibility,
                    Num3_visibility = model.Num3_visibility,
                    Str1_name = model.Str1_name,
                    Str2_name = model.Str2_name,
                    Str3_name = model.Str3_name,
                    Str1_visibility = model.Str1_visibility,
                    Str2_visibility = model.Str2_visibility,
                    Str3_visibility = model.Str3_visibility,
                    Txt1_name = model.Txt1_name,
                    Txt2_name = model.Txt2_name,
                    Txt3_name = model.Txt3_name,
                    Txt1_visibility = model.Txt1_visibility,
                    Txt2_visibility = model.Txt2_visibility,
                    Txt3_visibility = model.Txt3_visibility,
                };

                user.Collections.Add(collection);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
                ModelState.AddModelError("", "Smth went wrong");
                return View("CollectionsManager", model);
        }

        public async Task<IActionResult> DeleteCollection(string id)
        {
            var user = await userMgr.FindByNameAsync(User.Identity.Name);
            var collection = await db.CustomCollections.FirstOrDefaultAsync(c => c.Id == id);
            if (user.Id != collection.UserId)
            {
                return RedirectToAction("AccessDenied", "Account");
            }

            db.CustomCollections.Remove(collection);
            await db.SaveChangesAsync();
            await cloudinary.DeleteResourcesAsync(collection.ImagePublicId);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> EditItems(string id)
        {
            var user = await userMgr.FindByNameAsync(User.Identity.Name);
            var collection = await db.CustomCollections.FirstOrDefaultAsync(c => c.Id == id);
            if(user.Id != collection.UserId)
            {
                return RedirectToAction("AccessDenied", "Account");
            }

            return View(collection);
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
