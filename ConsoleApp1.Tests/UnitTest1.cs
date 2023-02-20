using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp1;

namespace ConsoleApp1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddBinary_1and2_11returned()
        {
            Assert.AreEqual("11", Kata.AddBinary(1, 2), "Should return \"11\" for 1 + 2");
        }

        [TestMethod()]
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
        public void CompTests()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            bool r = Kata.Comp(a, b); // True
            Assert.AreEqual(true, r);
        }
        [TestMethod]
        public void FizzBuzzTests()
        {
            List<string> expected = new() { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "Buzz", "11", "Fizz", "13", "14", "FizzBuzz"};
            Assert.AreEqual(expected, Kata.FizzBuzz(15));
        }
    }
    [TestClass]
    public class PositiveSumTests
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5 },  15)]
        [DataRow(new int[] { 1, -2, 3, 4, 5 },  13)]
        [DataRow(new int[] { -1, 2, 3, 4, -5 },  9)]
        [DataRow(new int[] { }, 0)]
        [DataRow(new int[] { -1, -2, -3, -4, -5 }, 0)]
        public void PositiveSumTest(int[] arr, int expected)
        {
            Assert.AreEqual(expected, Kata.PositiveSum(arr));
        }

    }
}