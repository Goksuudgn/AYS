using AYS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AYS.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Device> Devices { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<DevicePhoto> DevicePhotos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fluent API kullanarak ilişkileri ve kuralları belirleyin
            modelBuilder.Entity<User>()
                .HasMany(u => u.Homes)
                .WithOne(h => h.User)
                .HasForeignKey(h => h.UserId);

            modelBuilder.Entity<Home>()
                .HasMany(h => h.Rooms)
                .WithOne(r => r.Home)
                .HasForeignKey(r => r.HomeId);

            modelBuilder.Entity<Room>()
                .HasMany(r => r.Devices)
                .WithOne(d => d.Room)
                .HasForeignKey(d => d.RoomId);

            modelBuilder.Entity<Category>()
                .HasMany(c => c.Devices)
                .WithOne(d => d.Category)
                .HasForeignKey(d => d.CategoryId);

            modelBuilder.Entity<Device>()
                .HasMany(d => d.DevicePhotos)
                .WithOne(dp => dp.Device)
                .HasForeignKey(dp => dp.DeviceId);
        }
    }
}
