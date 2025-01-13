using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17ClasaObjekt
{
    public class Program
    {
        // 5 vrsta metode(posebna) konstruktor
        //konstruktor mora imati isit nazic kao i klasa a lista parametara mora biti različita
        public Program() {

            //objekt je instanca (pojavnost) klase
            //Osba je ime klase(primjetiti veliko početno slovo)
            // osoba je ime objekta (instance/pohavnosti)- varijabla

            Osoba osoba = new Osoba();

            osoba.šifra = 1;

            //Osoba.sifra na kalsi ne postoji svojstvo ono je na objektu

            osoba.ime = "Pero";   //E12Metode.UcitajString("Unesi ime");
            osoba.prezime = "Perić";

            Console.WriteLine(osoba.ime);

            osoba = new Osoba() {
                šifra = 2,
                ime = "Karlo",
                prezime = "Lik"
            };

            Console.WriteLine("{0} {1}", osoba.ime, osoba.prezime);
            Console.WriteLine(osoba.imeprezime());

            Osoba.Izvedi();

            Mjesto Mjesto = new Mjesto() { Naziv = "Osijek", Postanskibroj = "31000" };

            //osoba.Mjesto=Mjesto;

            //ispiši osijek
            Console.WriteLine(osoba.Mjesto.Naziv);

        }

   
        
       


    }
}
