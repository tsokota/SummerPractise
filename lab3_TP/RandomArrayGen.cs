using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_TP
{
    public static class RandomArrayGenerate
    {
        /// <summary>
        /// Random array generation from a to b+1 range
        /// </summary>
        /// <param name="size">size of array</param>
        /// <param name="A">min range</param>
        /// <param name="B">max range</param>
        /// <returns>array in string view</returns>
        public static int[]  Generate(int size, int A, int B)
        {
            //if incorect values of border
            if (A > B)
            {
                throw new Exception("Can`t generate array with such borders, check A and B boxes.");
            }
            int[] arr = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(A, B+1);
            }
            return arr;
        }
        /// <summary>
        /// int[] => string
        /// </summary>
        /// <param name="arr">in array</param>
        /// <returns>out string</returns>
        public static string ArrToStringArr(int[] arr)
        {
            string subArr = "";
            foreach (var i in arr)
            {
                subArr += i + " ";
            }
            subArr = subArr.Remove(subArr.Length - 1);
            return subArr;
        }
        /// <summary>
        /// double[] => string
        /// </summary>
        /// <param name="arr">in array</param>
        /// <returns>out string</returns>
        public static string ArrToStringArr(double[] arr)
        {
            string subArr = "";
            foreach (var i in arr)
            {
                subArr += i + " ";
            }
            subArr = subArr.Remove(subArr.Length - 1);
            return subArr;
        }
    }
}
