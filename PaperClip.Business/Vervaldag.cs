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
        public DateTime EindeMaand(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month));
        }
        public DateTime DertigDagen()
        {
            return DateTime.Now.AddMonths(1);
        }
        public DateTime DertigDagenEindeMaand(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month)).AddMonths(1);
        }
        public DateTime ZestigDagen()
        {
            return DateTime.Now.AddMonths(2);
        }
        public DateTime ZestigDagenEindeMaand(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month)).AddMonths(2);
        }
        public DateTime NegentigDagen()
        {
            return DateTime.Now.AddMonths(3);
        }
        public DateTime NegentigDagenEindeMaand(DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month)).AddMonths(3);
        }
    }
}
