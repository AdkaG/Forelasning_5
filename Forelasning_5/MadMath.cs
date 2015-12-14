using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_5
{
    static class MadMath
    {
        internal static double Add(double tal)
        {
            return tal;
        }
        internal static double Add(double tal1, double tal2)
        {
            return tal1 + tal2;
        }
        internal static double Add(double x, double y, double z)
        {
            return x + y + z;
        }

        //internal static double Add(double[] array)
        //{
        //    double sum = 0;
        //    for (int i = 0; i < array.Length; i++)
        //    {
        //        sum += array[i];
        //    }
        //    return sum;
        //}
        internal static double Add(params double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
       internal static void TestParams(params object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            
        }
    }
}
