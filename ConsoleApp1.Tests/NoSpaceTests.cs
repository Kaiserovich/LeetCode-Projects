using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeConsoleApp.Tests
{
    [TestClass]
    public class NoSpaceTests
    {
        [DataTestMethod]
        [DataRow("8j8mBliB8gimjB8B8jlB", "8 j 8   mBliB8g  imjB8B8  jl  B")]
        [DataRow("88Bifk8hB8BB8BBBB888chl8BhBfd", "8 8 Bi fk8h B 8 BB8B B B  B888 c hl8 BhB fd")]
        [DataRow("8aaaaaddddr", "8aaaaa dddd r     ")]
        public void NoSpaceTest(string expected, string actual) =>
            Assert.AreEqual(expected, Kata.NoSpace(actual));
    }
}
