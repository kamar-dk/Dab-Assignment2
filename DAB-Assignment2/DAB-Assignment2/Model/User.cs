using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB_Assignment2.Model
{
    public class User
    {
        [Key] public string UserName { get; set; }
        public string UserEmail { get; set; } = null;
        public string PhoneNumber { get; set; }
        public string UserType { get; set; }
        public string CVR { get; set; }
        public List<Bookings> Bookings { get; set; } = new();
    }
}
