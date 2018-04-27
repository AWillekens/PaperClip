using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperClip.Business
{
    public interface IAfroepRepository
    {
        AfroepContract AfroepVoorKlantArtikel(Klant klant, Artikel artikel, DateTime datum);
    }
}
