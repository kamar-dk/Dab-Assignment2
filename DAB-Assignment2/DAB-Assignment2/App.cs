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
            _ui.write("For at køre tryk");
            while (true)
            {

            }

            return 0;
        }
    }
}
