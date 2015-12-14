using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnum4
{
    enum Menu
    {
        Create = 1, Restore, Find, Exit
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
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
                Menu menu = (Menu)number;
                switch (menu)
                {
                    case Menu.Create:
                        Console.WriteLine(Menu.Create);
                        break;
                    case Menu.Restore:
                        Console.WriteLine(Menu.Restore);
                        break;
                    case Menu.Find:
                        Console.WriteLine(Menu.Find);
                        break;
                    case Menu.Exit:
                        Console.WriteLine(Menu.Exit);
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
        private static void PrintMainMenu()
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
