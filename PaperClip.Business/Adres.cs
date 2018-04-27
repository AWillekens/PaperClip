using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperClip.Business
{
    public class Adres
    {
        public string Straat { get; set; }
        public int Postcode { get; set; }
        public string Gemeente { get; set; }
        public string Land { get; set; }

       

        public Adres() { }

        public Adres(string straat,int postcode, string gemeente, string land)
        {
            Straat = straat;
            Postcode = postcode;
            Gemeente = gemeente;
            Land = land;

        }
        public override string ToString()
        {
            return $"{Straat} {Postcode} {Gemeente} {Land}";
        }
    }
}
