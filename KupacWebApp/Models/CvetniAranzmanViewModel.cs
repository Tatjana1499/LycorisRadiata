using Domen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class CvetniAranzmanViewModel
    {
        public string Naziv { get; set; }
        public Sjaj Sjaj { get; set; }
        public Boolean Masna { get; set; }
        public Namena Namena { get; set; }
        public string Napomena { get; set; }
        public Pakovanje Pakovanje { get; set; }
        public List<string> Cvece { get; set; } = new List<string>();
    }
}
