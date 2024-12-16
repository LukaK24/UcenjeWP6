using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10Z1
    {
        public static void Izvedi() 
        {
            //Console.WriteLine("Bok");
            Console.Write("Unesi izraz: ");
            string izraz=Console.ReadLine();
            Console.WriteLine(izraz);
            if (izraz.Length % 2 == 0) 
            {
                Console.WriteLine("parno");
                bool palindrom = true;
                for (int i = 0; i < izraz.Length / 2;i++) 
                {
                    if (izraz[i] != izraz[izraz.Length -1 - i]) 
                    {
                    palindrom = false;
                        break;
                    }

           
                }
                Console.WriteLine(palindrom ?"DA" : "NE");
                
                // DZ napraviti NEPARNO
            }else 
            {
                Console.WriteLine("neparno");
            }

 
            
                // Deklaracija niza za pohranu 25 brojeva
                int[] brojevi = new int[25];

                // Unos brojeva
                Console.WriteLine("Unesite 25 brojeva:");
                for (int i = 0; i < brojevi.Length; i++)
                {
                    Console.Write($"Broj {i + 1}: ");
                    brojevi[i] = int.Parse(Console.ReadLine());
                }

                // Izračunavanje kocki i ispis u tablici
                Console.WriteLine("\nBroj\tKocka");
                for (int i = 0; i < brojevi.Length; i++)
                {
                    int kocka = brojevi[i] * brojevi[i] * brojevi[i];
                    Console.WriteLine($"{i + 1}\t{kocka}");
                }
            
        }
    }

}

    

