using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using YeniProje_OOP.Entity;

namespace YeniProje_OOP.ProjeContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = DESKTOP-3O965OJ\\SQLEXPRESS;database = DbNewOopCore;integrated security=true;");
        }
        public DbSet<Product>? Products { get; set; }
        public DbSet<Customer>? customers { get; set; }
        public DbSet<Category>? categories { get; set; }
    }
}
