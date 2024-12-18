using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="niz"></param>
        /// <returns></returns>
        private static int Tip4(int[] niz) 
        {
            int suma = 0;
                foreach(int i in niz) 
            {
                suma += i;
            }
            return suma;
        }

        public static int UcitajCijeliBroj(string poruka) 
        {
            while (true) 
            {
                Console.WriteLine(poruka);
                try
                {
                    return int.Parse(Console.ReadLine());
                }
                catch 
                {
                    Console.WriteLine("Problem kod učitanja broja!");
                    
                }
            }


            //return 0;
        }
        public static string UcitajString(string poruka) 
        {
            string s = "";
            while (true)
            {
                Console.Write(poruka);
                s = Console.ReadLine().Trim();
                if (s.Length == 0) 
                {
                    Console.WriteLine("Obavezan unos");
                    continue;
                }
                return s;
            }

           
            
        }

    }

}
