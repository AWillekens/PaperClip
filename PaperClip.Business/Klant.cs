﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaperClip.Business
{
    public class Klant
    {
        public string Naam { get; set; }
        public int Klantnummer { get; set; }
        public string Btwnummer { get; set; }
        public Adres Adres { get; protected set; } = new Adres();
        public Vervaldag Vervaldag { get; set;}
        public KlantenCategorie KlantenCategorie { get; set; }


    }
