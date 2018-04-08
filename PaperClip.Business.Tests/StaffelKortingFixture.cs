using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaperClip.Business.Tests
{
    [TestClass]
    public class StaffelKortingFixture
    {
        private StaffelKorting brol;

        [TestInitialize]
        public void Init()
        {
            brol = new StaffelKorting("Brol");
            brol.NieuwItem(20, 20.0);
            brol.NieuwItem(100, 30.0);
            brol.NieuwItem(200, 45.0);
        } 
        [TestMethod]
        public void TestNaam()
        {
            const string expected = "Leeg";
            var target = new StaffelKorting(expected);
            Assert.AreEqual(expected, target.Naam);
        }

        [TestMethod]
        public void AantalKleinerEenNietGeldig()
        {
            var target = new StaffelKorting("Leeg");
            Assert.IsFalse(target.IsGeldigItem(0, 5.0));
            Assert.IsFalse(target.IsGeldigItem(-1, 5.0));
            Assert.IsTrue(target.IsGeldigItem(1, 5.0));
        }


        [TestMethod]
        public void KortingGroterOfGelijkNul()
        {
            var target = new StaffelKorting("Leeg");
            Assert.IsFalse(target.IsGeldigItem(1, -0.003));
            Assert.IsTrue(target.IsGeldigItem(1, 0.0));
            Assert.IsTrue(target.IsGeldigItem(1, 0.003));
        }

        [TestMethod]
        public void KortingVoorExactAantal()
        {
            var expected1 = 20.0;
            var expected2 = 30.0;
            var expected3 = 45.0;
            Assert.AreEqual(expected1, brol.KortingVoorAantal(20));
            Assert.AreEqual(expected2, brol.KortingVoorAantal(100));
            Assert.AreEqual(expected3, brol.KortingVoorAantal(200));
        }

        [TestMethod]
        public void KleinerDanKleinsteGeeft()
        {
            Assert.AreEqual(0.0, brol.KortingVoorAantal(1));
        }

        [TestMethod]
        public void TussenTweeAantallen()
        {
            Assert.AreEqual(20.0, brol.KortingVoorAantal(50));
            Assert.AreEqual(30.0, brol.KortingVoorAantal(150));
        }

        [TestMethod]
        public void HogerDanHoogste()
        {
            Assert.AreEqual(45.0, brol.KortingVoorAantal(500));
        }
        [TestMethod]
        public void ReverseToevoegen()
        {
            var target = new StaffelKorting("Reverse");
            target.NieuwItem(200, 45.0);
            target.NieuwItem(100,30.0);
            target.NieuwItem(20, 20.0);
            Assert.AreEqual(20.0, target.KortingVoorAantal(20));
            Assert.AreEqual(30.0, target.KortingVoorAantal(100));
            Assert.AreEqual(45.0, target.KortingVoorAantal(200));
            Assert.AreEqual(0.0, target.KortingVoorAantal(5));
            Assert.AreEqual(20.0, target.KortingVoorAantal(50));
            Assert.AreEqual(30.0, target.KortingVoorAantal(150));
            Assert.AreEqual(45.0, target.KortingVoorAantal(500));

        }
    }
}
