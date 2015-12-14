using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //return zwraca tylko jedna wartosc, gdy potrzebujemy wiecej zwrocic uzywamy ref
            int ickeMagi = 6; //måste skapa värdet, musi miec wartosc zanim ja wyslemy!
            double nja = 999;
            string ble = "Sofia";
            Magiska(ref ickeMagi, ref nja, ref ble);  //ReferenceEquals peckar tillbaks på 5 z metody; wyslana liczba zmienia sie za pomoca metody mimo braku return!!! zmienia wartosc na stosie
            Console.WriteLine(ickeMagi);
            Console.WriteLine(nja);
            Console.WriteLine(ble);
            System.Threading.Thread.Sleep(10000);

        }
        //moga byc dwie i wiecej, moga byc roznych typow, nie musi byc w metodzie ta sama nazwa
        static void Magiska(ref int tal, ref double nja, ref string ble) //struct lezy na stosie i jest jak klasa ale nie ma data na heapie; nie moze byc obiekt ref;
        {
            tal += 5; //moze byc tylko wartosc, moze byc tez jakies dzialanie, bo zmienna ma na pewno zadeklarowana wartosc zanim ja zmienimy
            nja = 0;
            ble = "Hanna";
        }
    }
}
