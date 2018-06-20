using NUnit.Framework;
using ClassOper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassOper.Tests
{
    [TestFixture()]
    public class ClassOperationsTests
    {
        ClassOperations l = new ClassOperations();

        [Test()]
        public void TestMethod11()
        {  // оперция 1
            l.Mass = new int[] { 12, 6, -6, 15, 25, 6, -6, 23, 28, 16 };
            l.Oper1(5);
            Assert.True(l.Summ1 == 0);
            Assert.True(l.Summ2 == 66);
        }

        [Test()]
        public void TestMethod12()
        {  // оперция 1
            l.Mass = new int[] { 0, 2, 0, 4, 0, 2, 0, 4, 0, 2 };
            l.Oper1(3);
            Assert.True(l.Summ1 == 6);
            Assert.True(l.Summ2 == 8);
        }

        [Test()]
        public void TestMethod21()
        {  // оперция 2
            l.Mass = new int[] { 4, -4, 5, -5, 6, -6, 7, -7, 8, -8 };
            l.Oper2();
            Array.Sort(l.Mass);
            for (int i = 0; i < l.MassAft.Length; i++)
                Assert.True(l.MassAft[i] == l.Mass[i]);
        }



        [Test()]
        public void TestMethod31()
        {  // оперция 3
            l.Mass = new int[] { 12, 6, -6, 15, 25, 6, -6, 23, 28, 16 };
            l.Oper3(5, 20);
            Assert.True(l.Summ1 == 64);
            Assert.True(l.Num == 5);
        }

        [Test()]
        public void TestMethod32()
        {  // оперция 3
            l.Mass = new int[] { 12, 6, -6, 15, 25, 6, -6, 23, 28, 16 };
            l.Oper3(-10, 30);
            Assert.True(l.Summ1 == 0);
            Assert.True(l.Num == 0);
        }

        [Test()]
        public void TestMethod41()
        {  // оперция 4
            l.Mass = new int[] { 12, 6, -6, 15, 25, 6, -6, 23, 28, 16 };
            l.Oper4();
            string Tmp = $"{l.Sr:0.##}";
            Assert.True(Tmp == "11,9");
            Tmp = $"{l.D:0.##}";
            Assert.True(Tmp == "143,43");
        }

        [Test()]
        public void TestMethod42()
        { // оперция 4
            l.Mass = new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 };
            l.Oper4();
            string Tmp = $"{l.Sr:0.##}";
            Assert.True(Tmp == "1");
            Tmp = $"{l.D:0.##}";
            Assert.True(Tmp == "0");
        }
    }

}