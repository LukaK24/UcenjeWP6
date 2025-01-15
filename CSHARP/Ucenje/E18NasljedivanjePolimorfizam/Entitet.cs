using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.E18NasljedivanjePolimorfizam
{

    //abstraktna klasa je ona klasa koja nemoze imati instancu
    //sluzi tome da sadrzava zajednicku svojstva i metode i te da ju netko nasljedi
    public abstract class Entitet : Object // čitati https://learn.microsoft.com/en-us/dotnet/api/system.object?view=net-9.0#methods
    {
        public int Sifra { get; set; }

        public override string ToString()
        {
            return Sifra.ToString();
        }

    }
}
