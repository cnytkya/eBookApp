using eBookApp.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace eBookApp.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Programming", OrderNo = 1 },
                new Category { Id = 2, Name = "Databases", OrderNo = 2 },
                new Category { Id = 3, Name = "Networking", OrderNo = 3 },
                new Category { Id = 4, Name = "Security", OrderNo = 4 },
                new Category { Id = 5, Name = "Web Development", OrderNo = 5 }
            );
        }
    }
}