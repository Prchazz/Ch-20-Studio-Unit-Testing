using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;
using System;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.
        //[TestMethod]
        //public void OnlyBracketsReturnsTrue()
        //{
        //    Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        //}

        //[TestMethod]
        //public void EmptyTest()
        //{
        //    Assert.AreEqual(true, true);
        //}
        //[TestMethod]
        //public void TestInitialPhrase()
        //{
        //    string phrase = "no commmas";
        //    HasBalancedBrackets(phrase);
        //    Assert.AreEqual(false, false);
        //}

        private void HasBalancedBrackets(string phrase)
        {
           
            string phrase1 = "no commmas";
            HasBalancedBrackets(phrase1);
            Assert.AreEqual(phrase1, true);

        }

        //private void HasBalancedBrackets(string v)
        //{
        //    throw new NotImplementedException();
        //}

        [TestMethod]
        public void HasNoQuotationMarks()
        {
            string phrase = "no commmas";
            string phrase1 = "";
            BalancedBrackets.CleanWords(phrase);
            Assert.IsTrue(BalancedBrackets.CleanPhrase(phrase1(Contains(','))));
        }

        //private bool Contains(char v)
        //{
        //    throw new NotImplementedException();
        //}
        //[TestMethod]
        //public void HasNoCommas()
        //{
        //    Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        //}
    }
}
