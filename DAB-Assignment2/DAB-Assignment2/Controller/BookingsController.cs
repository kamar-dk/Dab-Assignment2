using DAB_Assignment2.Data;
using DAB_Assignment2.Model;
using Microsoft.EntityFrameworkCore;

namespace DAB_Assignment2.Controller
{
    public class BookingsController : IController<Bookings>
    {
        private Context _context;

        public BookingsController(Context context)
        {
            _context = context;
        }
        public void AddAttendee(long cpr, int bookingId)
        {
            if (_context.Attendees.FirstOrDefault(a => a.cprNr == cpr) == null)
            {
                var a = _context.Attendees.Add(new Attendee()
                { cprNr = cpr });
                _context.SaveChanges();
            }

            var add = _context.Attendees.FirstOrDefault(a => a.cprNr == cpr);
            var b = _context.Bookings.Include(book => book.Attendees).FirstOrDefault(b => b.BookingId == bookingId);
            b.Attendees.Add(add);
        }

        public bool Add(Bookings bookings)
        {
            _context.Bookings.Add(bookings);
            _context.SaveChanges();
            return true;
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
