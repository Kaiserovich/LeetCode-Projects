using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Tests
{
    [TestClass]
    public class IsSquareTests
    {
        [DataTestMethod]
        [DataRow(false, -1, "negative numbers aren't square numbers")]
        [DataRow(false, 3, "3 isn't a square number")]
        [DataRow(true, 4, "4 is a square number")]
        [DataRow(true, 25, "25 is a square number")]
        [DataRow(false, 26, "26 isn't a square number")]
        public void IsSquareTest(bool expected, int n, string message) =>
            Assert.AreEqual(expected, Kata.IsSquare(n), message);
    }
}
