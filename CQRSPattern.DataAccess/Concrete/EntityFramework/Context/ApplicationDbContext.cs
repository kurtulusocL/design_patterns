using CQRSPattern.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRSPattern.DataAccess.Concrete.EntityFramework.Context
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=cqrsPattern;user Id=sa;Password=123");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Product> Products{ get; set; }
    }
}
