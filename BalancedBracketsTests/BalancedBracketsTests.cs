using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod] //1
        public void OnlyBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }


        [TestMethod] //2
        public void NoBalancedBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[LaunchCode"));
        }

        [TestMethod] //3
        public void FindMulitpleBalancedBrackets()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[][]"));
        }

        [TestMethod] //4
        public void EvenMultiBracketsInOddOrder()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[[[][]]]"));
        }

        [TestMethod] //5 .. Fail
        public void ZeroBracketsReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launchcode"));
        }

        [TestMethod] //6 
        public void ReverseBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }

        [TestMethod] //7 
        public void OddNumberCharBalancedBracket()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("]][[]"));
        }

        [TestMethod] //8 
        public void EvenNumberCharBalancedBracket()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("]][]"));
        }

        [TestMethod] //9 
        public void ReverseBracketWithText()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("Launch]Code["));
        }

        [TestMethod] //10 .. Fail
        public void EmptyStringIsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        [TestMethod] //11
        public void OneBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("["));
        }

        [TestMethod] //12
        public void MiddleTextBalancedBracket()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("Launch[Code]"));
        }
    }
}
