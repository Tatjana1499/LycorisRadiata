using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    public class Dekoracija
    {
        public Cvet Cvet { get; set; }
        public CvetniAranzman CvetniAranzman { get; set; }
        public int CvetProizvodId { get; set; }
        public int CvetniAranzmanProizvodId { get; set; }
        public int BrojCvetova { get; set; }
    }
}
