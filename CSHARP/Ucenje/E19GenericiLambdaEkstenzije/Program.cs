using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using Ucenje.E17ClasaObjekt.Edunova;

namespace Ucenje.E19GenericiLambdaEkstenzije
{
    public class Program
    {
        public Program()
        {
            Console.WriteLine("E19");
            // problem nizova: unaprijed znati broj elemenata. Rješenje je lista

            List<int> brojevi = new List<int>();

            brojevi.Add(7);
            brojevi.Add(2);
            //brojevi.Add("2"); ne može string jer mora int

            Console.WriteLine(brojevi[1]);


            var gradovi = new List<string>();

            gradovi.Add("Osijek");
            gradovi.Add("Zadar");
            
            foreach(string grad in gradovi)
            {
                Console.WriteLine(grad);
            }

            var smjerovi = new List<Smjer>();
            smjerovi.Add(new() { Naziv = "Web programiranje" });
            smjerovi.Add(new() { Naziv = "Autolimar" });

            var s = new Smjer();
            s.Sifra = 1;
            s.Naziv = "Serviser";
            smjerovi.Add(s);

            Console.WriteLine(smjerovi[0].StariNaziv());

            var o = new Obrada<Smjer>();

            o.ObjektObrade = s;

           //  var o1 = new Obrada<string>(); ne možemo jer T u Obrada nasljeđuje Entitet

          //  o1.ObjektObrade = "s";

            foreach(var smjer in smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }

            smjerovi.Sort(); // metoda koja se oslanja na IComparable sučelje

            Console.WriteLine("*******************");
            foreach (var smjer in smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }

            smjerovi.Reverse(); // okreni na drugu stranu

            Console.WriteLine("*******************");
            foreach (var smjer in smjerovi)
            {
                Console.WriteLine(smjer.Naziv);
            }

           

            DateTime datumRodjenja = new DateTime(1990, 5, 20); // Na primjer, 20. maj 1990. godine

            // Današnji datum
            DateTime danasnjiDatum = DateTime.Now;

            // Kreiramo listu datuma
            List<DateTime> listaDatuma = new List<DateTime>
        {
            datumRodjenja,
            danasnjiDatum
        };

            // Ispisujemo datume
            foreach (var datum in listaDatuma)
            {
                Console.WriteLine(datum.ToString("dd.MM.yyyy"));
            }
            var Algoritam = (int x, int y) =>
            {
                var z = 0;
                z = ++x;
                y += z;
                return z + y + z;
            };
            Console.WriteLine(Algoritam(2,3));
        }
        //parnost broja pomoxu lambda izraza

        //ekstenzije 
        String ime = "Ana";

        var p = new Polaznik() { sifra = 7, ime = "Pero" };

        
        
    }

 
}
