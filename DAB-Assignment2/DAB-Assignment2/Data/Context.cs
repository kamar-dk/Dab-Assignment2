using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using DAB_Assignment2.Model;

namespace DAB_Assignment2.Data
{
    public class Context : DbContext
    {
        public DbSet<Facilitys> Facilitys { get; set; } = default;

        public DbSet<CityHallPersonel> cityHallPersonels { get; set; } = default;
        public DbSet<User> Users { get; set; } = default;
        public DbSet<Bookings> Bookings { get; set; } = default;

        

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.js", false);
            IConfiguration config = builder.Build();
            string ConnectionString = config.GetConnectionString("ConnString");
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {

        }
    }








}
