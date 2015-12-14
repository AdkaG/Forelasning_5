using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryMeSimplified
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "100";
            int tal;
            if(int.TryParse(text, out tal))
            {
                //Scoopet körs bara om giltigt text-värde går att översätta till tal
                Console.WriteLine($"Talet är: {tal}");
            }
            System.Threading.Thread.Sleep(10000);
        }
    }
}
