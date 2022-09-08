using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KupacWebApp.Models
{
    public class PrijavaViewModel
    {
        [Required(ErrorMessage = "*")]
        public string KorisnickoIme { get; set; }
        [Required(ErrorMessage = "*")]
        [MinLength(7, ErrorMessage = "*")]
        public string Lozinka { get; set; }
    }
}
