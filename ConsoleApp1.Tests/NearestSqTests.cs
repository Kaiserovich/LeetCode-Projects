using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Tests
{
    [TestClass]
    public class NearestSqTests
    {
        [DataTestMethod]
        [DataRow(1, 1)]
        [DataRow(2, 1)]
        [DataRow(10, 9)]
        [DataRow(111, 121)]
        [DataRow(9999, 10000)]
        public void NearestSqTest(int expected, int actual) =>
            Assert.AreEqual(Kata.NearestSq(expected), actual);
    }
}
