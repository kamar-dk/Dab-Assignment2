using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB_Assignment2.Model
{
    public class CityHallPersonel
    {
        [Key] public int EmpId { get; set; }
        public int BookingId { get; set; } // Foreign key
        public List<Bookings> bookings { get; set; } // navi prop
        public List<AvailableItems> AvailableItems { get; set; }
        public string EmpName { get; set; }
    }
}
