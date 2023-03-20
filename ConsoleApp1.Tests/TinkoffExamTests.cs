using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticeConsoleApp.Kata;

namespace PracticeConsoleApp.Tests
{
    [TestClass]
    public class TinkoffExamTests
    {
        [DataTestMethod]
        [DataRow("YES", "1 2 3 4")]
        [DataRow("YES", "7 6 5 5")]
        [DataRow("YES", "4 4 4 4")]
        [DataRow("NO", "5 2 3 1")]
        public void TinkoffFirstReturnTests(string expected, string str)
        {
            Assert.AreEqual(expected, TinkoffExam.TinkoffFirstReturn(str));
        }
        [DataTestMethod]
        [DataRow(3, "3 2 2")]
        [DataRow(5, "7 3 2")]
        public void TinkoffSecondReturnTests(int expected, string str)
        {
            Assert.AreEqual(expected, TinkoffExam.TinkoffSecondReturn(str));
        }
        [DataTestMethod]
        [DataRow(7, "dbbccca")]
        [DataRow(5, "aabbccddbadd")]
        [DataRow(10, "aaaabbbbccccdddd")]
        [DataRow(-1, "abcabac")]
        public void TinkoffThirdReturnTests(int expected, string str)
        {
            Assert.AreEqual(expected, TinkoffExam.TinkoffThirdReturn(str));
        }
        [DataTestMethod]
        [DataRow(10, "1 2 3 1 2 2 3 3 3 1 4 4 5")]
        [DataRow(7, "1 2 4 2 3 1 3 9 15 23")]
        [DataRow(5, "1 2 3 4 5")]
        public void TinkoffFourthReturnTests(int expected, string str)
        {
            Assert.AreEqual(expected, TinkoffExam.TinkoffFourthReturn(str));
        }
        [DataTestMethod]
        [DataRow(3, "42 -42 42")]
        [DataRow(1, "1 2 3 -6")]
        [DataRow(6, "-1 1 2 -3 6")]
        public void TinkoffFifthReturnTests(int expected, string str)
        {
            Assert.AreEqual(expected, TinkoffExam.TinkoffFifthReturn(str));
        }
        [DataTestMethod]
        [DataRow(12, "3 27", new string [] { "11 14", "2 10" , "11 14" })]
        [DataRow(7, "7 42", new string [] { "5 5", "3 5" , "7 9", "6 7", "3 8", "10 10", "1 1" })]
        public void TinkoffSixthReturnTests(int expected, string numberStudentsAndLimitScore, string[] results)
        {
            Assert.AreEqual(expected, TinkoffExam.TinkoffSixthReturn(numberStudentsAndLimitScore, results));
        }
    }
    
}
