using Domen;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class DekoracijaViewModel
    {
        public int RedniBroj { get; set; }
        public string Boja { get; set; }
        public string Naziv { get; set; }
        public int CvetProizvodId { get; set; }
        [Range(1,30, ErrorMessage = "Broj cvetova nije u odgovarajucem opsegu.")]
        public int BrojCvetova { get; set; } = 1;
    }
}
