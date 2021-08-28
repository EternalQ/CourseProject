using CourseProject.Models;
using CourseProject.Models.Entities;
using CourseProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CourseProject.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IUser> userManager;
        private readonly SignInManager<IUser> signInManager;

        public AccountController(UserManager<IUser> userManager, SignInManager<IUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [Authorize]
        [Route("/Account/AccManager")]
        public IActionResult AccountManager()
        {
            return View();
        }

        #region Sign in/out
        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Signup(SignupViewModel model)
        {
            if (ModelState.IsValid)
            {
                IUser user = new IUser() { Email = model.Email, UserName = model.Email };
                var result = await userManager.CreateAsync(user, model.PasswordConfirm);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Collections");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Signin(string returnUrl = null)
        {
            return View(new SigninViewModel { ReturnUrl = returnUrl });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Signin(SigninViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, false);
                if (result.Succeeded)
                {
                    if (!string.IsNullOrEmpty(model.ReturnUrl) && Url.IsLocalUrl(model.ReturnUrl))
                    {
                        return Redirect(model.ReturnUrl);
                    }
                    else
                    {
                        return RedirectToAction("Index", "Collections");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Wrong email or password");
                }
            }
            return View(model);
        }
        #endregion

        [Authorize]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Collections");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }

        #region ExternalAuth
        public IActionResult GoogleLogin()
        {
            string redirectUrl = Url.Action("ExternalLoginResponse", "Account");
            var properties = signInManager.ConfigureExternalAuthenticationProperties("Google", redirectUrl);
            return new ChallengeResult("Google", properties);
        }

        public IActionResult TwitterLogin()
        {
            string redirectUrl = Url.Action("ExternalLoginResponse", "Account");
            var properties = signInManager.ConfigureExternalAuthenticationProperties("Twitter", redirectUrl);
            return new ChallengeResult("Twitter", properties);
        }

        public async Task<IActionResult> ExternalLoginResponse()
        {
            ExternalLoginInfo info = await signInManager.GetExternalLoginInfoAsync();
            if (info == null)
                return RedirectToAction("Signin");

            var result = await signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey, false);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Collections");
            }
            else
            {
                string email = info.Principal.FindFirstValue(ClaimTypes.Email);
                var user = await userManager.FindByEmailAsync(email);

                if (user == null)
                {
                    user = new IUser()
                    {
                        Email = email,
                        UserName = email
                    };
                    await userManager.CreateAsync(user);
                }

                var resultAddLogin = await userManager.AddLoginAsync(user, info);
                if (resultAddLogin.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Collections");
                }
                else
                    return Content("Error");
            }
        }
        #endregion
    }
}
