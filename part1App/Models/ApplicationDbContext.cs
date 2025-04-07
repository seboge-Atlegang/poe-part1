﻿using Microsoft.EntityFrameworkCore;
namespace part1App.Models
{
    public class ApplicationDbContext : DbContext
    {
        

        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<Venue> Venue { get; set; }
        public DbSet<Event> Event { get; set; }
        public DbSet<Booking> Booking { get; set; }
       
    }
}
