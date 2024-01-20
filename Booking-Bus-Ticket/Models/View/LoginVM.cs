using System.ComponentModel.DataAnnotations;

namespace Booking_Bus_Ticket.Models.View
{
    public class LoginVM
    {
        [Required(ErrorMessage = "Username is Required")]
        public string? Username { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        public bool RememberMe { get; set; }
    }
}
