using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperClip.Business
{
    public class ArtikelGroep
    {
        public string Naam { get; set; }
        public Artikel Artikel { get; set; }
        public StaffelKorting StaffelKorting { get; set; }
    }
}
