using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Tests
{
    [TestClass]
    public class PositiveSumTests
    {
        [DataTestMethod]
        [DataRow(new int[] { 1, 2, 3, 4, 5 }, 15)]
        [DataRow(new int[] { 1, -2, 3, 4, 5 }, 13)]
        [DataRow(new int[] { -1, 2, 3, 4, -5 }, 9)]
        [DataRow(new int[] { }, 0)]
        [DataRow(new int[] { -1, -2, -3, -4, -5 }, 0)]
        public void PositiveSumTest(int[] arr, int expected)
        {
            Assert.AreEqual(expected, Kata.PositiveSum(arr));
        }
    }
}
