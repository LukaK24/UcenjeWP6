﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E15Subota
    {
        public static void Izvedi() 
        {
            PrimjerTryCatch();
        }

        private static void PrimjerTryCatch() 
        {
            try
            {
                int.Parse("osijek");
            }
            catch 
            {
                Console.WriteLine("Žao nam je zbog greške");
                
            }

            bool vrijednost = false;
             
            
                Console.WriteLine("Da li si zaposlen/a? (upiši Da ili bilo što za ne) ");
                if (Console.ReadLine().Trim().ToUpper() == "DA") 
                {
                vrijednost = true;
                    
                }
            Console.WriteLine(vrijednost);

            Console.WriteLine(E12Metode.UcitajBool("Da li si zaposlen/a?(upiši DA ili bilo šta za ne)","DA"));

            Console.WriteLine(E12Metode.UcitajBool("Jutros sam pojeo tri sendviča(istina/laž)", "istina"));




        }
    }


}
