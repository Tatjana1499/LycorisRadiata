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
        public Sjaj Sjaj { get; set; }
        public Boolean Masna { get; set; }
        public Namena Namena { get; set; }
        public string Napomena { get; set; }
        public int PakovanjeId { get; set; }
        public List<SelectListItem> Pakovanja { get; set; }
        public List<Cvet> Cvece { get; set; }
        [Required(ErrorMessage = "Aranzman nema cvece.")]
        public List<DekoracijaViewModel> Dekoracije { get; set; }

    }
}
