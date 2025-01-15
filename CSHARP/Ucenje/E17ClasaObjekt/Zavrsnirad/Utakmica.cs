using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E17ClasaObjekt.Zavrsnirad
{
    public class Utakmica
    {
        public int sifra { get; set; }
        public DateTime datum { get; set; }
        public TimeOnly vrijeme { get; set; }
        public string domaci_klub { get; set; }
        public string gostujuci_klub { get; set; }
        
    }
}
