using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB_Assignment2.Model
{
    public class Facilitys
    {
        public int FcId { get; set; }
        public string FcName { get; set; } 
        public string ClosetAdress { get; set; }
        public string FcType { get; set; }
        public string CanBeBookedBy { get; set; }
        public string FacilityDecrtiption { get; set; }
        public string? FcRule { get; set; } = null;
        public string? FcItems { get; set; } = null;
        public List<Bookings> Bookings { get; set; } = new();
    }
}
