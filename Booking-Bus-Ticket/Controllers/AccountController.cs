using Booking_Bus_Ticket.Models.Users;
using Booking_Bus_Ticket.Models.View;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Bus_Ticket.Controllers
{
    public class AccountController : Controller
    {
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly UserManager<ApplicationUser> userManager;

        public AccountController(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager)
        {
            this.signInManager = signInManager;
            this.userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> LoginAsync(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                // login the user
                var respond = await signInManager.PasswordSignInAsync(model.Username!, model.Password!, model.RememberMe, false);

                if (respond.Succeeded)
                {
                    // redirect to home page
                }

                ModelState.AddModelError("", "Invalid Login Attempt");
                return View();
            }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAsync(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                ApplicationUser user = new()
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    Email = model.Email,
                    UserName = model.Email,
                    Address = model.Address,
                };

                var respond = await userManager.CreateAsync(user, model.Password);

                if ( respond.Succeeded)
                {
                    /*wait signInManager.SignInAsync(user, false);*/
                    return RedirectToAction("Index", "Home");
                    
                }

                foreach (var error in respond.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return View(model);
        }
        
    }
}
