using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideAbstract
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public abstract void PrintInfo();

        public virtual void Complain()
        {
            Console.WriteLine("Animal is complaining.");
        }
        public virtual void MakeNoise()
        {
            Console.WriteLine("Animal is making noise.");
        }
        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }


        public override string ToString() => $"name: {Name}, age: {Age}";
        
    }
}





