using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_5
{
    class Program
    {
        int hej = 9; //fält - wszyscy w klasie maja dostep
        static void Main(string[] args)
        {

            //BreakingNewsContinue();
            //BreakingNewsBreak();
            //BreakingNewsReturn();
            //ForForeach();

            //Console.WriteLine(MadMath.Add(5.8));
            //Console.WriteLine(MadMath.Add(3.4, 4.5));
            //Console.WriteLine(MadMath.Add(3.4, 5.2, 2.1));
            //Console.WriteLine(MadMath.Add(new double[] {2,3,4,5,6,7,8,9 }));
            //Console.WriteLine(MadMath.Add(2, 3, 4, 5, 6, 7, 8, 9));
            MadMath.TestParams("a", "c", 3,4,5);
            Console.ReadKey();
        }

        private static void ForForeach()
        {
            int[] ages = new int[] { 3, 4, 22, 33, 3, 55, 34, 42 };
            Console.WriteLine("For Loop:");
            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] == 3)
                    continue;
                Console.WriteLine(ages[i]);
            }
            Console.WriteLine("Foreach Loop:");
            foreach (int element in ages)
            {
                if (element == 3)
                    continue;
                Console.WriteLine(element);
            }
        }

        //    ***METODA***
        //åtkomstdirektivet
        //klassmetod? np. static
        //typen
        //identifieraren
        //inparametrar (dör de efter scoopet)
        private static void BreakingNewsContinue()
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                    continue; //omija 3, pisze dalej;
            }
            Console.WriteLine("Bla");
        }
        private static void BreakingNewsBreak()
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                    break;  // ***break*** przerywa loop calkiem;
                Console.WriteLine(i);
            }
            Console.WriteLine("Bla");
        }
        private static void BreakingNewsReturn()
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3)
                    return; // ***return*** przerywa cala metode
                Console.WriteLine(i);
            }
            Console.WriteLine("Bla");
        }
    }
}
//int tal = 5; // = System.Int32 tal = 5; - synonim
//int tal2 = 4;
//for (float i = 0.0f; i< 2.0f; i = i + 0.1f) //nie ogarnia i dziwne wyniki, lepiej double            
//int tal = 5; //variabel - tylko w scope maja dostep, leza
//const double GRAVITY = 9.82; //nie da sie GRAVITY++, nie jest zmienna tylko stala, zawsze UPPERCASE
//string[] names = new string[] { "Lisa", "Hanna", "Lars", "Lasse" };

//foreach(string element in names)
//{
//    Console.WriteLine(element);
//}