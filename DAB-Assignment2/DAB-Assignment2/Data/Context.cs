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
        public DbSet<User> Users { get; set; } = default;
        public DbSet<Bookings> Bookings { get; set; } = default;
        public DbSet<Attendee> Attendees { get; set; } = default!;
        public DbSet<Maintenance> Maintenance { get; set; } = default!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = localhost; Initial Catalog = Assignment2_3_AU682545; Persist Security Info = True; User ID = sa; Password = Kckm31920");           
        }

        protected override void OnModelCreating(ModelBuilder mb)
        {

        }
    }








}
