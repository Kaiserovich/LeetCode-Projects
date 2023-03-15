using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticeConsoleApp.Kata;

namespace PracticeConsoleApp.Tests
{
    [TestClass]
    public class KataTests
    {
        [TestMethod]
        public void IfTests()
        {
            var a = false;
            Kata.If(true, () => a = true, () => a = false);
            Assert.AreEqual(true, a, "func1 should be called");
        }
        [DataTestMethod]
        [DataRow(1, 1)]
        [DataRow(2, 1)]
        [DataRow(10, 9)]
        [DataRow(111, 121)]
        [DataRow(9999, 10000)]
        public void NearestSqTests(int expected, int actual)
        {
            Assert.AreEqual(Kata.NearestSq(expected), actual);
        }
        [DataTestMethod]
        [DataRow(true, 1, 1)]
        [DataRow(true, 8, 2)]
        [DataRow(false, 2, 1)]
        [DataRow(false, 6, 3)]
        [DataRow(false, -8, -2)]
        [DataRow(false, 0, 0)]
        [DataRow(false, 200, 4)]
        public void IsCubeTests(bool expected, double volume, double side)
        {
            Assert.AreEqual(expected, Kata.IsCube(volume, side));
        }
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
        [TestMethod]
        public void AddBinary_1and2_11returned()
        {
            Assert.AreEqual("11", Kata.AddBinary(1, 2), "Should return \"11\" for 1 + 2");
        }
        [TestMethod]
        public void ValidatePin_1111_trueReturned()
        {
            Assert.AreEqual(true, Kata.ValidatePin("1111"));
        }
        [TestMethod]
        public void NoGoals()
        {
            Assert.AreEqual(Kata.GetGoals(0, 0, 0), 0);
        }
        [TestMethod]
        public void FiftyEightGoals()
        {
            Assert.AreEqual(Kata.GetGoals(43, 10, 5), 58);
        }
        [TestMethod]
        public void DuplicateEncodeTests()
        {
            Assert.AreEqual("(((", Kata.DuplicateEncode("din"));
            Assert.AreEqual("()()()", Kata.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", Kata.DuplicateEncode("Success"), "should ignore case");
            Assert.AreEqual("))((", Kata.DuplicateEncode("(( @"));
        }
        [TestMethod]
        public void IsSquareTests()
        {
            Assert.AreEqual(false, Kata.IsSquare(-1), "negative numbers aren't square numbers");
            Assert.AreEqual(false, Kata.IsSquare(3), "3 isn't a square number");
            Assert.AreEqual(true, Kata.IsSquare(4), "4 is a square number");
            Assert.AreEqual(true, Kata.IsSquare(25), "25 is a square number");
            Assert.AreEqual(false, Kata.IsSquare(26), "26 isn't a square number");
        }
        [TestMethod]
        public void StrCountTests()
        {
            Assert.AreEqual(1, Kata.StrCount("Hello", 'o'));
            Assert.AreEqual(2, Kata.StrCount("Hello", 'l'));
            Assert.AreEqual(0, Kata.StrCount("", 'z'));
        }
        [TestMethod]
        public void CompTests()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            bool r = Kata.Comp(a, b); // True
            Assert.AreEqual(true, r);
        }
        [DataTestMethod]
        [DataRow(12, 4, 3, "n = 12, x = 3, y = 4", true)]
        [DataRow(3, 3, 4, "n = 3, x = 3, y = 4", false)]
        [DataRow(8, 3, 4, "n = 8, x = 3, y = 4", false)]
        public void IsDivisibleTests(int n,int x,int y, string message, bool isFactor)
        {
            Assert.AreEqual(isFactor, Kata.IsDivisible(n, x, y), message);
        }
        [TestMethod]
        public void CountSheepsTest()
        {
            var sheeps = new bool[] { true, false, true };

            Assert.AreEqual(2, Kata.CountSheeps(sheeps));
        }
    }
    
}
