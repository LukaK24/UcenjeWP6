using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E03Z1
    {
        public static void Izvedi();

        //program od korisnika unosi dva cijela beroja
        //program ispisuje u novim redovima 
        //1zbtoj
        //razliku druhoho i prvog 
        //umnožak
        //zbtoj kvadrata prvog i druhoho broj
        //kvocijent prvog i drugogo broja


      

class Program
    {
        static void Main()
        {
            // Unos dva cijela broja
            Console.Write("Unesite prvi broj: ");
            int prviBroj = int.Parse(Console.ReadLine());

            Console.Write("Unesite drugi broj: ");
            int drugiBroj = int.Parse(Console.ReadLine());

            // Zbroj
            int zbroj = prviBroj + drugiBroj;
            Console.WriteLine("Zbroj: " + zbroj);

            // Razlika (drugi minus prvi)
            int razlika = drugiBroj - prviBroj;
            Console.WriteLine("Razlika (drugi minus prvi): " + razlika);

            // Umnožak
            int umnozak = prviBroj * drugiBroj;
            Console.WriteLine("Umnožak: " + umnozak);

            // Zbroj kvadrata
            int zbrojKvadrata = (prviBroj * prviBroj) + (drugiBroj * drugiBroj);
            Console.WriteLine("Zbroj kvadrata: " + zbrojKvadrata);

            // Kvocijent (prvi podijeljeno s drugim)
            if (drugiBroj != 0)
            {
                double kvocijent = (double)prviBroj / drugiBroj;
                Console.WriteLine("Kvocijent: " + kvocijent);
            }
            else
            {
                Console.WriteLine("Kvocijent: Dijeljenje s nulom nije dozvoljeno.");
            }
        }
    }




}




}
