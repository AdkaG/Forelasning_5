using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverrideAbstract
{
    class Program
    {
        static void Main(string[] args)
        {


           

          
            //Animals();
            //VirtualMetods();

            Console.ReadLine();
        }

        private static void Animals()
        {
            Cat cat = new Cat();
            Dog dog = new Dog();
            Giraffe giraffe = new Giraffe();

            cat.Complain();//virt - over = > pozne wiazanie
            cat.MakeNoise();//virt - over = > pozne wiazanie
            cat.Eat();//zwykla = > wczesne wiazanie
            dog.Complain();//virt - over = > pozne wiazanie
            dog.MakeNoise();//virt - new = > wczesne wiazanie
            dog.Eat();//zwykla
            giraffe.Complain();//virt - over = > pozne wiazanie
            giraffe.MakeNoise();//virt - nic = > pozne wiazanie
            giraffe.Eat();//zwykal - new = > wczesne wiazanie
            Console.WriteLine();

            Animal animalCat = new Cat();
            Animal animalDog = new Dog();
            Animal animalGiraffe = new Giraffe();
            animalCat.Complain();//virt - over = > pozne wiazanie
            animalCat.MakeNoise();//virt - over = > pozne wiazanie
            animalCat.Eat();//zwykla = > wczesne wiazanie
            animalDog.Complain();//virt - over = > pozne wiazanie
            animalDog.MakeNoise();//virt - new = > wczesne wiazanie
            animalDog.Eat();//zwykla
            animalGiraffe.Complain();//virt - over = > pozne wiazanie
            animalGiraffe.MakeNoise();//virt - nic = > pozne wiazanie
            animalGiraffe.Eat();//zwykal - new = > wczesne wiazanie
            Console.WriteLine();

            //Cat catAnim = new Animal();
            //Dog dogAnim = (Dog)new Animal();
            //Giraffe giraffeAnim = (Giraffe)new Animal();
            //catAnim.Complain();//virt - over = > pozne wiazanie
            //catAnim.MakeNoise();//virt - over = > pozne wiazanie
            //catAnim.Eat();//zwykla = > wczesne wiazanie
            //dogAnim.Complain();//virt - over = > pozne wiazanie
            //dogAnim.MakeNoise();//virt - new = > wczesne wiazanie
            //dogAnim.Eat();//zwykla
            //giraffeAnim.Complain();//virt - over = > pozne wiazanie
            //giraffeAnim.MakeNoise();//virt - nic = > pozne wiazanie
            //giraffeAnim.Eat();//zwykal - new = > wczesne wiazanie
            Console.WriteLine();

            Console.WriteLine("Cat,dog,giraffe:");
            //cat.PrintInfo();
            //dog.PrintInfo();
            //giraffe.PrintInfo();
            Console.WriteLine(cat);
            Console.WriteLine(dog);
            Console.WriteLine(giraffe);
            Console.WriteLine();

            Console.WriteLine("Animal as new cat, animal as new dog, animal as new giraffe:");
            //animalCat.PrintInfo();
            //animalDog.PrintInfo();
            //animalGiraffe.PrintInfo();
            Console.WriteLine(animalCat);
            Console.WriteLine(animalDog);
            Console.WriteLine(animalGiraffe);

            Console.WriteLine("Cat as new animal, dog as new animal, giraffe as new animal ");
            //catAnim.PrintInfo();
            //dogAnim.PrintInfo();
            //giraffeAnim.PrintInfo();
            //Console.WriteLine(catAnim);
            //Console.WriteLine(dogAnim);
            //Console.WriteLine(giraffeAnim);
            Console.WriteLine();
        }

        private static void VirtualMetods()
        {
            Bicycle bicycle = new Bicycle();
            Fordon fordon = new Fordon();
            Fordon fordonBic = (Fordon)bicycle;
            MyBil bil = new MyBil();
            
            bicycle.NewPrint();
            fordon.NewPrint();
            fordonBic.NewPrint();
            bil.NewPrint();
            
            Console.WriteLine();

            Fordon[] fordonare = new Fordon[4] { bicycle, fordon, fordonBic, bil };
            foreach (var item in fordonare)
            {
                item.Print();
            }
            Console.WriteLine();
            foreach (var item in fordonare)
            {
                Console.Write("I loop:");
                item.NewPrint();
            }
            VehicleDeriv vehicle = new VehicleDeriv();
            vehicle.Print();
            //bicycle.Print();
            //fordon.Print();
        }
    }
}
