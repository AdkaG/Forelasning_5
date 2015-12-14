using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideAbstract
{
    class Giraffe : Animal
    {
        string djur = "Giraffe";
        public Giraffe()
        {
            Name = "Lisa";
            Age = 5;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"djur: {djur}, name: {Name}");
        }

        public override void Complain()
        {
            Console.WriteLine("Giraffe is complaining");
        }
        public new void Eat()
        {
            Console.WriteLine("Am am am");
        }
    }
}
