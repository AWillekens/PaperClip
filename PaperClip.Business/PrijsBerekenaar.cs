using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperClip.Business
{
    public class PrijsBerekenaar
    {
        
        public Factuur Factuur { get; set; }
        public double AangerekendePrijs { get; set; }
        public double SubTotaal { get; set; }
        public double TotaalExclBtw { get; set; }
        public double ToegekendeKortingen { get; set; }
        public double KortingsBedrag { get; set; }
        public double BtwBedrag { get; set; }
        public double TotaalInclBtw { get; set; }
        public double OntvangenVoorschot { get; set; }
        public double TeBetalenSaldo { get; set; }
       

        public PrijsBerekenaar(){}
        public PrijsBerekenaar( Factuur factuur, double aangerekendePrijs, double toegekendeKortingen,  double btwBedrag, double totaalExclBtw,
            double totaalInclBtw, double ontvangenVoorschot,double teBetalenSaldo)
        {
            Factuur = factuur;
            AangerekendePrijs = aangerekendePrijs;
            TotaalExclBtw = totaalExclBtw;
            ToegekendeKortingen = toegekendeKortingen;
            BtwBedrag = btwBedrag;
            TotaalInclBtw = totaalInclBtw;
            OntvangenVoorschot = ontvangenVoorschot;
            TeBetalenSaldo = teBetalenSaldo;
        }
        
        public void SoortKortingBepalen()
        {
            if (Factuur.Klant.KlantenCategorie.KortingsPercentage < Factuur.Artikel.Afroepcontract.AfroepKorting
                && Factuur.Klant.KlantenCategorie.KortingsPercentage < Factuur.Artikel.ArtikelGroep.StaffelKorting.StaffelKortingsPercentage)
            {
                ToegekendeKortingen = Factuur.Klant.KlantenCategorie.KortingsPercentage;
            }
            else if (Factuur.Artikel.Afroepcontract.AfroepKorting < Factuur.Klant.KlantenCategorie.KortingsPercentage
                     && Factuur.Artikel.Afroepcontract.AfroepKorting <
                     Factuur.Artikel.ArtikelGroep.StaffelKorting.StaffelKortingsPercentage)
            {
                ToegekendeKortingen = Factuur.Artikel.Afroepcontract.AfroepKorting;
            }
            else if (Factuur.Artikel.ArtikelGroep.StaffelKorting.StaffelKortingsPercentage < Factuur.Klant.KlantenCategorie.KortingsPercentage
                     && Factuur.Artikel.ArtikelGroep.StaffelKorting.StaffelKortingsPercentage < Factuur.Artikel.Afroepcontract.AfroepKorting)
            {
                ToegekendeKortingen = Factuur.Artikel.ArtikelGroep.StaffelKorting.StaffelKortingsPercentage;
            }
        }

        public void BerekenAangerekendePrijsPerStuk()
        {
            AangerekendePrijs = Factuur.Artikel.EenheidsPrijs * ToegekendeKortingen;
        }
        public void BerekenTotaalExclBtw()
        {
            TotaalExclBtw = AangerekendePrijs * Factuur.Artikel.Aantal;
        }

        
       public void BerekenBtwBedrag()
        {
            BtwBedrag = (TotaalExclBtw * Factuur.Artikel.BtwPercentage)/100;
        }

        public void BerekenTotaalBedrag()
        {
            TotaalInclBtw = TotaalExclBtw + BtwBedrag;
        }

        public void BerekenSaldo()
        {
            TeBetalenSaldo = TotaalInclBtw - OntvangenVoorschot;
        }
    }

    //public class PrijsBerekenaarAfroep
    //{
    //    private IAfroepRepository repository;

    //    public PrijsBerekenaarAfroep(IAfroepRepository repository, Klant klant, DateTime datum)
    //    {
    //        this.repository = repository;
    //        Klant = klant;
    //        Datum = datum;
    //    }
    //    public DateTime Datum { get; set; }
    //    public Klant Klant { get; set; }

    //    public decimal GetPrijs(Artikel artikel)
    //    {
    //        return repository
    //                   .AfroepVoorKlantArtikel(Klant, artikel, Datum)?.Prijs?? artikel.EenheidsPrijs;
    //    }
    //}
}
