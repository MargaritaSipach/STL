using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Testing_Triangle;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void firstUnitTest()
        {
            double a = 3, b = 5, c = 8;
            bool expectedResult = false;
            TestedClass myTestedClass = new TestedClass();
            bool actual = myTestedClass.Triangle(a, b, c);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void secondUnitTest()
        {
            double a = 3, b = 5, c = 9;
            bool expectedResult = false;
            TestedClass myTestedClass = new TestedClass();
            bool actual = myTestedClass.Triangle(a, b, c);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void thirdUnitTest()
        {
            double a = 8, b = 8, c = 8;
            bool expectedResult = true;
            TestedClass myTestedClass = new TestedClass();
            bool actual = myTestedClass.Triangle(a, b, c);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void fourthUnitTest()
        {
            double a = 6, b = 5, c = 6;
            bool expectedResult = true;
            TestedClass myTestedClass = new TestedClass();
            bool actual = myTestedClass.Triangle(a, b, c);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void fifthUnitTest()
        {
            double a = 2, b = 1.5, c = 2.5;
            bool expectedResult = true;
            TestedClass myTestedClass = new TestedClass();
            bool actual = myTestedClass.Triangle(a, b, c);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void sixthUnitTest()
        {
            double a = 2, b = 1.5, c = 9;
            bool expectedResult = false;
            TestedClass myTestedClass = new TestedClass();
            bool actual = myTestedClass.Triangle(a, b, c);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void seventhUnitTest()
        {
            double a = 3, b = 2.5, c = 5.2;
            bool expectedResult = true;
            TestedClass myTestedClass = new TestedClass();
            bool actual = myTestedClass.Triangle(a, b, c);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void eighthUnitTest()
        {
            double a = 3, b = 2.5, c = 10;
            bool expectedResult = false;
            TestedClass myTestedClass = new TestedClass();
            bool actual = myTestedClass.Triangle(a, b, c);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void ninthUnitTest()
        {
            double a = 13, b = 5, c = 9;
            bool expectedResult = true;
            TestedClass myTestedClass = new TestedClass();
            bool actual = myTestedClass.Triangle(a, b, c);
            Assert.AreEqual(expectedResult, actual);
        }

        [TestMethod]
        public void tenthUnitTest()
        {
            double a = 4, b = 5, c = 9;
            bool expectedResult = false;
            TestedClass myTestedClass = new TestedClass();
            bool actual = myTestedClass.Triangle(a, b, c);
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
