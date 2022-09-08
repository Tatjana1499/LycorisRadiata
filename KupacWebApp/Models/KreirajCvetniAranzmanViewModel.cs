using Domen;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class KreirajCvetniAranzmanViewModel
    {
        [Required(ErrorMessage = "Obavezno polje.")]
        public string Naziv { get; set; }
        public decimal Cena { get; set; }
        public Sjaj Sjaj { get; set; }
        public Boolean Masna { get; set; }
        public Namena Namena { get; set; }
        public string Napomena { get; set; }
        public int PakovanjeId { get; set; }
        public List<SelectListItem> Pakovanja { get; set; }
        public List<CvetViewModel> Cvece { get; set; } = new List<CvetViewModel>();
        public List<DekoracijaViewModel> Dekoracije { get; set; } = new List<DekoracijaViewModel>();
    }
}