﻿using System;
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
            string[] programi = {
                "Parnost broja",
                "Tablica množenja",
                "Jedinična vrijednosr",
                "Broj znakova naziva mjesta"

            };

            Console.WriteLine();
            Console.WriteLine("IZBORNIK");
           for (int i = 0; i < programi.Length; i++) 
            {
                Console.WriteLine( "{0}.{1} ", i+1, programi[i]);
            }
            OdabirOpcijeIzbornika(programi.Length);
        }

        private static void OdabirOpcijeIzbornika(int programa)
        {
            switch(E12Metode.UcitajCijeliBroj("Odaberi stavku izbornika: ",0,programa)) 
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
                case 3:
                    JediničnaVrijednost();
                    Izbornik();
                    break;
                case 4:
                    BrojZnakovaNazivaMjesta();
                    Izbornik();
                    break;
            }
        }

        private static void BrojZnakovaNazivaMjesta()
        {
            NaslovPrograma("Za uneseni naziv mjesta ispisuje koliko ima znakova");
            Console.WriteLine(E12Metode.UcitajString("Unesi ime grada: ").Length);
        }

        
        

        private static void JediničnaVrijednost()
        {
            NaslovPrograma("Jedinična vrijednost");
            int broj = E12Metode.UcitajCijeliBroj("Unesi broj između 20 i 50: ", 20, 50);
            Console.WriteLine(broj % 10);
                
                
        }

        private static void TablicaMnoženja()
        {
            NaslovPrograma("Program koji za dane brojeve redaka i stupaca generira tablicu množenja");
            int redaka = E12Metode.UcitajCijeliBroj("Unesi broj redaka: ", 2, 10);
            int stupaca = E12Metode.UcitajCijeliBroj("Unesi broj stupaca: ", 2, 10);
            for(int i = 1; 1<=redaka; i++) 
            {
               for(int j = 1; j <=stupaca; j++) 
                {
                    Console.WriteLine("{0,4}",i*j);
                }
                Console.WriteLine();
            }
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
            NaglasiNaslov(naslov.Length);
            Console.WriteLine(naslov);
            NaglasiNaslov(naslov.Length);
        }

        private static void NaglasiNaslov(int komad) 
        {
           
            for (int i = 0; i < komad; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
        
            
            
        

    }
}
