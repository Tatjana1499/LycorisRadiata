using Domen;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
   

    public class KreirajNarudzbinuViewModel
    {
        [Required(ErrorMessage ="*")]
        public VrstaNarudzbine VrstaNarudzbine { get; set; }

        public string Adresa { get; set; }
        public int? ProdajnoMestoId { get; set; }
        [Required(ErrorMessage = "*")]
        public int KupacId { get; set; }
        public List<StavkaViewModel> Stavke { get; set; } = new List<StavkaViewModel>();
        public List<SelectListItem> ProdajnaMesta { get; set; }
        public List<ProizvodViewModel> Proizvodi { get; set; } = new List<ProizvodViewModel>();
    }
}
