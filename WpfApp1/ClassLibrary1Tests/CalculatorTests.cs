using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void FactorialTest()
        {
            ulong x = 5;
            ulong expected = 120;

            Calculator c = new Calculator();
            ulong actual = c.Factorial(x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void InputArgumentTest()
        {
            string y = "5";
            double expected = 5;
            Calculator c = new Calculator();
            c.InputArgument(y);
            Assert.AreEqual(expected, c.screenValue);
        }

        [TestMethod()]
        public void RangeCheckTest()
        {
            double x = 35000;
            bool expected = true;
            Calculator c = new Calculator();
            bool actual = c.RangeCheck(x);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void InputSignedTest()
        {
            double y = 250.7;
            double expected = -250.7;
            Calculator c = new Calculator();
            c.InputSigned();
            Assert.AreEqual(expected, y);
        }

        [TestMethod()]
        public void SendKeyTest()
        {
            string x = "1";
            string expected = "1";
            Calculator c = new Calculator();
            c.SendKey(x);
            Assert.AreEqual(expected, c.screenString);
        }

    }
}