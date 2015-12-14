using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forelasning_23_11
{
    class Burk
    {
        //automatiska properties
        public string Name { get; set; }
        public int Centiliter { get; set; }
        public double Height { get; set; }
        public Burk()
        {
            Name = "7up";
            Centiliter = 33;
            Height = 11.2;
        }
        public Burk(string name, double height)//kan vara en klurig grej;
        {
            Name = name;
            Height = height;
        }
        //:this() kastar vidare innan denna konstruktorn körs
        public Burk(int centiliter, double height, string name): this(name, height)
            //bierzemy z poprzedniego konstruktora name
        {
            Centiliter = centiliter;
            
        }
    }
}
