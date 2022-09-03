using Domen;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
   

    public class KreirajNarudzbinuViewModel
    {
        
        public VrstaNarudzbine VrstaNarudzbine { get; set; }
        public string Adresa { get; set; }
       // public string StatusIsporuke { get; set; } = "Obrada";
       // public ProdajnoMesto ProdajnoMesto { get; set; }
        public int ProdajnoMestoId { get; set; }
      //  public Kupac Kupac { get; set; }
        public int KupacId { get; set; }
        public List<Stavka> Stavke { get; set; } = new List<Stavka>();
        public List<SelectListItem> ProdajnaMesta { get; set; }

    }
}
