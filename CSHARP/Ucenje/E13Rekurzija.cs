﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Rekurzija
    {

        public static void Izvedi() 
        {

            //Izvedi();
            Console.WriteLine(Zbroji(100));

        } 
        private static int Zbroji(int broj) 
        {
            return broj + Zbroji(broj - 1);
        } 
    }
}
