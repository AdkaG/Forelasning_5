using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Var_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //dluga nazwa
            //Afsfgdjzxnskdffnvndxfbfnksemdhfnjsemddskdm Afsfgdjzxnskdffnvndxfbfnksemdhfnjsemddskdm = new Afsfgdjzxnskdffnvndxfbfnksemdhfnjsemddskdm();

            //lepsze rozwiazanie
            var Afsfgdjzxnskdffnvndxfbfnksemdhfnjsemddskdm = new Afsfgdjzxnskdffnvndxfbfnksemdhfnjsemddskdm();
            var heltal = 5;//sam wie ze to int; 
            var decimaltal = 5.9; //bez f wiec czyta jako double
            var text = "bla";
            text = "what";//literal i nie mozna zmienic na inny typ, mozna zmienic wartosc

            //var musi byc w metodzie, nie moze poza nia; poza metoda sa instancje a tu zmienne

            var tal = new int[] { 3,4,5,6,5,3,2};
            //lub int[] tal = {3,4,5,6,5,3,2};

            foreach(var item in tal)
            {
                Console.WriteLine(item);
            }
        }
    }
}
