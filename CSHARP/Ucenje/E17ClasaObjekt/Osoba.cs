using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17ClasaObjekt
{
    //klasa je opisnih objekta -> Naučiti napamet

    internal class Osoba
    {
        //klasa sadrzi svojstva (property)
        public int šifra { get; set; } //OOP princip čahurivanja
        public string? ime { get; set; } //? označa kavko ime možw biti null
        public string? prezime { get; set; }

        public Mjesto? Mjesto { get; set; }

        //klasa sadrzi metode (i ne moraju biti statične)

        public string imeprezime() 
        {
        return ime + " " + prezime;
        
        }

        public static void Izvedi()
        {

            Console.WriteLine("Izvodenje staticne metode s klase");

        }
    }


}
