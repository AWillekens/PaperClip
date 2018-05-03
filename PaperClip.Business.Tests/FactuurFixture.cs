using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaperClip.Business.Tests
{
    [TestClass]
    public class FactuurFixture
    {
        private DateTime dateTime;

        [TestMethod]
        public void OplopendFactuurNummer()
        {
            var target = new Factuur(1, new Klant("Dirk", new Adres("Schoonmeerstraat 15", 9000, "Gent", "België"),
                VervaldagPolicy.DertigDagen,new KlantenCategorie("Beste klant", 5)),new DateTime(2018,4,28),new Artikel("BIC M10 rood",5,2.5,6,
                new ArtikelGroep("Balpennen", new StaffelKorting("kleine korting"))),new DateTime(2018,5,28));

            target.VerhoogFactuurNummer();

            int expected = 2;

            Assert.AreEqual(expected, target.FactuurNummer);
        }
        [TestMethod]
        public void ControleerFactuurDatum()
        {
            var target = new Factuur(1, new Klant("Dirk", new Adres("Schoonmeersstraat 15", 9000, "Gent", "België"),
                VervaldagPolicy.DertigDagen, new KlantenCategorie("Beste Klant", 5)),
                DateTime.Today,
                new Artikel("balpen Bic M10 blauw", 5, 2.5, 6, new ArtikelGroep("Balpennen", new StaffelKorting("kleine korting"))), DateTime.Today);

            target.BerekenFactuurDatum();

            var expected = DateTime.Today;

            Assert.AreEqual(expected, target.FactuurDatum);

        }
        [TestMethod]
        public void ControleerVervaldagDertigDagen()
        {
            var factuurDatum = new DateTime(2018,04,28);
            var target = new Factuur(1, new Klant("Dirk", new Adres("Schoonmeersstraat 15", 9000, "Gent", "België"),
                VervaldagPolicy.DertigDagen, new KlantenCategorie("Beste Klant", 5)),
                new DateTime(2018, 04, 28),
                new Artikel("balpen Bic M10 blauw", 5, 2.5, 6, new ArtikelGroep("Balpennen",
                new StaffelKorting("kleine korting"))),  DateTime.Today.AddMonths(1));

            var expected = new DateTime(2018, 5, 28);
            
            Assert.AreEqual(expected, target.BerekenVervaldag());
        }
        [TestMethod]
        public void ControleerVervaldagZestigDagen()
        {
            var target = new Factuur(1, new Klant("Dirk", new Adres("Schoonmeersstraat 15", 9000, "Gent", "België"),
                VervaldagPolicy.ZestigDagen, new KlantenCategorie("Beste Klant", 5)),
                new DateTime(2018, 04, 28),
                new Artikel("balpen Bic M10 blauw", 5, 2.5, 6, new ArtikelGroep("Balpennen",
                new StaffelKorting("kleine korting"))), DateTime.Today.AddMonths(2));

            //target.BerekenVervaldag(new DateTime(2018, 04, 28));
            var expected = new DateTime(2018, 6, 28);

            Assert.AreEqual(expected, target.BerekenVervaldag());
        }
        [TestMethod]
        public void ControleerVervaldagNegentigDagen()
        {
            var target = new Factuur(1, new Klant("Dirk", new Adres("Schoonmeersstraat 15", 9000, "Gent", "België"),
                VervaldagPolicy.NegentigDagen, new KlantenCategorie("Beste Klant", 5)),
                new DateTime(2018, 04, 28),
                new Artikel("balpen Bic M10 blauw", 5, 2.5, 6, new ArtikelGroep("Balpennen",
                new StaffelKorting("kleine korting"))), DateTime.Today.AddMonths(3));

            //target.BerekenVervaldag(new DateTime(2018, 04, 28));
            var expected = new DateTime(2018, 7, 28);

            Assert.AreEqual(expected, target.BerekenVervaldag());
        }
        [TestMethod]
        public void ControleerVervaldagDertigDagenEindeMaand()
        {

            var target = new Factuur(1, new Klant("Dirk", new Adres("Schoonmeersstraat 15", 9000, "Gent", "België"),
                VervaldagPolicy.DertigDagenEindeMaand, new KlantenCategorie("Beste Klant", 5)),
                new DateTime(2018, 04, 28),
                new Artikel("balpen Bic M10 blauw", 5, 2.5, 6, new ArtikelGroep("Balpennen",
                new StaffelKorting("kleine korting"))),
                new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month)).AddMonths(1));

            //target.BerekenVervaldag(new DateTime(2018, 04, 28));
            var expected = new DateTime(2018, 5, 31);

            Assert.AreEqual(expected, target.BerekenVervaldag());
        }
        [TestMethod]
        public void ControleerVervaldagZestigDagenEindeMaand()
        {

            var target = new Factuur(1, new Klant("Dirk", new Adres("Schoonmeersstraat 15", 9000, "Gent", "België"),
                VervaldagPolicy.ZestigDagenEindeMaand, new KlantenCategorie("Beste Klant", 5)),
                new DateTime(2018, 04, 28),
                new Artikel("balpen Bic M10 blauw", 5, 2.5, 6, new ArtikelGroep("Balpennen",
                new StaffelKorting("kleine korting"))),
                new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month)).AddMonths(2));

            //target.BerekenVervaldag(new DateTime(2018, 04, 28));
            var expected = new DateTime(2018, 6, 30);

            Assert.AreEqual(expected, target.BerekenVervaldag());
        }
        [TestMethod]
        public void ControleerVervaldagNegentigDagenEindeMaand()
        {

            var target = new Factuur(1, new Klant("Dirk", new Adres("Schoonmeersstraat 15", 9000, "Gent", "België"),
                VervaldagPolicy.NegentigDagenEindeMaand, new KlantenCategorie("Beste Klant", 5)),
                new DateTime(2018, 04, 28),
                new Artikel("balpen Bic M10 blauw", 5, 2.5, 6, new ArtikelGroep("Balpennen",
                new StaffelKorting("kleine korting"))),
                new DateTime(dateTime.Year, dateTime.Month, DateTime.DaysInMonth(dateTime.Year, dateTime.Month)).AddMonths(3));

            //target.BerekenVervaldag(new DateTime(2018, 04, 28));
            var expected = new DateTime(2018, 7, 31);

            Assert.AreEqual(expected, target.BerekenVervaldag());
        }
        [TestMethod]
        public void ControleerOpFebruariVervaldagDertigDagen()
        {
            var target = new Factuur(1, new Klant("Dirk", new Adres("Schoonmeersstraat 15", 9000, "Gent", "België"),
                    VervaldagPolicy.DertigDagen, new KlantenCategorie("Beste Klant", 5)),
                new DateTime(2018, 01, 31),
                new Artikel("balpen Bic M10 blauw", 5, 2.5, 6, new ArtikelGroep("Balpennen",
                    new StaffelKorting("kleine korting"))), DateTime.Today.AddMonths(1));

            //target.BerekenVervaldag(new DateTime(2018, 1, 31));
            var expected = new DateTime(2018, 2, 28);

            Assert.AreEqual(expected, target.BerekenVervaldag());
        }


    }
}
