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

    }
}
