using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Booking_Bus_Ticket.Models.Users
{
    public class ApplicationUser: IdentityUser
    {
        [Required]
        [StringLength(100)]
        public string? Name { get; set; }
        [Required]
        [StringLength(100)]
        public string? Surname { get; set; }
        public string? Address { get; set; }
    }
}
