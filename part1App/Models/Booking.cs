namespace part1App.Models
{
    public class Booking
    {
        public int BookingId { get; set; }
        public DateTime BookingDate { get; set; }

        // Foreign Keys
        public int VenueId { get; set; }
        public int EventId { get; set; }

        // Navigation Properties
        public Venue Venue { get; set; }
        public Event Event { get; set; }
    }
}
