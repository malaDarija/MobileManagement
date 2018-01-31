using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MobileManagement.Data.Helper;

namespace MobileManagement.Tests
{
    [TestClass]
    public class StringHelperTest
    {
        [TestMethod]
        public void ShouldReturnTrueForValidEmailAddress()
        {
            var email = "darija.balen@gmail.com";
            Assert.IsTrue(email.IsValidEmail(), $"Za dani ispravni mail \"{email}\" metoda je vratila false");
        }
               

        [TestMethod]
        public void ShouldReturnFalseForValidEmailAddress()
        {
            var email = "darija.balen@com";
            Assert.IsFalse(email.IsValidEmail(), $"Za dani neispravni mail \"{email}\" metoda je vratila true");
        }
    }
}
