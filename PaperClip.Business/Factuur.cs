using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperClip.Business
{
    public class Factuur
    {
       // public int FactuurNummer { get; set; }
        public Klant Klant { get; set; }
        public DateTime Datum { get; set; }
    

        public int GeefFactuurNummer(int factuurnummer)
        {
            return factuurnummer +=1;
        }

        public int BerekenVervaldag()
        {
            DateTime 
        }

    }

}
