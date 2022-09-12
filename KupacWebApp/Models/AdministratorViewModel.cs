using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class AdministratorViewModel
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string KorisnickoIme { get; set; }
        public DateTime DatumZaposlenja { get; set; }
        public string SifraZaposlenog { get; set; }
    }
}
