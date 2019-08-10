using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCalcLib;

namespace MyCalcLibTests
{
    [TestClass]
    public class MyCalcTest
    {
        [TestMethod]
        public void Sum_10and20_30return()
        {
            // Arrange

            int x = 10;
            int y = 20;
            int expected = 30;
            // Act
            MyCalc c = new MyCalc();
            int actual = c.Sum(x, y);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
