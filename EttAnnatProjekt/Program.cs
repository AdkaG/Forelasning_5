using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forelasning_26_11_modyfikatory_dostepu;

namespace EttAnnatProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClassFromAnotherProject = new MyClass();
            myClassFromAnotherProject.public_string = "";
        }
    }
}
