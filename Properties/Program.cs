using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Name = "Selda";
            Console.WriteLine(game.Name);

            Bicycle bicycle = new Bicycle();
            bicycle.Gears = 3;
            bicycle.Brand = "Embassy";

            Bicycle bicycle2 = new Bicycle();
            bicycle2.Gears = 7;
            bicycle2.Brand = "MountainBike";

            //Object initializer, mozemy bo mamy properties
            Bicycle bicycle3 = new Bicycle() { Brand="rex", Gears = 7};

            Console.WriteLine($"{bicycle.Gears}, {bicycle.Brand}, {bicycle2.Gears}, {bicycle2.Brand}");

            Table myTable = new Table() {Color= "white", NumberOfChairs = 6 };
            
            Table table = new Table();
            Table table2 = new Table("brown");
            Table table3 = new Table("white", 4);


           Console.ReadLine();
        }
    }
}
