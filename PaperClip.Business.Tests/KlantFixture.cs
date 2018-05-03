using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaperClip.Business.Tests
{
    [TestClass]
    public class KlantFixture
    {
        [TestMethod]
        public void GeeftNaam()
        {
                var target = new Klant("Dirk", new Adres("Schoonmeersstraat 15", 9000, "Gent", "België"), VervaldagPolicy.DertigDagen,new KlantenCategorie("Beste Klant",5 ));
                var expected = "Dirk";
                Assert.AreEqual(expected, target.ToString());
            
        }
    }
}
