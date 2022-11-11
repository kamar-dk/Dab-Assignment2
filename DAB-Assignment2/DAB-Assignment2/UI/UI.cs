
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
            /*write("Kommandoer:\n");
            write("Q1 = Vis alle faciliteter med navn og gps");
            write("Q2 = Vis alle faciliter i en tabel med navn, gps og type");
            write("Q3 = Se all faciliter der er booket med brugernavn og tidslot");*/
        }
    }
}
