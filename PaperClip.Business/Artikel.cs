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
        public int EenheidsPrijs { get; set; }
        public int AangerekendePrijs { get; set; }
        public int BtwPercentage {get; set; }
        public int TotaalExclBtw { get; set; }
        public Artikelgroep Artikelgroep {get;set;}
        

    }
}
