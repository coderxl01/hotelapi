using HotelApi.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApi.DataAccess
{
    public class HotelDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-PNPOSI6;Database=HotelDb;User Id=sa;Password=1234;Encrypt=true;TrustServerCertificate=true;");
             
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Hotel>()
                .HasMany(h => h.workers)
                .WithOne(w => w.hotel)
                .IsRequired();

            modelBuilder.Entity<Adres>()
                .HasOne(a => a.hotel)
                .WithOne(h => h.adres)
                .HasForeignKey<Hotel>(b => b.adresId);


        }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<Worker> Worker { get; set; }
        public DbSet<Adres> Adres { get; set; }

    }
}
