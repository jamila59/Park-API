using Microsoft.EntityFrameworkCore;

namespace Park.Models
{
    public class ParkContext : DbContext
    {
        public ParkContext(DbContextOptions<ParkContext> options)
            : base(options)
        {
        }

        public DbSet<PublicPark> PublicParks { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
    {
    builder.Entity<PublicPark>()
        .HasData(
            new PublicPark { PublicParkId = 1, Name = "Acadia", City = "Bar Harbor", State = "Maine"},
            new PublicPark { PublicParkId = 2, Name = "Arches", City = "Moab", State =  "Utah"},
            new PublicPark { PublicParkId = 3, Name = "Badlands", City = "Rapid City", State = "Soulth Dakoda"},
            new PublicPark { PublicParkId = 4, Name = "Big Bend", City = "Alpine", State = "Texas" },
            new PublicPark { PublicParkId = 5, Name = "Crater Lake", City = "Klamath Falls", State = "Oregon"},
            new PublicPark { PublicParkId = 6, Name = "Death Valley", City = "Lone Pine", State = "Nevada"},
            new PublicPark { PublicParkId = 7, Name = "Denali", City = "Healy", State = "Alaska"},
            new PublicPark { PublicParkId = 8, Name = "Grand Canyon", City = "Coconino", State = "Arizona"},
            new PublicPark { PublicParkId = 9, Name = "Mesa Verde", City = "Montezuma", State = "Colorado"},
            new PublicPark { PublicParkId = 10, Name = "Mount Rainier", City = "Tacoma", State = "Washington"}


        );
        }
    }
}