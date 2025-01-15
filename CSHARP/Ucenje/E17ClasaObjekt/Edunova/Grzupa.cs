using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17ClasaObjekt.Edunova
{
    public class Grzupa
    {
        public int sifra { get; set; }
        public string naziv { get; set; } = "";
        public int velicingrupe { get; set; }
        public string? predavac { get; set; }
        public Smjer smjer { get; set; } =new Smjer();
        public Polaznik[]? polaznici { get; set; }

        public void detaljigrupe() 
        {
            Console.WriteLine(naziv);
            Console.WriteLine(smjer.naziv);
            foreach (Polaznik p in polaznici ?? []) 
            {
                Console.WriteLine(p.imeprezime());
            }
        }
    }
}
