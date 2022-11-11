using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAB_Assignment2.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long CPR { get; set; }
        public string UserName { get; set; } = null!;
        public string UserEmail { get; set; } = null!;
        public string PhoneNumber { get; set; }
        public string UserType { get; set; }
        //public string? CVR { get; set; }
        public List<Bookings> Bookings { get; set; } = new();
    }
}
