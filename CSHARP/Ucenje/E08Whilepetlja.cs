using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E08Whilepetlja
    {

        public static void Izvedi()
        {
            Console.WriteLine("E08");

            int brojDo = 10;
            for (int i = 0; i < brojDo; i++)
            {
                Console.WriteLine(i);
            }

            while (true) 
            {

                Console.WriteLine("Osijek");
                break;
            }


            int broj = 0;

            while (broj < 10) 
            {
                Console.WriteLine(++broj);
            }

           
            
            
            
        }
    }
}
