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
        public DbSet<Araclar> Araclars { get; set;}
        public DbSet<AracOzellik> AracOzelliks { get; set;}
       


    }
}
