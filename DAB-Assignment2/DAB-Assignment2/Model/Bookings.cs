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
        //public string BookedBy { get; set; } = null; // Foreign key
        public User User { get; set; } = null!; // Navi 
        public Facilitys Facilitys { get; set; } = null!;
        public DateTime BookedFrom { get; set; }
        public DateTime BookedTo { get; set; }
        //public string Note { get; set; } = null;
        [Required] public List<Attendee> Attendees { get; set; } = new();
    }
}
