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
        [TestMethod]
        public void NearestSqTests()
        {
            Assert.AreEqual(Kata.NearestSq(1), 1);
            Assert.AreEqual(Kata.NearestSq(2), 1);
            Assert.AreEqual(Kata.NearestSq(10), 9);
            Assert.AreEqual(Kata.NearestSq(111), 121);
            Assert.AreEqual(Kata.NearestSq(9999), 10000);
        }
        [TestMethod]
        public void IsCubeTestsShouldReturnFalse()
        {
            Assert.AreEqual(true, Kata.IsCube(1, 1));
            Assert.AreEqual(true, Kata.IsCube(8, 2));
        }
        [TestMethod]
        public void ShouldReturnTrue()
        {
            Assert.AreEqual(false, Kata.IsCube(2, 1));
            Assert.AreEqual(false, Kata.IsCube(6, 3));
            Assert.AreEqual(false, Kata.IsCube(-8, -2));
            Assert.AreEqual(false, Kata.IsCube(0, 0));
            Assert.AreEqual(false, Kata.IsCube(200, 4));
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
