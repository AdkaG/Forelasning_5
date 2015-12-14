using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_23_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestingTractors();
            //TestingVa();
            //TestingRunsten();
            //TestingBulbs();

            Burk burk = new Burk(33, 11.5, "Cola");
            Burk objectInitializerStyle = new Burk() { Name = "Haineken", Height = 4.2, Centiliter = 4 };

            Console.ReadLine();
        }

        private static void TestingBulbs()
        {
            Bulb bulb = new Bulb(h: 222, s: 99, l: 1);
            Bulb bulb1 = new Bulb() { H = 333, S = 50, L = 70 };
            Bulb bulb2 = new Bulb();
            Console.WriteLine(bulb);
            Console.WriteLine(bulb1);
            Console.WriteLine(bulb2);
        }

        private static void TestingRunsten()
        {
            Runsten runsten = new Runsten();
            Runsten runsten2 = new Runsten("Magic");
            Runsten runsten3 = new Runsten("Cosmic", 4400);
            Runsten runsten4 = new Runsten("Venus", 6999, 1100);
            Runsten runsten5 = new Runsten() { Name = "Pi", Weight = 2200, Age = 777 };
            Runsten runsten6 = new Runsten() { Age = 1111, Weight = 5000, Name = "Rune" };
            Runsten runsten7 = new Runsten(name: "Rune", weight: 100, age: 444);//named parameters, nawet gdy ktos inny zmieni kolejnosc inparametrow bedzie ok (dot. duzych projektow team)

            Console.WriteLine(runsten);
            Console.WriteLine(runsten2);
            Console.WriteLine(runsten3);
            Console.WriteLine(runsten4);
            Console.WriteLine(runsten5);
            Console.WriteLine(runsten6);
        }

        private static void TestingVa()
        {
            Va va = new Va();
            Va va2 = new Va("Hej?");
            Va va3 = new Va("Hej?", 9.0);
            Console.WriteLine(va);
            Console.WriteLine(va2);
            Console.WriteLine(va3);
        }

        private static void TestingTractors()
        {
            Tractor tractor = new Tractor(); //var tractor = new Tractor();
            Tractor tractor2 = new Tractor(4);
            Tractor tractor3 = new Tractor(17, 1234567);

            Console.WriteLine(tractor);//Forelasning_23_11.Tractor
            Console.WriteLine(tractor2);//Forelasning_23_11.Tractor
            Console.WriteLine(tractor3);//Forelasning_23_11.Tractor
        }
    }
}
