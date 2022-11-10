using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAB_Assignment2.UI;
using Microsoft.EntityFrameworkCore;

namespace DAB_Assignment2
{
    public class App
    {
        private Ui _ui = new();
        private readonly CommControl _commControl;
        private bool run = false;


        public App()
        {
            _commControl = new CommControl(_ui);
        }

        public int Run()
        {

            bool running = true;
            _ui.write("For at vise alle faciliter med adreese indtast 'Q1'");
            _ui.write("For at vise alle faciliteter ordnet efter type indtast 'Q2'");
            _ui.write("For at få vist alle bookings indtast 'Q3'");

            string command = "";

            while (running == true)
            {
                command = Console.ReadLine();
                Handler(command);
            }

            return 0;
        }

        private void Handler(string command)
        {
            if (command == "Q1")
            {
                _commControl.GetFacilitysWithAdress();
            }
            if (command == "Q2")
            {
                _commControl.GetFacilitysOrdered();
            }
            if (command == "Q3")
            {
                _commControl.GetBookings();
            }
        }
    }
}
