using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAB_Assignment2.Controller;
using DAB_Assignment2.Model;
using DAB_Assignment2.Data;

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
