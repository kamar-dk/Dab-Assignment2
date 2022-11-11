using System.ComponentModel.DataAnnotations;

namespace DAB_Assignment2.Model
{
    public class Facilitys
    {
        [Key] public int FcId { get; set; }
        public string FcName { get; set; } 
        //public string ClosetAdress { get; set; }
        public double GPS_lon { get; set; }
        public double GPS_lat { get; set; }
        public string FcType { get; set; }
        public string CanBeBookedBy { get; set; }
        public string FacilityDecrtiption { get; set; }
        public string? FcRule { get; set; } = null;
        public string? FcItems { get; set; } = null;
        public List<Bookings> Bookings { get; set; } = new();
        public List<Maintenance> MainHistory { get; set; } = new();
    }
}
