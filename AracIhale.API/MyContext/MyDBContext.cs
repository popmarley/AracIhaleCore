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

        public DbSet<Kullanici> Kullanici { get; set;}
        public DbSet<Araclar> Araclar { get; set;}
        public DbSet<AracOzellik> AracOzellik { get; set;}
        public DbSet<Rol> Rol { get; set;}
        public DbSet<BireyselAracTeklif> BireyselAracTeklif { get; set;}
        public DbSet<AracModel> AracModels { get; set;}
        public DbSet<AracMarka> AracMarkas { get; set;}  
       


    }
}
