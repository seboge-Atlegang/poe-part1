﻿namespace part1App.Models
{
    public class Venue
    {
        public int VenueId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public string ImageUrl { get; set; }
        public ICollection<Booking> Bookings { get; set; }
    }
}
