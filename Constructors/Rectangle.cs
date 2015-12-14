using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Rectangle
    {
        double height;
        double width;
        public Rectangle(double height = 0, double width = 0)//zera sa przez nas ustawione jako domyslne, domyslne nie sa obowiazkowe do wypelnienia wiec powinny lezec jako ostatnie a te obowiazkowe jako pierwsze
        {//{
        //    if (height > 0 && width > 0)
        //    {
                this.height = height;
                this.width = width;
            //else
            //{
                
            //    //Console.WriteLine("You can enter only positiv numbers.");
            //}

        }
    }
}
