using NUnit.Framework;
using lab4_TP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_TP.Tests
{
    [TestFixture()]
    public class UnitTest1
    {
        [Test]
        public void PrimitNum_test()
        {
            Matrix matrix = new Matrix();
            matrix.matrix = new int[4, 4] { {4, 2, 4, 0 }, { 3, 0, 4, 1},
                                          { 1, 3, 4, 0 }, { 4, 0, 1, 0} };
            matrix.size = 4;
            matrix.PrimitiveNumbers();
            int expected = 3;
            Assert.AreEqual(expected, matrix.primitNumbers);
        }


        [Test]
        public void DataIndex_test()
        {
            Matrix matrix = new Matrix();
            matrix.matrix = new int[4, 4] { {4, 3, 4, 1}, { 4, 2, 4, 0},
                                          { 3, 1, 4, 0 }, { 1, 0, 1, 0} };
            matrix.size = 4;
            matrix.SearchDataIndexs(2);
            int[] expectedI = new int[1] { 1 };
            int[] expectedj = new int[1] { 1 };
            Assert.AreEqual(expectedI[0], matrix.indexI[0]);
            Assert.AreEqual(expectedj[0], matrix.indexJ[0]);
        }
    }
}