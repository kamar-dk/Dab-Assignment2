using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAB_Assignment2.Model;

namespace DAB_Assignment2
{

    public class FacilitysContext : DbContext
    {

        public DbSet<SiteRules> siteRules { get; set; }
        public DbSet<AvailableItems> AvailableItems { get; set; }
        public DbSet<Facilitys> Facilitys { get; set; }

        public DbSet<CityHallPersonel> cityHallPersonels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Bookings> Bookings { get; set; }

        public string DbPath { get; }

        public FacilitysContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "Facilitys.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source ={DbPath}");
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Facilitys>()
                .HasOne(f => f.SiteRules)
                .WithOne(r => r.Facilitys)
                .HasForeignKey<SiteRules>();

            mb.Entity<Facilitys>()
                .HasOne(f => f.AvailableItems)
                .WithOne(a => a.Facilitys)
                .HasForeignKey<AvailableItems>();
        }
    }

    

    

    

    
}
