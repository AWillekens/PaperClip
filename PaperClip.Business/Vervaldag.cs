using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperClip.Business
{
    public class Vervaldag
    {

        //refactoren om code niet te herhalen
        public string VervaldagPolicy { get; set; }
        public int Index {get;set;}
                
        public DateTime DertigDagen()
        {
            return DateTime.Now.AddMonths(index);
        }
        public DateTime DertigDagenEindeMaand(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month)).AddMonths(index);
        }
        
    }
}
