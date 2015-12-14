using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryMeRefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            //användaren skriver in ett tal:
            string tal = "4";
            int svar; //ni vill översätta användarens tal till ett ett heltals-svar
            //svar = int.Parse(tal) krashar när anges icke tal
            //*** 1 sposob na sprawdzenie, czy uzytkownik wpisal dane do przetworzenia na liczbe***
            bool isValidNumber = int.TryParse(tal, out svar); //try.Parse sprawdza czy moze zamienic na liczbe, wylapuje spacje!!! nie wyrzuca bledu od razu i nie pada
            if(isValidNumber == false)
            {
                Console.WriteLine("inget giltigt nummer!!!"); //string tal = "4 eller något där omkring"; bedzie false, gdy string tal = "4"; - bedzie true
            }
            else
            {
                Console.WriteLine(3 * svar);
            }
            Console.ReadLine();

        }
    }
}
