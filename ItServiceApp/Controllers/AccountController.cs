using ItServiceApp.Models.Entities.Identity;
using ItServiceApp.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItServiceApp.Controllers
{
    public class AccountController:Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AccountController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [AllowAnonymous]

        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Password = string.Empty;
                model.ConfirmPassword = string.Empty;
                return View(model);
            }

                var user = await _userManager.FindByIdAsync(model.UserName);
                if (user != null)
                {
                    ModelState.AddModelError(nameof(model.UserName), "Bu kullanıcı adı daha önce sisteme kayıt edilmiştir");
                    return View(model);

                }
            

               user= await _userManager.FindByIdAsync(model.Email);
                if (user != null)
                {
                    ModelState.AddModelError(nameof(model.Email), "Bu email adı daha önce sisteme kayıt edilmiştir");
                    return View(model);
                }
                user = new ApplicationUser()
                {
                    UserName = model.UserName,
                    Email=model.Email,
                    Name=model.Name,
                    SurName=model.Surname
                };

                var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {

            }
            else
            {
                ModelState.AddModelError(string.Empty, "Kayıt işleminde hata oluştu");
                return View(model);
            }


            return View(model);
                
        }
    }
}
