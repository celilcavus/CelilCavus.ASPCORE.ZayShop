using celilcavus.models;
using Microsoft.EntityFrameworkCore;

namespace celilcavus.Context
{
    public class ZayContext : DbContext
    {
        public DbSet<About> Abouts { get; set; }
        public DbSet<Brands> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<SocialAcounts> SocialAcounts { get; set; }

    }
}