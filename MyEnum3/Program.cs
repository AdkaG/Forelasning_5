using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnum3
{
    enum Menu
    {
        Lista = 1, Rakna, Avsluta
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            bool loop = true;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                PrintMainMenu();
                loop = MenuChoice(loop);
            } while (loop);
            Console.ReadLine();
        }

        private static bool MenuChoice(bool loop)
        {
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                Menu menu = (Menu) number;
                switch (menu)
                {
                    case Menu.Lista:
                        Console.WriteLine(Menu.Lista);
                        break;
                    case Menu.Rakna:
                        Console.WriteLine(Menu.Rakna);
                        break;
                    case Menu.Avsluta:
                        Console.WriteLine(Menu.Avsluta);
                        loop = false;
                        break;
                    default:
                        //throw new ArgumentOutOfRangeException();
                        Console.WriteLine("Somthing went wrong. Try again.");
                        break;
                }
                System.Threading.Thread.Sleep(1000
                    );
            }
            return loop;
        }

        private static void PrintMainMenu()
        {
            int counter = 1;
            foreach (var item in Enum.GetNames(typeof (Menu)))
            {
                Console.WriteLine("{0}: {1}", counter++, item);
            }
            Console.WriteLine("Please enter a number from the list above:");
        }
    }
}
