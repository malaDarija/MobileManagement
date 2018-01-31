using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileManagement.Data.Db;
using MobileManagement.Data.Helper;

namespace MobileManagement.Tests
{
    [TestClass]
    public class DecimalHelperTest
    {
        [TestMethod]
        public void ShouldReturnDjelatnikWhenPriceLessThen1000()
        {
            var price = 900m;
            Assert.AreEqual((int)DecimalHelper.GetMinimumUserType(price), (int)UserType.Djelatnik, $"Očekivana vrijednost je Djelatnik za predanu vrijednost: {price}");
        }

        [TestMethod]
        public void ShouldReturnVoditeljWhenPriceIsBetween1000And2000()
        {
            var price = 1200m;
            Assert.AreEqual((int)DecimalHelper.GetMinimumUserType(price), (int)UserType.Voditelj, $"Očekivana vrijednost je Voditelj za predanu vrijednost: {price}");
        }

        [TestMethod]
        public void ShouldReturnDjelatnikWhenPriceIsGreaterThen2000()
        {
            var price = 20100m;
            Assert.AreEqual((int)DecimalHelper.GetMinimumUserType(price), (int)UserType.Direktor, $"Očekivana vrijednost je Direktor za predanu vrijednost: {price}");
        }
    }
}
