using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlojPristupaPodacima
{
    public interface IRepozitorijum<TEntitet> where TEntitet : class
    {
        public void Dodaj(TEntitet entitet );
        public void Brisi(TEntitet entitet);
        public List<TEntitet> Pretraga(Func<TEntitet, bool> uslov);
        public List<TEntitet> VratiSve();
        public void Azuriraj(TEntitet entitet);

    }
}
