using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = MyStringExtension.Dotify("Hej");
            Console.WriteLine(name);
            Console.WriteLine("Kalle".Dotify());//uzywamy na stringu od razu metode extensionowana
            Console.ReadLine();
        }
    }
}
