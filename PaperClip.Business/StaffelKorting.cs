using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperClip.Business
{
    public class StaffelKorting
    {
        private SortedSet<StaffelKortingItem> _Items = new SortedSet<StaffelKortingItem>();
        

        public StaffelKorting(string naam)
        {
            Naam = naam;
        }

        public string Naam { get; set; }
        public double StaffelKortingsPercentage { get; set; }

        public void NieuwItem(int aantal, double korting)
        {
            if (!IsGeldigItem(aantal, korting))
                throw new InvalidOperationException($"Geen geldige korting {aantal} => {korting}");
            _Items.Add(new StaffelKortingItem(aantal, korting));
        }

        public bool IsGeldigItem(int aantal, double korting)
        {
            return aantal > 0 && korting >= 0.0;
        }

        public double KortingVoorAantal(int aantal) => _Items.LastOrDefault(i => i.Aantal <= aantal)?.Korting ?? 0.0;
    }


    public class StaffelKortingItem : IComparable<StaffelKortingItem>
    {
        internal StaffelKortingItem(int aantal, double korting)
        {
            Aantal = aantal;
            Korting = korting;
        }

        public int Aantal { get; }
        public double Korting { get; }

        public int CompareTo(StaffelKortingItem other)
        {
            return Aantal - other.Aantal;
        }

        public override string ToString()
        {
            return $"{nameof(Aantal)}:{Aantal}=>{nameof(Korting)}{Korting}";
        }

    }
}