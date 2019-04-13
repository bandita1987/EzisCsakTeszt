using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication43
{
    class Program
    {
        static void Main(string[] args)
        {
            /*foo -> foo1

            foobar23 -> foobar24*/

            string szo1 = "aladar";
            Function(ref szo1);
            Console.WriteLine(szo1);


            Console.ReadLine();
        }

        private static string Function(ref string szo1)
        {
            int szamlalo = 0;
            for (int i = 0; i < szo1.Length; i++)
            {
                if (char.IsDigit(szo1[i]))
                {
                  
                    szamlalo = i; break; ;

                }
            }
            int hanyTolSzam =  szamlalo;
            char asd = ' ';
            char ucso = szo1.LastOrDefault();

            if (!(char.IsDigit(ucso))) {
                szo1 += "1";
            }
            else
            {
                string szam = szo1.Substring(hanyTolSzam);
                int szam1 = Convert.ToInt32(szam);
                szam1 += 1;
                szo1=szo1.Substring(0,hanyTolSzam);
                szo1 += szam1;
            }

            return szo1;
        }
    }
}
