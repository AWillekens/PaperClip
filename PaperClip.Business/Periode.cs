using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperClip.Business
{
    public class Periode
    {
        public DateTime Begin { get; set; }
        public DateTime Einde { get; set; }
        public TimeSpan Duur { get; set;  }

        public Periode() { }

        public Periode(DateTime begin, DateTime einde)
        {
            Begin = begin;
            Einde = einde;
            Duur = einde - begin;
        }
    }
}
