using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Tests
{
    [TestClass]
    public class IsCubeTests
    {
        [DataTestMethod]
        [DataRow(true, 1, 1)]
        [DataRow(true, 8, 2)]
        [DataRow(false, 2, 1)]
        [DataRow(false, 6, 3)]
        [DataRow(false, -8, -2)]
        [DataRow(false, 0, 0)]
        [DataRow(false, 200, 4)]
        public void IsCubeTest(bool expected, double volume, double side) =>
            Assert.AreEqual(expected, Kata.IsCube(volume, side));
    }
}
