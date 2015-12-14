using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiding
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            A ab = new B();//A moze byc B - nowy ssak ma byc kotem - polimorfizm; choc bedzie instancja klasy B ma uzywac A
            B b = new B();

            a.Print();
            ab.Print();
            b.Print();

            Console.ReadLine();
        }
    }

    class A
    {
        public void Print()
        {
            Console.WriteLine("Basklassen");
        }
    }
    class B : A
    {
        new public void Print()
        {
            Console.WriteLine("Gömt metod i A");
        }
    }
}
