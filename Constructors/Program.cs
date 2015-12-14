using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person lisa = new Person();
            Person stina = new Person(27);
            Person ebba = new Person(7, "Ebba");

            Rectangle rectangle = new Rectangle();
            Rectangle rectangle2 = new Rectangle(3.2);//drugi bedzie per default 0
            Rectangle rectangle3 = new Rectangle(3.2, 9.0);
            //Named parameters, mozna zmienic kolejnosc, ma zawsze przypisane 
            Rectangle rectangle4 = new Rectangle(width: 44.3, height: 23.3);
            Rectangle rectangle5 = new Rectangle(height: 23.3, width: 44.3);

        }
    }
}
