using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperClip.Business
{
    public class KlantenCategorie
    {
        public string Naam { get; set; }
        public int KortingsPercentage { get; set; }

        public KlantenCategorie(string naam, int kortingsPercentage)
        {
            Naam = naam;
            KortingsPercentage = kortingsPercentage;
        }
    }
}
