using NUnit.Framework;
using LabWork2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2.Tests
{
    [TestFixture()]
    public class Meth3InClassTests
    {
       
        Meth3InClass l = new Meth3InClass();

        [Test()]
        public void TestMethod1()
        {  // Дискрименант больше  0
            double
                a = 2,
                b = 10,
                c = 1;
            string X1 = null, X2 = null;

            l.Meth3InCls(a, b, c, ref X1, ref X2);
            Assert.AreEqual(X1, "-4.9");
            Assert.AreEqual(X2, "-0.1");

        }

        [Test()]
        public void TestMethod2()
        {  // Дискрименант больше  0
            double
                a = 2.77,
                b = 10.04,
                c = 1.33;
            string X1 = null, X2 = null;

            l.Meth3InCls(a, b, c, ref X1, ref X2);
            Assert.AreEqual(X1, "-3.49");
            Assert.AreEqual(X2, "-0.14");
        }

        [Test()]
        public void TestMethod3()
        {  // Дискрименант равен  0
            double
                a = 1,
                b = 4,
                c = 4;
            string X1 = null, X2 = null;

            l.Meth3InCls(a, b, c, ref X1, ref X2);
            Assert.AreEqual(X1, "-2");
            Assert.AreEqual(X2, "-2");

        }

        [Test()]
        public void TestMethod4()
        {  // Дискрименант равен  0
            double
                 a = -1,
                 b = -4,
                 c = -4;
            string X1 = null, X2 = null;

            l.Meth3InCls(a, b, c, ref X1, ref X2);
            Assert.AreEqual(X1, "-2");
            Assert.AreEqual(X2, "-2");

        }

        [Test()]
        public void TestMethod5()
        {  // Дискрименант меньше  0
            double
                a = 10,
                b = 2,
                c = 40;
            string X1 = null, X2 = null;

            l.Meth3InCls(a, b, c, ref X1, ref X2);
            Assert.AreEqual(X1, "-0.1-2i");
            Assert.AreEqual(X2, "-0.1+2i");
        }

        [Test()]
        public void TestMethod6()
        {  // Дискрименант меньше  0
            double
                a = 7.1,
                b = 5,
                c = 1;
            string X1 = null, X2 = null;

            l.Meth3InCls(a, b, c, ref X1, ref X2);
            Assert.AreEqual(X1, "-0.35-0.13i");
            Assert.AreEqual(X2, "-0.35+0.13i");
        }
    }
}