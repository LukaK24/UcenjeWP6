using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje.E18NalijedivanjePoliformizam
{
    public class promgram
    {
        public promgram()
        {

            string s1 = "AA";

            Console.WriteLine(s1.GetHashCode()); //hascode je reprezentant memorijeske lokacije

            s1 += "BB";

            Console.WriteLine(s1.GetHashCode());

            //dosadasnja praksa s'pajanja stringova + nije dobra

            //dobra praksa je korisitti string bulider

            var sb = new StringBuilder();

            sb.Append("AA");
            Console.WriteLine(sb.GetHashCode());

            sb.Clear().Append("BB");
            Console.WriteLine(sb.GetHashCode());

            Smjer smjer1 = new Smjer() { naziv = "Web programiranje" };
            Smjer smjer2 = new Smjer() { naziv = "Web progrmiranje" };

           

        }








    }    }





