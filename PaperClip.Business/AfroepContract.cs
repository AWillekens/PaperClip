using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperClip.Business
{
    public class AfroepContract
    {
        public string Naam { get; set; }
        public int Aantal { get; set; }
        public Periode Periode {get;set;}
        public decimal Afroepkorting {get;set;}
    }
}
