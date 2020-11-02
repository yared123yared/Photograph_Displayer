
using Microsoft.EntityFrameworkCore;
using Model;

namespace Data

{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Photographer> Photographer { get; set; }
        public DbSet<Photos> Photos { get; set; }
        public DbSet<LoggedInPhotographer> LoggedInPhotographer { get; set; }





        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Photographer>().HasKey(x => new
            {
                x.PhotographerId


            });

            modelBuilder.Entity<Photographer>().HasIndex(u => u.Email).IsUnique();





            modelBuilder.Entity<LoggedInPhotographer>().HasKey(x => x.Id);
            // modelBuilder.Entity<Photos>().HasIndex(u => u.PhotosName).IsUnique();
            modelBuilder.Entity<Photos>().HasKey(x => x.PhotosId);

        }
    }

}