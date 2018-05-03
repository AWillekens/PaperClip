using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperClip.Business
{
    public class Factuur
    {
        public int FactuurNummer { get; set; }
        public Klant Klant { get; set; }
        public DateTime FactuurDatum { get; set; }
        public DateTime Vervaldag { get; set; }
        public Artikel Artikel { get; set; }
        
        

        public Factuur(){}

        public Factuur(int factuurNummer, Klant klant, DateTime factuurDatum, Artikel artikel,  DateTime vervaldag )
        {
            FactuurNummer = factuurNummer;
            Klant = klant;
            FactuurDatum = factuurDatum;
            Artikel = artikel;
            Vervaldag = vervaldag;
        }

        public void VerhoogFactuurNummer()
        {
            FactuurNummer++;
        }

        public DateTime BerekenFactuurDatum()
        {
           return FactuurDatum = DateTime.Today;
        }

        //refactoring om code niet te herhalen
        public DateTime BerekenVervaldag()
        {
            if (Klant.VervaldagPolicy == VervaldagPolicy.DertigDagen)
            {
                Vervaldag = FactuurDatum.AddMonths(1);
            }
            else if (Klant.VervaldagPolicy == VervaldagPolicy.DertigDagenEindeMaand)
            {
                DateTime volgendeMaand = FactuurDatum.AddMonths(1);
                int dagenInMaand = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar.GetDaysInMonth(volgendeMaand.Year, volgendeMaand.Month);
                Vervaldag = new DateTime(volgendeMaand.Year, volgendeMaand.Month, dagenInMaand);
            }
            else if (Klant.VervaldagPolicy == VervaldagPolicy.ZestigDagen)
            {
                Vervaldag = FactuurDatum.AddMonths(2);
            }
            else if (Klant.VervaldagPolicy == VervaldagPolicy.ZestigDagenEindeMaand)
            {
                DateTime volgendeMaand = FactuurDatum.AddMonths(2);
                int dagenInMaand = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar.GetDaysInMonth(volgendeMaand.Year, volgendeMaand.Month);
                Vervaldag = new DateTime(volgendeMaand.Year, volgendeMaand.Month, dagenInMaand);
            }
            else if (Klant.VervaldagPolicy == VervaldagPolicy.NegentigDagen)
            {
                Vervaldag = FactuurDatum.AddMonths(3);
            }
            else if (Klant.VervaldagPolicy == VervaldagPolicy.NegentigDagenEindeMaand)
            {
                DateTime volgendeMaand = FactuurDatum.AddMonths(3);
                int dagenInMaand = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar.GetDaysInMonth(volgendeMaand.Year, volgendeMaand.Month);
                Vervaldag = new DateTime(volgendeMaand.Year, volgendeMaand.Month, dagenInMaand);
            }

            return Vervaldag;
        }
    }
}
