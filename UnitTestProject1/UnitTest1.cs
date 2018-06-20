using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassOper;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        ClassOperations l = new ClassOperations();

        [TestMethod]
        public void TestMethod11()
        {  // оперция 1
            l.Mass = new int[] { 12, 6, -6, 15, 25, 6, -6, 23, 28, 16 };
            l.Oper1(5);
            Assert.AreEqual(l.Summ1, 0);
            Assert.AreEqual(l.Summ2, 66);
        }

        [TestMethod]
        public void TestMethod12()
        {  // оперция 1
            l.Mass = new int[] { 0, 2, 0, 4, 0, 2, 0, 4, 0, 2 };
            l.Oper1(3);
            Assert.AreEqual(l.Summ1, 6);
            Assert.AreEqual(l.Summ2, 8);
        }

        [TestMethod]
        public void TestMethod21()
        {  // оперция 2
            l.Mass = new int[] { 4, -4, 5, -5, 6, -6, 7, -7, 8, -8 };
            l.Oper2();
            Array.Sort(l.Mass);
            for (int i = 0; i < l.MassAft.Length; i++)
                Assert.AreEqual(l.MassAft[i], l.Mass[i]);
        }

        [TestMethod]
        public void TestMethod22()
        {  // оперция 2
            l.Mass = new int[] { 0, 0, 0 };
            l.Oper2();
            for (int i = 0; i < l.MassAft.Length; i++)
                Assert.AreNotEqual(l.MassAft[i], 1);
        }

        [TestMethod]
        public void TestMethod31()
        {  // оперция 3
            l.Mass = new int[] { 12, 6, -6, 15, 25, 6, -6, 23, 28, 16 };
            l.Oper3(5, 20);
            Assert.AreEqual(l.Summ1, 64);
            Assert.AreEqual(l.Num, 5);
        }

        [TestMethod]
        public void TestMethod32()
        {  // оперция 3
            l.Mass = new int[] { 12, 6, -6, 15, 25, 6, -6, 23, 28, 16 };
            l.Oper3(-10, 30);
            Assert.AreEqual(l.Summ1, 0);
            Assert.AreEqual(l.Num, 0);
        }

        [TestMethod]
        public void TestMethod41()
        {  // оперция 4
            l.Mass = new int[] { 12, 6, -6, 15, 25, 6, -6, 23, 28, 16 };
            l.Oper4();
            string Tmp = $"{l.Sr:0.##}";
            Assert.AreEqual(Tmp, "11,9");
            Tmp = $"{l.D:0.##}";
            Assert.AreEqual(Tmp, "143,43");
        }

        [TestMethod]
        public void TestMethod42()
        { // оперция 4
            l.Mass = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            l.Oper4();
            string Tmp = $"{l.Sr:0.##}";
            Assert.AreEqual(Tmp, "1");
            Tmp = $"{l.D:0.##}";
            Assert.AreEqual(Tmp, "0");
        }
    }
}
