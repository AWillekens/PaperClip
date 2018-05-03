using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperClip.Business
{
    public class FactuurBouwer
    {

        public Klant Klant { get; set; }
        public Factuur Factuur { get; set; }
        public PrijsBerekenaar PrijsBerekenaar { get; set; }

        public override string ToString()
        {
            return $"{Klant.Naam} {Klant.Klantnummer} {Klant.Btwnummer} {Klant.Adres} {Factuur.FactuurDatum} {Factuur.FactuurNummer} {Factuur.Vervaldag} " +
                   $"{Factuur.Artikel.Aantal} {Factuur.Artikel.ArtikelOmschrijving} {Factuur.Artikel.EenheidsPrijs} {PrijsBerekenaar.AangerekendePrijs} {Factuur.Artikel.BtwPercentage} " +
                   $"{PrijsBerekenaar.TotaalExclBtw} {PrijsBerekenaar.BtwBedrag} {PrijsBerekenaar.TotaalInclBtw} {PrijsBerekenaar.OntvangenVoorschot} {PrijsBerekenaar.TeBetalenSaldo}";

        }
    }
}
