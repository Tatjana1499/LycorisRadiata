using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Osoba : IdentityUser<int>
    {
       // public int OsobaId { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
       // public string Lozinka { get; set; }
      //  public string KorisnickoIme { get; set; }
    }
}
