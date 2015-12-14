using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_Fredag20_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1.reachableNumber = 7;//bez instancji bo static, mozna zmienic wszedzie bo public; nie-static bedzie unikatowy dla kazdej instancji
          //Class1.notReachableNumber = 9;//private wiec nie ma dostepu
            Console.WriteLine(Class1.PI);//nie mozna go zmienic, nie mozna m nic przypisac, mozna tylko sie nim poslugiwac
        }
    }
}
