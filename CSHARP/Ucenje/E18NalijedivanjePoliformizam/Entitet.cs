using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18NalijedivanjePoliformizam
{
    public class Entitet: Object 
    {
        public int sifra { get; set; }

        public override string ToString()
        {
            return sifra.ToString();
        }
    }
}
