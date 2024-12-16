using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E12Metode
    {
        public static void Izvedi() 
        {
            Tip1();
            Tip1();

           
            
            
            Tip2(10, "Poziv druge varijante metode Tip2");

            int i = Tip3() + 1;
            Console.WriteLine(i);
        }
        static void Tip1(/* ovdje dođu paratmeri ili ne*/) 
        {
            Console.WriteLine("Ispis iz 1. tipa metode");
            Console.WriteLine("*******");
            Console.WriteLine("Kraj ispisa iz 1. tipa metode");
        }
        
        private static void Tip2(int x) 
        {
            for (int i = 0; i < x; i++) 
            {
                Console.Write(i);
            }
        }
        private static void Tip2(int x, string naslov) 
        {
            Console.WriteLine(naslov);
            Tip2(x);
        }

        private static int Tip3() 
        {
            return int.MaxValue;
        }

    }

}
