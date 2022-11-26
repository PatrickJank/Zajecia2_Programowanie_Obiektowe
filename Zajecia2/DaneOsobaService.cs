using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zajecia2
{
    internal class DaneOsobaService
    {

        DaneOsobaCollection dane;
        public DaneOsobaService()
        {
            this.dane = new DaneOsobaCollection();
        }
        public void DodajRekord(DaneOsoba osoba)
        {
            dane.myCollection.Add(osoba);
        }
    }
}
