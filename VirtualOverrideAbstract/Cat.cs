using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideAbstract
{
    class Cat : Animal
    {
        string djur = "Katt";

        public Cat()
        {
            Name = "Mruczek";
            Age = 2;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"djur: {djur}, name: {Name}");
        }

        public override void Complain()
        {
            Console.WriteLine("Cat is complaining.");
        }
        public override void MakeNoise()
        {
            Console.WriteLine("Miau");
        }

        public override string ToString() => $"djur: {djur}, {base.ToString()}";
       
    }
}
