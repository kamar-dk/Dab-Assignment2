using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DAB_Assignment2
{

    public class FacilitysContext : DbContext
    {
        public DbSet<Facilitys> Facilitys { get; set; }
        public DbSet<SiteRules> siteRules { get; set; }
        public DbSet<AvailableItems> AvailableItems { get; set; }
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
    }
    
    public class SiteRules
    {
        [Key] public int RuleId { get; set; }
        public string ÅbenIld { get; set; }
        public string HøjtMusik { get; set; }
        public string Overnatning { get; set; }

        public Facilitys Facilitys { get; set; } // Navigational Proberty
        public string fk_FcName { get; set; } // Foreign key
        
    }
    
    public class Facilitys
    {
        [Key] public string PK_FcName { get; set; }
        public string ClosetAdress { get; set; }
        public string FcType { get; set; }
        public string CanBeBookedBy { get; set; }
        public string FacilityDecrtiption { get; set; }

        //public SiteRules SiteRules { get; set; } // Navigational Proberty
    }



    public class AvailableItems
    {
        [Key] public int AvItemId { get; set; }
        public string FcName { get; set; } // Foreign key
        public Facilitys Facilitys { get; set; } // navi prop
        public int EmpId { get; set; } // Foreign Key
        public CityHallPersonel CityHallPersonel { get; set; } // navi prop
        public string Stole { get; set; }
        public string Grill { get; set; }
        public string Projector { get; set; }
        public string Brænde { get; set; }
        public DateOnly LastMaintanice { get; set; }
        public DateOnly NextMaintanice { get; set; }
    }

    public class CityHallPersonel
    {
        [Key] public int EmpId { get; set; }
        public int BookingId { get; set; } // Foreign key
        public List<Bookings> bookings { get; set; } // navi prop
        public string EmpName { get; set; }
    }

    public class User
    {
        [Key] public string UserName { get; set; }
        public string UserEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string UserType { get; set; }
        public string CVR { get; set; }
    }

    public class Bookings
    {
        [Key] public int BookingId { get; set; }

        public string BookedBy { get; set; } // Foreign key
        public List<User> User { get; set; } // Navi prop

        public string BookedFcName { get; set; } // Foreign key
        //public List<Facilitys> Facilitys { get; set; } // Navi Prop

        public DateOnly BookedFrom { get; set; }
        public DateOnly BookedTo { get; set; }
        public string Note { get; set; }
    }






}
