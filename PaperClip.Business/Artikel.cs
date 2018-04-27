using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace PaperClip.Business
{
    public class Artikel
    {
        public string ArtikelNaam { get; set; }
        public int Aantal { get; set; }
        public string Omschrijving { get; set; }
        public double  EenheidsPrijs { get; set; }
        public double AangerekendePrijs { get; set; }
        public double BtwPercentage {get; set; }
        public double TotaalPerArtikelExclBtw { get; set; }
        public ArtikelGroep ArtikelGroep { get; set; }

    }
}
