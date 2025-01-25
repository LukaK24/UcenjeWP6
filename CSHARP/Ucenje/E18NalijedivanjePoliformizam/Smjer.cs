using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18NalijedivanjePoliformizam
{
    public class Smjer:Entitet // klasa smjer nasljeduje javna i zasticena svojstva i metode iz klase entitet
    {
        public string naziv { get; set; } = "";
        public static object Naziv { get; private set; }

        public override string ToString()
        {
            return naziv;
        }
        public override bool Equals(object? obj)
        {
            return Smjer.Naziv.Equals(naziv);
        }
    }
}
