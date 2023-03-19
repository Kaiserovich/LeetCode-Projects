using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Tests
{
    [TestClass]
    public class KataDataTests
    {
        [DataTestMethod]
        [DataRow(30,60,90)]
        [DataRow(60,60,60)]
        [DataRow(43,78,59)]
        [DataRow(10,20,150)]
        public void OtherAngleTests(int a, int b, int actual)
        {
            Assert.AreEqual(Kata.OtherAngle(a, b), actual);
        }
        [DataTestMethod]
        [DataRow(1, "Hello", 'o')]
        [DataRow(2, "Hello", 'l')]
        [DataRow(0, "", 'z')]
        public void StrCountTests(int expected, string str, char letter) =>
            Assert.AreEqual(expected, Kata.StrCount(str, letter));

        [DataTestMethod]
        [DataRow(12, 4, 3, "n = 12, x = 3, y = 4", true)]
        [DataRow(3, 3, 4, "n = 3, x = 3, y = 4", false)]
        [DataRow(8, 3, 4, "n = 8, x = 3, y = 4", false)]
        public void IsDivisibleTests(int n, int x, int y, string message, bool isFactor) =>
            Assert.AreEqual(isFactor, Kata.IsDivisible(n, x, y), message);
    }
}
