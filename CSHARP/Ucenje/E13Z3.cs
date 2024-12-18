using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Z3
    {
        public static void Izvedi() 
        {
            string ime = E12Metode.UcitajString("Unesi ime: ");
            string prezime = E12Metode.UcitajString("Unesi prezime: ");
            Console.WriteLine("{0} {1}", prezime,ime);
          
           

        }
    }
}
