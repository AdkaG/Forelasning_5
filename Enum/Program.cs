using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnum
{
    enum Menu
    {
        Add = 1, Substract, Multiply, Devide, End
    }
    class Program
    {
        static void Main(string[] args)
        {
            StartMathProgram();
            Console.ReadLine();
        }

        private static void StartMathProgram()
        {
            bool loop = true;
            //läs in ett tal(1)
            //omvandla talet till enum(2)
            //switch på enum(3)
            //loop(4)
            do //(4)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                PrintMenuWithEnums();
                loop = MenuChoice(loop);
            } while (loop);
        }

        private static bool MenuChoice(bool loop)
        {
            int tal;
            if (int.TryParse(Console.ReadLine(), out tal)) //(1)
            {
                Menu menu = (Menu) tal; //(2)
                switch (menu) //(3)
                {
                    case Menu.Add:
                        AddMethod();
                        break;
                    case Menu.Substract:
                        SubstractMethod();
                        break;
                    case Menu.Multiply:
                        Console.WriteLine(Menu.Multiply);
                        break;
                    case Menu.Devide:
                        Console.WriteLine(Menu.Devide);
                        break;
                    case Menu.End:
                        Console.WriteLine(Menu.End);
                        loop = false;
                        break;
                    default:
                        //throw new ArgumentOutOfRangeException();
                        Console.WriteLine("Something went wrong. Please try again.");
                        break;
                }
                System.Threading.Thread.Sleep(3000);
            }
            return loop;
        }

        private static void SubstractMethod()
        {
            Console.WriteLine(Menu.Substract);
            int tal1;
            int tal2;
            Console.WriteLine("Enter two numbers:");
            if (int.TryParse(Console.ReadLine(), out tal1) && int.TryParse(Console.ReadLine(), out tal2))
            {
                Console.WriteLine("{0}-{1} = {2}", tal1, tal2, tal1 - tal2);
            }
        }

        private static void AddMethod()
        {
            Console.WriteLine(Menu.Add);
            int tal1;
            int tal2;
            Console.WriteLine("Enter two numbers:");
            if (int.TryParse(Console.ReadLine(), out tal1) && int.TryParse(Console.ReadLine(), out tal2))
            {
                Console.WriteLine("{0}+{1} = {2}", tal1, tal2, tal1 + tal2);
            }
        }

        private static void PrintMenuWithEnums()
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

/*
* (hel)talsliteraler som är konstanter
* kollektion av konstanter
* enum har automatiskt ToString() i samma namn som man anger
*/