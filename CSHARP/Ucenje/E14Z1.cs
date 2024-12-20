using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E14Z1
    {
        

        public static void Izvedi()
        {
            Console.WriteLine("Dobro došli u vježbanje petkom");
            Izbornik();
            Console.WriteLine("Hvala na korištenju, doviđenja");
        }
        public static void Izbornik() 
        {
            Console.WriteLine();
            Console.WriteLine("IZBORNIK");
            Console.WriteLine("1. parnost broja");
            Console.WriteLine("2. Tablica množenja");
            Console.WriteLine("0. izlaz iz programa");
            OdabirOpcijeIzbornika();
        }

        private static void OdabirOpcijeIzbornika()
        {
            switch(E12Metode.UcitajCijeliBroj("Odaberi stavku izbornika: ",0,2)) 
            {
                case 0:
                    break;
                case 1:
                    ParnostBroja();
                    Izbornik();
                    break;
                case 2:
                    TablicaMnoženja();
                    Izbornik();
                    break;
            }
        }

        private static void TablicaMnoženja()
        {
            NaslovPrograma("Program koji za dane brojeve redaka i stupaca generira tablicu množenja");
        }

        private static void ParnostBroja()
        {

            NaslovPrograma("**********");
           
            int broj = E12Metode.UcitajCijeliBroj("Unesi cjieli broj: ");
            if(broj % 2 == 0) 
            {
                Console.WriteLine("Uneseni broj {0} je PARAN", broj);
            }
            else 
            {
                Console.WriteLine("Uneseni broj {0} je NEPARAN", broj);
            }
        }

        private static void NaslovPrograma(string naslov) 
        {
            Zvjezdice(naslov.Length);
            Console.WriteLine(naslov);
            Zvjezdice(naslov.Length);
        }

        private static void Zvjezdice(int komad) 
        {
            for (int i = 0; i < komad; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }
}
