using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAB_Assignment2.Controller;
using DAB_Assignment2.Data;
using DAB_Assignment2.Model;

namespace DAB_Assignment2.Controller
{
    public class BookingsController
    {
        private Context _context;

        public BookingsController(Context context)
        {
            _context = context;
        }

        public Bookings? Get(long id)
        {
            return _context.Bookings.Find(id);
        }

        public List<Bookings> GetAll()
        {
            return _context.Bookings.ToList();
        }
    }
}
