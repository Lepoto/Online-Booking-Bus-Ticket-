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
            if(ModelState.IsValid)
            {
                // login the user
                var respond = await signInManager.PasswordSignInAsync(model.Username!, model.Password!, model.RememberMe, false);

                if (respond.Succeeded)
                {
                    // redirect to home page
                }

                ModelState.AddModelError("","Invalid Login Attempt");
                return View();
            }
            return View(model);
        }
    }
}
