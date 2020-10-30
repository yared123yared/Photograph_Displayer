
using Microsoft.EntityFrameworkCore;
using Model;

namespace Data

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Photographer> Photographer { get; set; }
        public DbSet<Photos> Photos { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {






            modelBuilder.Entity<Photographer>().HasKey(x => x.PhotographerId);
            modelBuilder.Entity<Photos>().HasKey(x => x.PhotosId);


        }
    }

}