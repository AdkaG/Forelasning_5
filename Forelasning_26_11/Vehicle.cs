using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_26_11
{
    //dziedziczenie
    class Vehicle
    {
        public int Wheels { get; set; }
        public int Passengers { get; set; }
        public void PrintVehicle() //mindre bra sätt att skriva ut en instans på
        {
            //för att vi kräver Console klass
            Console.WriteLine($"Basklassen Vehicle säger:\r\nWheels: {Wheels}\r\nPassengers: {Passengers}");
        }
        //nadpisujemy metode virtualna, ona mowi: jestem napisana, gotowa, znasz lepszy sposob, nadpisz mnie, normalnie zwraca namespace.class
            public override string ToString()=> $"Wheels: {Wheels} Passengers: {Passengers}";
        }
           
        }


