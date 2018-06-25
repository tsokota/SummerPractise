using NUnit.Framework;
using LabWork8;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork8.Tests
{
    [TestFixture()]
    public class TesterArrTests
    {

        [Test()]
        public void GenerateArrayTest()
        {
            TesterArr Kondor = new TesterArr();

            int expected = 10;
            Kondor.GenerateArray(10);
            int actual = Kondor.collTest.Count;

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void GenerateArrayTest1()
        {
            TesterArr Kondor = new TesterArr();

            int expected = 10;
            Kondor.GenerateArray(12);
            int actual = Kondor.collTest.Count;

            Assert.AreNotEqual(expected, actual);
        }

        [Test()]
        public void FindIndexFromIDTest()
        {
            TesterArr Kondor = new TesterArr();
            Kondor.GenerateArray(10);
            Kondor.RemoveAt(5);
            Kondor.RemoveAt(8);
            int actual = 5;
            int expected = Kondor.FindIndexFromID(7);
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void IndexOFTest()
        {
            TesterArr Kondor = new TesterArr();
            Kondor.GenerateArray(8);
            Kondor.RemoveAt(5);
            int actual = 6;
            int expected = Kondor.FindIndexFromID(7);
            Assert.AreNotEqual(expected, actual);
        }
    }
}