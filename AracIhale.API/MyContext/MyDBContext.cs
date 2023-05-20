using AracIhale.API.DTO;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AracIhale.API.MyContext
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {
        }

        public DbSet<IhaleListesi> IhaleListesi { get; set; }

        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Araclar> Araclar { get; set; }
        public DbSet<AracOzellik> AracOzellik { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<BireyselAracTeklif> BireyselAracTeklif { get; set; }
        public DbSet<AracModel> AracModels { get; set; }
        public DbSet<AracMarka> AracMarkas { get; set; }
        public DbSet<OnaylananTeklif> OnaylananTeklif { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IhaleListesi>()
                .HasOne(i => i.Araclar)
                .WithMany()
                .HasForeignKey(i => i.AracID);

            modelBuilder.Entity<BireyselAracTeklif>()
               .HasOne(t => t.IhaleListesi)
               .WithMany(i => i.BireyselAracTeklifs)
               .HasForeignKey(t => t.IhaleID);

            modelBuilder.Entity<OnaylananTeklif>()
                .HasOne(t => t.BireyselAracTeklif)
                .WithMany(o => o.OnaylananTeklifs)
                .HasForeignKey(t => t.TeklifID);

            modelBuilder.Entity<OnaylananTeklif>()
                .HasOne(t => t.IhaleListesi)
                .WithMany(o => o.OnaylananTeklifs)
                .HasForeignKey(t => t.IhaleID);

            modelBuilder.Entity<OnaylananTeklif>()
                .HasOne(t => t.Kullanici)
                .WithMany(o => o.OnaylananTeklifs)
                .HasForeignKey(t => t.KullaniciID);

          
        }

    }
}
