using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucenje.E17ClasaObjekt.Edunova;

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
            //Console.WriteLine(osoba.Mjesto.Naziv); 

            //stari nacin
            if(osoba.Mjesto != null) 
            {

                Console.WriteLine(osoba.Mjesto.Naziv);

            }
            //kraci nacin
            Console.WriteLine(osoba.Mjesto?.Naziv); //? je ovdje indikacija da ne pukne



            osoba.Mjesto = new Mjesto() { Naziv = "Osijek" };

            Console.WriteLine(osoba.Mjesto.Županija?.župan??"Prazno");  //naokn ?? ide vriojedsnot koja se koristi ako je svojstvo null


            Smjer smejr = new Smjer() { naziv = "WEB progrmiranje" };
            Grzupa grupa = new () {naziv ="WP6", smjer = smejr }; //još krace


            Polaznik[] polazniciniz = new Polaznik[2];


            polazniciniz[0] = new Polaznik() { ime = "Pero" };
            polazniciniz[0] = new Polaznik() { ime = "Marija" };

            grupa.polaznici = polazniciniz;

            //ispiati podaci o grupi
            Console.WriteLine(grupa.naziv);
            Console.WriteLine(grupa.smjer.naziv);
            foreach(Polaznik p in grupa.polaznici) 
            {

                Console.WriteLine("{0} {1}", p.ime, p.prezime);
            }

            Console.WriteLine("***************************");
            grupa.detaljigrupe();
        }


   
        
       


    }
}
