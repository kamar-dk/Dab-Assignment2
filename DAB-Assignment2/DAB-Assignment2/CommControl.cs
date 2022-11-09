using DAB_Assignment2.Data;
using DAB_Assignment2.Controller;
using DAB_Assignment2.Model;
using DAB_Assignment2.UI;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAB_Assignment2
{
    public class CommControl
    {
        private Ui _ui;
        private FacilitysController _facilitysController;
        private BookingsController _bookingsController;
        private UserController _userController;
        private Context _context;

        public CommControl(Ui ui)
        {
            _ui = ui;
            _context = new Context();
            _facilitysController = new FacilitysController(_context);
            _bookingsController = new BookingsController(_context);
            _userController = new UserController(_context);

            if (!ContextContainsData())
            {
                SetDummyData();
            }


        }

        private bool ContextContainsData()
        {
            var f = _context.Facilitys.FirstOrDefault();
            var r = _context.Bookings.FirstOrDefault();
            var u = _context.Users.FirstOrDefault();
            if (f != null || r != null || u != null)
            {
                return true;
            }
            return false;
        }

        private void SetDummyData()
        {

        }

        public void GetFacilitysWithAdress()
        {
            var facilitys = _context.Facilitys.ToList();
            string format = "";
            foreach (Facilitys f in facilitys)
            {
                string line = "";
                line += "Name: " + f.FcName;
                while (line.Length < 40)
                {
                    line += ' ';
                }
                line += "Adress: " + f.ClosetAdress;
                format += line + "\n";
            }
            _ui.write(format);
        }

        public void GetFacilitysOrdered()
        {
            List<Facilitys> facilitys = _context.Facilitys
                .OrderBy(f => f.FcType)
                .ToList();

            string format = "";
            foreach (Facilitys f in facilitys)
            {
                string line = "";
                line = "Type: " + f.FcType;
                while (line.Length < 20)
                {
                    line += ' ';
                }
                line += "Facilit navn: " + f.FcName;
                while (line.Length < 64)
                {
                    //line += ' ';
                }
                line += "Adress: " + f.ClosetAdress;
                format += line + "\n"; 
            }
            _ui.write(format);
        }

        public void GetBookings()
        {
            List<Bookings> bookings = _context.Bookings.ToList();

            foreach(var b in bookings)
            {
                _context.Entry(b).Reference(book => book.Facilitys).Load();
                _context.Entry(b).Reference(book => book.User).Load();

                string format = "";

                string line = "";
                line += "Facilitet navn; " + b.Facilitys.FcName;
                while (line.Length < 30)
                {
                    line += ' ';
                }
                line += "Navn: " + b.User.UserName;
                while (line.Length < 50)
                {
                    line += ' ';
                }
                line += "Resaveret fra: " + b.BookedFrom + " Til: " + b.BookedTo;

                format += line + "\n";
                _ui.write(format);
            }   

        }
    }
}
