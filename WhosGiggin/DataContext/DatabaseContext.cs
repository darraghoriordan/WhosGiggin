using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WhosGiggin.Models;

namespace WhosGiggin.DataContext
{
    public class DatabaseContext : DbContext
    {
         public DatabaseContext()
            : base("PrimaryConnection")
        {
        }
        public DbSet<EventModel> Events { get; set; }
        public DbSet<VenueModel> Venues { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<VenueModel> VenueModels { get; set; }

        public DbSet<EventModel> EventModels { get; set; }
    }
}