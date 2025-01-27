using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje.ZavrsniRadNogomet
{
    class igrac
    {
        public int sifra { get; set; }
        public string ime { get; set; } = "";
        public string prezime { get; set; } = "";
        public string pozicija { get; set; } = "";
        public string? oib { get; set; }
    }
}
