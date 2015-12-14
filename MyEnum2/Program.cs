using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnum2
{
    enum Menu
    {
        Ett = 1, Tvau, Avsluta
    }
    class Program
    {
        static void Main(string[] args)
        {

            bool loop = true;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                PrintMenu();
                loop = MenuChoice(loop);
            } while (loop);
            Console.ReadLine();
        }

        private static bool MenuChoice(bool loop)
        {
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                Menu menu = (Menu)number;
                switch (menu)
                {
                    case Menu.Ett:
                        Console.WriteLine(Menu.Ett);
                        break;
                    case Menu.Tvau:
                        Console.WriteLine(Menu.Tvau);
                        break;
                    case Menu.Avsluta:
                        Console.WriteLine(Menu.Avsluta);
                        loop = false;
                        break;
                    default:
                        //throw new ArgumentOutOfRangeException();
                        Console.WriteLine("Something went wrong. Please try again.");
                        break;
                }
                System.Threading.Thread.Sleep(1000);
            }
            return loop;
        }

        private static void PrintMenu()
        {
            int counter = 1;
            foreach (var item in Enum.GetNames(typeof(Menu)))
            {
                Console.WriteLine("{0}: {1}", counter++, item);
            }
            Console.WriteLine("Please enter a number from the list above:");
        }
    }
}
