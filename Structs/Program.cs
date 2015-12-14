using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            //StructDemo_1();
            //StructDemo_2();
            //StructMixture();


            Console.ReadLine();
        }

        private static void StructMixture()
        {
            Mixture myMixture;
            myMixture = new Mixture(true, 3.75, 12L);
            Mixture myMixture2 = new Mixture() {MyBool = true, MyDouble = 7.55, MyInt = 444L};
            Console.WriteLine(myMixture);
            Console.WriteLine(myMixture2);
        }

        private static void StructDemo_2()
        {
            Point ett;
            ett.X = 2;
            ett.Y = 3;
            ett = new Point(40);
            Console.WriteLine("X: {0}, Y: {1}", ett.X, ett.Y);
            Console.WriteLine(ett.AddXy());
            Point punkt;
            punkt = new Point(15, 12);
            Console.WriteLine("X: {0}, Y: {1}", punkt.X, punkt.Y);
        }

        private static void StructDemo_1()
        {
            Koordinat koordinat; //nie trzeba pisac new bo nie ma tego na heapie i nie musimy rezerwowac miejsca tam
            koordinat.X = 66;
            koordinat.Y = 88;

            Koordinat origo = new Koordinat() {X = 0, Y = 0};
                //mozemy uzywac inicjalizatorow nawet jak ich nie zaimplementowalismy w strukturze
            origo.Z = "20";
            origo = new Koordinat();
                //ustawia struct na O (i null gdy jest string), wszystkie pola otzrymuja wartosc domyslna - ållt nollställas;
            Console.WriteLine(origo);
        }
    }
}
