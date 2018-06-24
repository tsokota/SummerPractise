using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Diagrams_lab5_;
using System.Windows.Forms;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            int[] expected = new int[] {100,10,5};
            GraphikDrawPrim inst = new GraphikDrawPrim();
            int[] inputDataA = new int[3] {1000,500,300 };
            int[] inputDataB = new int[3] {600,700,100 };
            int[] inputDataC = new int[3] {10,15,5};
            double[] inputDataD = new double[3] {10.5,50.0,60.5 };
            int[] result = new int[3];
            for (int i = 0; i < 3; ++i)
            {
                result[i] = inst.ReCount(inputDataA[i], inputDataB[i], inputDataD[i], inputDataC[i]);
                Assert.AreEqual(expected[i],result[i]);
            }
        }
    }
  
        }
 
