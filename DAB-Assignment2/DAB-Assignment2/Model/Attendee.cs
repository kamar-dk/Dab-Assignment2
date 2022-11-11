using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAB_Assignment2.Model
{
    public class Attendee
    {
        [Key] public long CPR { get; set; }
        public List<Bookings> Bookings { get; set; } = new();
    }
}
