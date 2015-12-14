using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideAbstract
{
    class Dog : Animal
    {
        string djur = "Hund";
        public Dog()
        {
            Name = "Ares";
            Age = 3;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"djur: {djur}, name: {Name}");
        }

        public override void Complain()
        {
            Console.WriteLine("Dog is complaining.");
        }
        public new void MakeNoise()
        {
            Console.WriteLine("Wow wow");
        }

        public override string ToString() => $"djur: {djur}, {base.ToString()}";
    }
}
