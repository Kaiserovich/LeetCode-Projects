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
        public void AddBinary_1and2_11returned() =>
            Assert.AreEqual("11", Kata.AddBinary(1, 2), "Should return \"11\" for 1 + 2");

        [TestMethod]
        public void ValidatePin_1111_trueReturned() =>
            Assert.AreEqual(true, Kata.ValidatePin("1111"));

        [TestMethod]
        public void NoGoals() =>
            Assert.AreEqual(Kata.GetGoals(0, 0, 0), 0);

        [TestMethod]
        public void FiftyEightGoals() =>
            Assert.AreEqual(Kata.GetGoals(43, 10, 5), 58);

        [TestMethod]
        public void DuplicateEncodeTests()
        {
            Assert.AreEqual("(((", Kata.DuplicateEncode("din"));
            Assert.AreEqual("()()()", Kata.DuplicateEncode("recede"));
            Assert.AreEqual(")())())", Kata.DuplicateEncode("Success"), "should ignore case");
            Assert.AreEqual("))((", Kata.DuplicateEncode("(( @"));
        }
        [TestMethod]
        public void CountSheepsTest()
        {
            var sheeps = new bool[] { true, false, true };
            Assert.AreEqual(2, Kata.CountSheeps(sheeps));
        }
        [TestMethod]
        public void CompTests()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            bool r = Kata.Comp(a, b);
            Assert.AreEqual(true, r);
        }
    }
    
}
