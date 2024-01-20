namespace Booking_Bus_Ticket.Models.Main
{
    public class TripSchedule
    {
        public string? Pickup { get; set; }
        public string? DropOff { get; set;}
        public string? Notes { get; set; }
        public string? DepartureTime { get; set; }
        public string? TripType { get; set; }
        public string? Status { get; set; }

        public int PassengersCount { get; set; }
        public int Distance { get; set; }
        public string? Created { get; set; }
    }
}
