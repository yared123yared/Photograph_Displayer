
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



            modelBuilder.Entity<Photos>().HasKey(x => new
            {
                x.PhotographerEmail,
                x.PhotosId

            });
            modelBuilder.Entity<Photographer>().HasKey(x => new
            {
                x.PhotographerId,
                x.Email
            });





        }
    }

}