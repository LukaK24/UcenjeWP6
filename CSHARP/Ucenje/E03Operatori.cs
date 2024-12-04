using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E03Operatori
    {
        public static void Izvedi()
        {


            // Console.WriteLine("E03");
            // operatori za rad s varijablama 
            // =je dodjeljivanje vrijednosti
            //== provjera jednokosti -> bool 

            int i = 7;  //zamislimo da je korisnik unio 7

            Console.WriteLine(1 == 6);

            int k = 2, l = 1;

            Console.WriteLine(l / k);

            Console.WriteLine(l / (float)k);


            //operator != nije jednako 

            Console.WriteLine(i != k);

            Console.WriteLine("5%2={0}", 5 % 2);

            Console.WriteLine("4%2={0}", 4 % 2);


            int b = 0;

            b = b + 1;




            b = 0;

            Console.WriteLine(b++);

            Console.WriteLine(++b);

            int t = 0, c = 1;
            t = c++ + t; // t=1,c=2

            c += --t; // c=2, t=0
            Console.WriteLine(c+t);
                


            





        }

    }
}
