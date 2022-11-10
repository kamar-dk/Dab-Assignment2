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

        private void SetDummyData()
        {
            Facilitys f1 = new Facilitys()
            {
                FcName = "Uni parken",
                ClosetAdress = "test",
                FcType = "Park",
                CanBeBookedBy = "Alle",
                FacilityDecrtiption = "bla"
            };
            Facilitys f2 = new Facilitys()
            {
                FcName = "Bla bålplads",
                ClosetAdress = "Bla vej",
                FcType = "Bålplads",
                CanBeBookedBy = "Alle",
                FacilityDecrtiption = "test test"
            };
            Facilitys f3 = new Facilitys()
            {
                FcName = "test bålsted",
                ClosetAdress = " bla bla vej",
                FcType = "Bålplads",
                CanBeBookedBy = "Alle",
                FacilityDecrtiption = "bla bla bla"
            };

            _facilitysController.Add(f1);
            _facilitysController.Add(f2);
            _facilitysController.Add(f3);

            User u1 = new User()
            {
                UserName = "Kasper",
                UserEmail = "test@test.dk",
                UserType = "Privat",
                PhoneNumber = "61667230"
                
            };

            User u2 = new User()
            {
                UserName = "Lasse",
                UserEmail = "Lasse@test.dk",
                UserType = "Privat",
                PhoneNumber = "12547869"
            };

            User u3 = new User()
            {
                UserName = "Trine",
                UserEmail = "Trine@test.dk",
                UserType = "Privat",
                PhoneNumber = "61658745"
            };

            _userController.Add(u1);
            _userController.Add(u2);
            _userController.Add(u3);

            Bookings b1 = new Bookings()
            {
                User = u1,
                Facilitys = f1,
                BookedFrom = new DateTime(2022, 11, 11, 8, 30, 00),
                BookedTo = new DateTime(2022, 11, 11, 23, 30, 00)
            };

            Bookings b2 = new Bookings()
            {
                User = u1,
                Facilitys = f3,
                BookedFrom = new DateTime(2022, 12, 11, 8, 30, 00),
                BookedTo = new DateTime(2022, 12, 11, 23, 30, 00)
            };

            _bookingsController.Add(b1);
            _bookingsController.Add(b2);
        }
    }
}
