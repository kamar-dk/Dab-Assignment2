using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAB_Assignment2.UI
{
    public class Ui
    {
        public void write(string text)
        {
            Console.WriteLine(text);
        }

        public string read()
        {
            string read = Console.ReadLine();
            return read;
        }

        public string GetCom()
        {
            write("Input kommando: ");
            string comm = "";
            comm += read();
            return comm;
        }

        public void ShowMenu()
        {
            write("Kommandoer:\n");
            write("F = Vis alle faciliteter med navn og nærmeste adress");
            write("T = Vis alle faciliter i en tabel med navn, adresse og type");
            write("B = Se all faciliter der er booket med brugernavn og tidslot");
        }
    }
}
