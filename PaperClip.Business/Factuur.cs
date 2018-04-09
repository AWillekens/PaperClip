using System;
using System.Collections.Generic;
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
        public Vervaldag Vervaldag { get; set; }

        public Factuur(int factuurNummer)
        {
            FactuurNummer = factuurNummer;
        }
    
        public int GeefFactuurNummer(int factuurNummer)
        {
            return factuurNummer +=1;
        }

     
    }

}
