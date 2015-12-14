using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutSome
{
    class Program
    {
        static void Main(string[] args)
        {
            //både ref och out pekar på den variabel som ligger utnaför metodanropet
            //det yttre värdet förändras innifrån

            Program program = new Program();
            string hmmm; //wystarczy deklaracja, nie musi byc wartosci
            string lyric;
            program.MusicSkaByggasUtavGladje(out hmmm);
            program.MusicSkaByggasUtavGladje(out lyric);
            Console.WriteLine(hmmm);
            Console.WriteLine();
            
            program.MusicSkaByggasUtavGladje(33, out hmmm, out lyric);
            Console.WriteLine(hmmm + lyric);
            System.Threading.Thread.Sleep(10000);
        }
        void MusicSkaByggasUtavGladje(out string lyric) 
            //default private; nie jest static wiec musimy stworzyc instancje w Main dla klasy, w tym przypadku Program program = new Program();
        {
            lyric = "Stilla natt, heliga natt...";//tu musi byc wartosc, , bo sama zmienna ktora wysylamy do metody nie musi miec wartosci
        }
            void MusicSkaByggasUtavGladje(int t, out string lyric, out string tvau)
        {
            lyric = t.ToString() +  " Pluss";
            tvau = lyric + "hej";
        }
        
    }
}
