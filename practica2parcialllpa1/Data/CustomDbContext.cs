using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using practica2parcialllpa1.Data.Entities;

namespace practica2parcialllpa1.Data
{
    public class CustomDbContext : DbContext
    {

        public DbSet<Pochoclo> Pochoclos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }


        public CustomDbContext() : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}