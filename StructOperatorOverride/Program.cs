using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace StructOperatorOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Bike bike1 = new Bike(min: 3, max: 21);
            Bike bike2 = new Bike(min: 1, max: 2);
            bike2 += 12;
            Console.WriteLine(bike2);
            bike2 -= 6;//bike + tal
            int number = 6 + bike2;// tal + bike
            Console.WriteLine(bike2);
            Console.ReadLine();
        }
    }
}
