using DAB_Assignment2.Model;
using DAB_Assignment2.Data;
using GeoCoordinatePortable;

namespace DAB_Assignment2.Controller
{
    public class FacilitysController : IController<Facilitys>
    {
        private readonly Context _context;

        public FacilitysController(Context context)
        {
            _context = context;
        }

        public bool Add(Facilitys facility)
        {
            GeoCoordinate check = new GeoCoordinate(facility.GPS_lat, facility.GPS_lon);

            _context.Facilitys.Add(facility);
            _context.SaveChanges();

            return true;
        }

        public Facilitys? Get(long id)
        {
            throw new NotImplementedException();
        }

        public List<Facilitys> GetAll()
        {
            List<Facilitys> facilities = _context.Facilitys.ToList();
            return facilities;
        }
    }
}
