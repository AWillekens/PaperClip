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
        public string ArtikelOmschrijving { get; set; }
        public int Aantal { get; set; }
        public double  EenheidsPrijs { get; set; }
        public double BtwPercentage {get; set; }
        public ArtikelGroep ArtikelGroep { get; set; }
        public AfroepContract Afroepcontract { get; set; }
        public Artikel(){}
        public Artikel(string artikelOmschrijving, int aantal, double eenheidsPrijs, double btwPercentage,  ArtikelGroep artikelgroep)
        {
            ArtikelOmschrijving= artikelOmschrijving;
            Aantal = aantal;
            EenheidsPrijs = eenheidsPrijs;
            BtwPercentage = btwPercentage;
            ArtikelGroep = artikelgroep;
        }

    }
}
