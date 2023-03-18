using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Tests
{
    [TestClass]
    public class XorTests
    {
        [TestMethod]
        public void XorBasicTests()
        {
            Assert.AreEqual(Kata.Xor(false, false), false);
            Assert.AreEqual(Kata.Xor(true, false), true);
            Assert.AreEqual(Kata.Xor(false, true), true);
            Assert.AreEqual(Kata.Xor(true, true), false);
        }
        [TestMethod]
        public void XorNestedTests()
        {
            Assert.AreEqual(Kata.Xor(false, Kata.Xor(false, false)), false);
            Assert.AreEqual(Kata.Xor(Kata.Xor(true, false), false), true);
            Assert.AreEqual(Kata.Xor(Kata.Xor(true, true), false), false);
            Assert.AreEqual(Kata.Xor(true, Kata.Xor(true, true)), true);
            Assert.AreEqual(Kata.Xor(Kata.Xor(false, false), Kata.Xor(false, false)), false);
            Assert.AreEqual(Kata.Xor(Kata.Xor(false, false), Kata.Xor(false, true)), true);
            Assert.AreEqual(Kata.Xor(Kata.Xor(true, false), Kata.Xor(false, false)), true);
            Assert.AreEqual(Kata.Xor(Kata.Xor(true, false), Kata.Xor(true, false)), false);
            Assert.AreEqual(Kata.Xor(Kata.Xor(true, true), Kata.Xor(true, false)), true);
            Assert.AreEqual(Kata.Xor(Kata.Xor(true, Kata.Xor(true, true)), Kata.Xor(Kata.Xor(true, true), false)), true);
        }
    }
}
