using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Booking_Bus_Ticket.Models.Users;
using Booking_Bus_Ticket.Models.Main;

namespace Booking_Bus_Ticket.Data
{
    public class AppDbContext:IdentityDbContext<ApplicationUser>
    {
        public DbSet<Bus> Buses { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
