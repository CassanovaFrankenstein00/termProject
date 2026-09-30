
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace termProjectPhotoApp.Models
{
    public class PhotoContext : DbContext
    {
        public PhotoContext(DbContextOptions<PhotoContext> options) : base(options) { }
        public DbSet<Photos> Gallery {  get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Photos>().HasData(
                new Photos {
                    ID = 1,
                    Title = "GOAT",
                    Description = "Mountain Goat",
                    Credit = "Andrew Camp",
                    ImageUrl = "/images/goat.jpg"
                },
                new Photos
                {
                    ID = 2,
                    Title = "Continental Divide",
                    Description = "Mountain",
                    Credit = "Andrew Camp",
                    ImageUrl = "/images/mountain.jpg"
                },
                new Photos{
                    ID = 3,
                    Title = "Mesa",
                    Description = "Mesa in front of mountain",
                    Credit = "Andrew Camp",
                    ImageUrl = "/images/mesaMountain.jpg"
                });
        }
    }
}
