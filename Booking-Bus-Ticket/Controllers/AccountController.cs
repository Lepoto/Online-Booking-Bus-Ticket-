using Microsoft.AspNetCore.Mvc;

namespace Booking_Bus_Ticket.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
