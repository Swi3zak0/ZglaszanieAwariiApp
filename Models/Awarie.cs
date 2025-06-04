using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZglaszanieAwariiApp.Models
{
    public class Awarie
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public string Kategoria { get; set; }
        public DateTime DataZgloszenia { get; set; }
        public StatusAwarii Status { get; set; }
        public Uzytkownik Zglaszajacy { get; set; }
    }
}
