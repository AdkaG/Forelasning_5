using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kollektioner
{
    class Program
    {
        static void Main(string[] args)
        {

            //Product orange = new Product(name:"orange", quantity:7);
            //Product apple = new Product(name: "apple", quantity: 59);
            //Product rabbit = new Product(name:"rabbit", quantity: 12);
            //var products = new List<Product>() {orange, apple, rabbit};
            //Console.WriteLine("Enter min quantity:");
            //int minQuantity = int.Parse(Console.ReadLine());

            //foreach (var element in products)
            //{
            //    if (element.Quantity >= minQuantity)
            //    {
            //        Console.WriteLine(element);
            //    }
            //}


            var products = new List<Product>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Name:");
                var name = Console.ReadLine();
                Console.WriteLine("Quantity:");
                var quantity = int.Parse(Console.ReadLine());
                products.Add(new Product(name, quantity));
            }
            products.Sort();
            Console.WriteLine("Min?");
            var minQ = int.Parse(Console.ReadLine());
            foreach (var product in products)
            {
                if (product.Quantity > minQ)
                {
                    Console.WriteLine(product);
                }
            }


            //SortList();
            //TalList();
            //BoolList();
            //IntList();
            //BusList();
            //PlaneList();
            //Lista2();
            //Lista1();
            Console.ReadLine();
        }

        private static void SortList()
        {
            Plane plane1 = new Plane(seats: 200, pilots: 4);
            Plane plane2 = new Plane(seats: 220, pilots: 3);
            Plane plane3 = new Plane(seats: 180, pilots: 4);

            var planes = new List<Plane>() {plane1, plane2, plane3};
            planes.Sort(); //klasa amusi implementowac, dziedziczyc z IComparable
            //klasa ma metode CompareTo
            //TO + TO w klasie
            planes.Reverse();

            foreach (var element in planes)
            {
                Console.WriteLine(element);
            }
        }

        private static void TalList()
        {
//List<int> tal = new List<int>() {2,3,4,5};//obj. init.
            List<int> tal = new List<int>(new int[] {2, 3, 4, 5, 6, 7, 8, 9});
            List<int> copy = new List<int>(tal);
            int indexPosition = tal.IndexOf(7);
            Console.WriteLine(indexPosition); // 7 på pos 5 är första förekomsten
            indexPosition = tal.IndexOf((2));
            Console.WriteLine(indexPosition); //0
            indexPosition = tal.IndexOf(33);
            Console.WriteLine(indexPosition); //-1 - finns inte
        }

        private static void BoolList()
        {
            var lista = new List<bool>() {true, false, false, true};
            lista.Add(true);
            lista.Add(false);
            lista.Add(true);
            lista.Add(true);

            Console.WriteLine(lista.Count);
            lista.Clear();
            Console.WriteLine(lista.Count);
        }

        private static void IntList()
        {
            List<int> skorstorlekar = new List<int>() {33, 35, 36, 23, 27, 44, 42, 25, 41, 40};
            skorstorlekar.Sort();
            //skorstorlekar.Reverse();
            foreach (var element in skorstorlekar)
            {
                Console.WriteLine(element);
            }
            for (int i = 0; i < skorstorlekar.Count; i++)
            {
                Console.WriteLine(skorstorlekar[i]);
            }
        }

        private static void PlaneList()
        {
            var plane = new List<Plane>();
            for (int i = 0; i < 100; i++)
            {
                plane.Add(new Plane(i + 200, i + 500));
            }
            foreach (var element in plane)
            {
                Console.WriteLine(element);
            }
        }

        private static void BusList()
        {
            var bus = new List<Bus>();
            for (int i = 0; i < 100; i++)
            {
                bus.Add(new Bus(i * 10, i + 60));
            }
            foreach (var element in bus)
            {
                Console.WriteLine(element);
            }
        }

        private static void Lista2()
        {
            var persons = new List<Person>();
            for (int i = 0; i < 100; i++)
            {
                persons.Add(new Person("Name" + i, i % 30));
            }
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
            Console.ReadLine();
        }

        private static void Lista1()
        {
            Person lisa = new Person("Lisa", 26);
            Person raffe = new Person("Rafael", 44);

            List<Person> persons = new List<Person>();
            persons.Add(lisa);
            persons.Add(raffe);
            foreach (var person in persons)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
