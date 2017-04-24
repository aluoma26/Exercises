using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VSfirst;

namespace VSMathTest
{
    [TestClass]
    public class AddTests
    {
        [TestMethod]
        public void AddTwoPositiveNumbers()
        {
            //arrange
            var SystemUnderTest = new Program();
            int numberA = 5;
            int numberB = 6;
            int expected = 11;

            //act

            int actual = SystemUnderTest.Add(numberA, numberB);

            //assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void AddZeroes()
        {
            //arrange
            var SystemUnderTest = new Program();
            int numberA = 0;
            int numberB = 0;
            int expected = 0;

            //act

            int actual = SystemUnderTest.Add(numberA, numberB);

            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
