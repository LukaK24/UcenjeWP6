using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class Proba
    {

        public static void Izvedi()
        {

            Console.Write("Unesi broj redova: ");
            int redovi = int.Parse(Console.ReadLine());

            Console.Write("Unesi broj stupaca:");
            int stupci = int.Parse(Console.ReadLine());

            int[,] array = new int[redovi, stupci];
            int trenutniBroj = 1;
            int minVrijednostReda = 0;
            int maxVrijednostReda = redovi - 1;
            int minVrijednostStupca = 0;
            int maxVrijednostStupca = stupci - 1;

            while (trenutniBroj <= redovi * stupci)
            {

                for (int i = maxVrijednostStupca; i >= minVrijednostStupca && trenutniBroj <= stupci * redovi; i--)
                {
                    array[maxVrijednostReda, i] = trenutniBroj++;
                }
                maxVrijednostReda--;

                for (int i = maxVrijednostReda; i >= minVrijednostReda && trenutniBroj <= stupci * redovi; i--)
                {
                    array[i, minVrijednostStupca] = trenutniBroj++;
                }
                minVrijednostStupca++;

                for (int i = minVrijednostStupca; i <= maxVrijednostStupca && trenutniBroj <= stupci * redovi; i++)
                {
                    array[minVrijednostReda, i] = trenutniBroj++;
                }
                minVrijednostReda++;

                for (int i = minVrijednostReda; i <= maxVrijednostReda && trenutniBroj <= redovi * stupci; i++)
                {
                    array[i, maxVrijednostStupca] = trenutniBroj++;
                }
                maxVrijednostStupca--;
            }

            for (int i = 0; i < redovi; i++)
            {
                for (int j = 0; j < stupci; j++)
                {
                    Console.Write(array[i, j].ToString().PadLeft(4));
                }
                Console.WriteLine();
            }
        }
    }    }
