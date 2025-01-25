using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    class E21Subota
    {
        public E21Subota()
        {
            Console.WriteLine("E21Subota");
            //Izvedi();

            SlucajniBrojevi();


        }

        private void SlucajniBrojevi()
        {

            Random random = new Random();

            Console.WriteLine("Generirani slučajni brojevi:");


            for (int i = 0; i < 10; i++)
            {

                int broj = random.Next(20, 31);
                Console.WriteLine(broj);
            }

            var on = "Manuel";
            var ona = "Marta";

            var izraz =ona.Trim().ToLower()+ on.Trim().ToLower();
            Console.WriteLine(izraz);

            int[] brojevi = new int[izraz.Length];
            var ponovilose = 0;
            for (int i = 0; i < izraz.Length; i++)
            {
                ponovilose = 0;
                for (int j = 0; j < izraz.Length; j++)
                {
                    if (izraz[i] == izraz[j])
                    {
                        ponovilose++;
                    }
                }
                brojevi[i] = ponovilose;
            }
            Console.WriteLine(string.Join('|',brojevi));







        }   }

 }
