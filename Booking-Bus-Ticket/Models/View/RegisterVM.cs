﻿using System.ComponentModel.DataAnnotations;

namespace Booking_Bus_Ticket.Models.View
{
    public class RegisterVM
    {
        [Required]
        public string? Name { get; set; }

        public string? Surname { get; set; }
        public string? Address { get; set; }

        [Required]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Passwords don't match.")]
        [Display(Name = "Confirm Password")]
        public string? ConfirmPassword { get; set; }

    }
}
