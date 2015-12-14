using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Konventeringar;

namespace Konverteringar
{
    class Program
    {
        static void Main(string[] args)
        {

            Point point = new Point(x: 2, y: 2);
            Point3D point3D = (Point3D) point;

            Point3D point3D1 = new Point3D(x:5, y:5,z:5);
            Point point1 = (Point) point3D1;

            Console.WriteLine(point);
            Console.WriteLine(point3D);
            Console.WriteLine(point3D1);
            Console.WriteLine(point1);

            //Cesius_Farenheit();
            //DoctrorKonvent();
            Console.ReadLine();


            //A class can be implicitly converted to any class in the chain from which it is derived
            //Konverteringar();
            Cyckel c1 = new Cyckel();//OK
            MC mc1 = new Cyckel();//Ej OK, ale kompilator nie narzeka ???
            MC mc2 = (MC)c1;//Explicit typkonvertering
            

        /*    //TEST:
            Cyckel cyckel = (Cyckel)new MC();
            MC mcTest = c1 as MC;//Probujr przerobic c1 na MC, gdy uda sie to mcTest bedzie MC gdy nie to null
            if(mcTest!= null)//kontroluje czy mc jest giltig
            {
                //konverterad
            }

            //TEST MED is:
            Object obj = new Cyckel();
            bool b = obj is Cyckel;//Zawsze prawda

            Cyckel cyckel2 = new Cyckel();
            Boolean f = cyckel2 is object;

            //Boxing
            int tal = 5;
            object paket = tal;//boxing - värdetyp till referenstyp
            //Unboxing
            int tal23 = (int)paket;//unboxing - referesetyp till värdetyp
            */
         }

        private static void Cesius_Farenheit()
        {
            Farenheit farenheit = new Farenheit(100.0f);
            Console.WriteLine($"{farenheit.Temp}");

            //Kasta F till C
            Celsius celsius = (Celsius) farenheit;
            Console.WriteLine($"Celsius: {celsius.Temp}");

            //Kasta C till C
            Farenheit farenheit2 = (Farenheit) celsius;
            Console.WriteLine($"Farenheit: {farenheit.Temp}");
        }

        private static void DoctrorKonvent()
        {
            Person Jack = new Person(age: 55);
            Console.WriteLine(Jack);
            Jack = new Doctor(age: 55, yearsOfPractise: 20);
            Console.WriteLine(Jack);
            Jack = new Surgeon(age: 55, yearsOfPractise: 20, numberOfOperations: 100);
            Console.WriteLine(Jack);
            Console.WriteLine();

            Surgeon Adam = new Surgeon(age: 47, yearsOfPractise: 22, numberOfOperations: 177);
            Doctor Adam1 = new Surgeon(age: 47, yearsOfPractise: 22, numberOfOperations: 177);
            Doctor Adam2 = Adam;
            Console.WriteLine(Adam);
            Console.WriteLine(Adam1);
            Console.WriteLine(Adam2);


            Doctor Patric = new Doctor(age: 40, yearsOfPractise: 13);
            Person David = Patric;
            //Person Lisa = new Person(age: 38);
            //Doctor Alice = Lisa;
            Console.WriteLine(Patric);
            Console.WriteLine(David);
        }

        private static void Konverteringar()
        {
            long tal = 200;//long = int64, 200 = int32 --> powinno  byc long tal = 200L;
            int tal2 = (int)200L;
            var doubleTal = 4.4;
            var floatTal = 4.4f;
            float flyttal = 4.4f;
            float flyttal1 = (float)4.4;
            int number = (int)doubleTal;//decimaler znikaja
        }
    }
}
