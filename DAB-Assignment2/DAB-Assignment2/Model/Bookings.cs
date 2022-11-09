using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB_Assignment2.Model
{
    public class Bookings
    {
        [Key] public int BookingId { get; set; }

        public string BookedBy { get; set; } // Foreign key
        public List<User> User { get; set; } // Navi prop

        public string BookedFcName { get; set; } // Foreign key
        public List<Facilitys> Facilitys { get; set; } // Navi Prop

        public DateOnly BookedFrom { get; set; }
        public DateOnly BookedTo { get; set; }
        public string Note { get; set; }
    }
}
