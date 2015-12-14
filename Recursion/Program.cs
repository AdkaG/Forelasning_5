using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //WithForLoop();
            int iteration = 0;
            PrintToTenWithRecursion(iteration);
            //System.Threading.Thread.Sleep(10000);
            Console.ReadLine();
        }

        private static void PrintToTenWithRecursion(int i)
        {
            Console.WriteLine(i);
            i++;
            if(i <= 2)
            PrintToTenWithRecursion(i);
            Console.WriteLine("Jag är färdig." + i);
        }
        private static void WithForLoop()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
//recursion - speed but lot of memory
//forloop + forloop (On2)- no! bätter forloop + recursion (n log n)