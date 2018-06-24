using NUnit.Framework;
using lab3_TP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_TP.Tests
{
    [TestFixture()]
    public class TasksClassTests
    {
        [Test]
        public void MeanAdnDesp_Test()
        {
            int[][] inputData = new int[][]
            {
                new int[6] {2, 2, 3, 0, 2, 3 },
                new int[6] {1 ,1 ,4, 0 ,4, 2 },
            };
            double[,] expected = new double[2, 2]
                {
                    {2, 1.2},
                    {2,2.8},
                };
            double[,] result = new double[2, 2];
            for (int i = 0; i < 2; i++)
            {
                TasksClass.MeanAndDespersion(inputData[i], out result[i, 0], out result[i, 1]);
                Assert.AreEqual(expected[i, i], result[i, i]);
            }

        }
        [Test]
        public void SumOfElements_Test()
        {
            int[][] inputData = new int[][]
            {
                new int[3] {2000,1999,1989 },
                new int[4] {1111,2222,3333,4444 },
                new int[3] {10,1,0 }
            };
            double[] expectedS = new double[3] { 3999, 11110, 0 };
            double[] expectedN = new double[3] { 2, 4, 0, };
            int[] sum = new int[3];
            int[] num = new int[3];
            for (int i = 0; i < 3; i++)
            {
                TasksClass.SumOfElements_2_3(inputData[i], ref sum[i], ref num[i]);
                Assert.AreEqual(expectedS[i], sum[i]);
                Assert.AreEqual(expectedN[i], num[i]);
            }
        }

        [Test]
        public void ArrToString_Test()
        {
            double[][] inputData = new double[][]
                {
                    new double[6] { 2, 2, 3, 0, 2, 3 },
                    new double[6] { 1, 1, 4, 0, 4, 2 },
                };
            string[] expected = new string[2];
            expected[0] = "2 2 3 0 2 3";
            expected[1] = "1 1 4 0 4 2";
            string result;
            for (int i = 0; i < 2; i++)
            {
                result = RandomArrayGenerate.ArrToStringArr(inputData[i]);
                Assert.AreEqual(expected[i], result);
            }
        }
        [Test]
        public void StringToArray_Test()
        {
            double[][] inputData = new double[][]
                {
                    new double[6] { 2, 2, 3, 0, 2, 3 },
                    new double[6] { 1, 1, 4, 0, 4, 2 },
                };
            string[] expected = new string[2];
            expected[0] = "2 2 3 0 2 3";
            expected[1] = "1 1 4 0 4 2";
            string result;
            for (int i = 0; i < 2; i++)
            {
                result = RandomArrayGenerate.ArrToStringArr(inputData[i]);
                Assert.AreEqual(expected[i], result);
            }
        }
    }
}