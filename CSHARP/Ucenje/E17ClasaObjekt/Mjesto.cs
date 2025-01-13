namespace Ucenje.E17ClasaObjekt
{
    public class Mjesto
    {
        public string Naziv { get; set; } = "";
        public string Postanskibroj { get; set; } = ""; //sada svojstvo nije null nego prazno

        public Županija Županija { get; set; }
    }
}