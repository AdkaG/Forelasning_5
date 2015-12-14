using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnum5
{
    enum Menu
    {
        White = 1, Yellow, Pink, Green, Blue, Exit
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            do
            {
                Console.Clear();
                PrintMainMenu();
                loop = ChoiseMenu(loop);
            } while (loop);
            Console.ReadLine();
        }

        private static bool ChoiseMenu(bool loop)
        {
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                Menu menu = (Menu) number;
                switch (menu)
                {
                    case Menu.White:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(Menu.White);
                        break;
                    case Menu.Yellow:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(Menu.Yellow);
                        break;
                    case Menu.Pink:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine(Menu.Pink);
                        break;
                    case Menu.Green:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine(Menu.Green);
                        break;
                    case Menu.Blue:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(Menu.Blue);
                        break;
                    case Menu.Exit:
                        Console.WriteLine(Menu.Exit);
                        loop = false;
                        break;
                    default:
                        //throw new ArgumentOutOfRangeException();
                        Console.WriteLine("Something went wrong. Try again.");
                        break;
                }
                System.Threading.Thread.Sleep(2000);
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
