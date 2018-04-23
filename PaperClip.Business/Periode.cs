using System;

namespace PaperClip.Business
{
    public class Periode
    {
        public TimeSpan Duur { get;  set; }
        public DateTime Begin { get;  set; }
        public DateTime Einde { get;  set; }

        protected Periode() { }

        public Periode(DateTime begin, DateTime einde)
        {
            Begin = begin;
            Einde = einde;
            Duur = einde - begin;
        }
