using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaperClip.Business.Tests
{
    [TestClass]
    public class PrijsBerekenaarFixture
    {
        
        [TestMethod]
        public void TotaalExclBtw()
        {
            var target = new PrijsBerekenaar(new Factuur(1, new Klant("Dirk", new Adres("Schoonmeerstraat 15", 9000, "Gent", "België"),
                VervaldagPolicy.DertigDagen, new KlantenCategorie("Beste klant", 5)), new DateTime(2018, 4, 28), new Artikel("BIC M10 rood", 5, 2.5, 6,
                new ArtikelGroep("Balpennen", new StaffelKorting("kleine korting"))), new DateTime(2018, 5, 28)),2.5,0,0.75,12.5,13.25,0,13.25);

            target.BerekenTotaalExclBtw();
            var expected = 12.5;
            Assert.AreEqual(expected, target.TotaalExclBtw);

        }

        [TestMethod]
        public void BtwBedrag()
        {
            var target = new PrijsBerekenaar(new Factuur(1, new Klant("Dirk", new Adres("Schoonmeerstraat 15", 9000, "Gent", "België"),
                VervaldagPolicy.DertigDagen, new KlantenCategorie("Beste klant", 5)), new DateTime(2018, 4, 28), new Artikel("BIC M10 rood", 5, 2.5, 6,
                new ArtikelGroep("Balpennen", new StaffelKorting("kleine korting"))), new DateTime(2018, 5, 28)), 2.5, 0, 0.75, 12.5, 13.25, 0, 13.25);

            target.BerekenBtwBedrag();
            double expected = 0.75;

            Assert.AreEqual(expected,target.BtwBedrag);

        }
        [TestMethod]
        public void TotaalBedrag()
        {
            var target = new PrijsBerekenaar(new Factuur(1, new Klant("Dirk", new Adres("Schoonmeerstraat 15", 9000, "Gent", "België"),
                VervaldagPolicy.DertigDagen, new KlantenCategorie("Beste klant", 5)), new DateTime(2018, 4, 28), new Artikel("BIC M10 rood", 5, 2.5, 6,
                new ArtikelGroep("Balpennen", new StaffelKorting("kleine korting"))), new DateTime(2018, 5, 28)), 2.5, 0, 0.75, 12.5, 13.25, 0, 13.25);

            target.BerekenTotaalBedrag();
            double expected = 13.25;

            Assert.AreEqual(expected, target.TotaalInclBtw);
        }
        [TestMethod]
        public void Saldo()
        {
            var target = new PrijsBerekenaar(new Factuur(1, new Klant("Dirk", new Adres("Schoonmeerstraat 15", 9000, "Gent", "België"),
                VervaldagPolicy.DertigDagen, new KlantenCategorie("Beste klant", 5)), new DateTime(2018, 4, 28), new Artikel("BIC M10 rood", 5, 2.5, 6,
                new ArtikelGroep("Balpennen", new StaffelKorting("kleine korting"))), new DateTime(2018, 5, 28)), 2.5, 0, 0.75, 12.5, 13.25, 0, 13.25);

            target.BerekenSaldo();
            double expected = 13.25;

            Assert.AreEqual(expected, target.TeBetalenSaldo);
        }
    }
}
