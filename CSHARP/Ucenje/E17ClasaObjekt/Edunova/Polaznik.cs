using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17ClasaObjekt.Edunova
{
    public class Polaznik
    {
        public int sifra { get; set; }
        public string ime { get; set; } = "";
        public string prezime { get; set; } = "";
        public string email { get; set; } = "";
        public string? oib { get; set; }

        public string imeprezime() 
        {
            return ime + " " + prezime;
        }

    }
}
