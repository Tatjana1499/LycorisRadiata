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
        [Required(ErrorMessage = "*")]
        public string Naziv { get; set; }
        //[Required(ErrorMessage = "*")]
        //public decimal Cena { get; set; }
        [Required(ErrorMessage = "*")]
        public Sjaj Sjaj { get; set; }
        [Required(ErrorMessage = "*")]
        public Boolean Masna { get; set; }
        [Required(ErrorMessage = "*")]
        public Namena Namena { get; set; }
        public string Napomena { get; set; }
        [Required(ErrorMessage = "*")]
        public int PakovanjeId { get; set; }
        public List<SelectListItem> Pakovanja { get; set; }
        public List<CvetViewModel> Cvece { get; set; } = new List<CvetViewModel>();
        public List<DekoracijaViewModel> Dekoracije { get; set; } = new List<DekoracijaViewModel>();
    }
}