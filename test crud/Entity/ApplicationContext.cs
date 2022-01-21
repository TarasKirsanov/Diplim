using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.SqlServer;
using test_crud.Models;

namespace test_crud.Entity
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> UsersTable { get; set; }
        public DbSet<Headphones> HeadphonesTable { get; set; }
        public DbSet<FavoriteItem> FavoriteItemsTable { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=ElectroMagDB;Trusted_Connection=True;");
        }

        //protected override void OnModelCreating(ModelBuilder builder) 
        //{
        //    builder.Entity<User>()
        //        .HasMany<FavoriteItem>(p => p.favoriteItems)
        //        .WithOne(p => p.User)
        //        .HasForeignKey(p => p.UserId);

        //    builder.Entity<FavoriteItem>()
        //        .HasOne<User>(p => p.User)
        //        .WithMany(p => p.favoriteItems)
        //        .HasForeignKey(p => p.UserId);
        //}

    }
}
