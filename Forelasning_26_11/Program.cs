using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_26_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car() { Wheels = 6, HorsePower = 55, Passengers = 4};
            Bicycle bicycle = new Bicycle() { Wheels = 2, Spokes = 3, Passengers= 1 };
            Vehicle vehicle = new Vehicle() { Passengers = 7, Wheels = 4};
            vehicle.PrintVehicle();//ma w metodzie ze Console.WriteLine

            Console.WriteLine(vehicle.ToString());//metoda daje tylko string, musimy go wydrukowac
            Console.WriteLine(bicycle.ToString());
            
            Console.ReadLine();

        }
    }
}
