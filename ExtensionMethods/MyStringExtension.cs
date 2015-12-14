using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    public static class MyStringExtension
    {
        public static string Dotify(this string text)//nigdy nie zmieniamy text -- zawsze tworzymy nowa zmienna
        {
            string result = text.Trim();
            if (result[result.Length - 1] != '.')
            {
                return result + '.';
            }
            else
                return result;

        }
        public static string BigLetter(this string text)
        {
            string result = text.Split
        }
    }
}
