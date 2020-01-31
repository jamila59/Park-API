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
    }
}