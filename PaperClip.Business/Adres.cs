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
        public string Gemeente { get; set; }
        public string Land { get; set; }

        public override string ToString()
        {
            return $"{Straat}{Gemeente}{Land}";
        }
    }
}
