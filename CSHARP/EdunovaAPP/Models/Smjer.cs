using Microsoft.EntityFrameworkCore.SqlServer.Query.Internal;

namespace EdunovaAPP.Models
{
    public class Smjer: Entitet
    {
        public string naziv { get; set; } = "";
        public decimal cijena { get; set; }
        public datetime izvodseod { get; set; }
    }
}
