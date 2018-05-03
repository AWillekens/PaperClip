using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperClip.Business
{
    public class Klant
    {
        public string Naam { get; set; }
        public int Klantnummer { get; set; }
        public string Btwnummer { get; set; }

        public Adres Adres { get; set; } = new Adres();
        public VervaldagPolicy VervaldagPolicy { get; set;}
        public KlantenCategorie KlantenCategorie { get; set; }

        public Klant(){}

        public Klant(string naam, Adres adres, VervaldagPolicy vervaldagPolicy, KlantenCategorie klantenCategorie)
        {
            Naam = naam;
            Adres = adres;
            VervaldagPolicy = vervaldagPolicy;
            KlantenCategorie = klantenCategorie;

        }

        public override string ToString()
        {
            return Naam;
        }
    }
}
