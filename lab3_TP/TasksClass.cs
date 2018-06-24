using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_TP
{
    public static class TasksClass
    {
        /// <summary>
        /// Count Mean adn Despertion
        /// </summary>
        /// <param name="arr">in array</param>
        /// <param name="M">out mean</param>
        /// <param name="D">out despertion</param>
        public static void MeanAndDespersion(int[] arr ,out double M, out double D)
        {
            if (arr == null || arr.Length == 0 || arr.Length == 1)
            {
                throw new Exception("Mean and despersion of zero or 1 array length does not exist.");
            }
            M = 0;D = 0;
            //count M and M2
            for (int i = 0; i < arr.Length; i++)
            {
                M += arr[i];
            }
            M /= arr.Length;
            //Despersion count
            for (int i = 0; i < arr.Length; i++)
            {
                D += (arr[i]-M)*(arr[i]-M);
            }
            D /= arr.Length - 1;
        }
        /// <summary>
        /// sum in accoding to task 4
        /// </summary>
        /// <param name="arr">in arr</param>
        /// <param name="sum">out sum</param>
        /// <param name="numOf">out num</param>
        public static void SumOfElements_2_3(int[] arr, ref int sum, ref int numOf)
        {
            if (arr == null || arr.Length == 0)
            {
                throw new Exception("Can`t do opperation of zero array length.");
            }
            numOf = 0;
            sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //count numbers wih 2nd and 3`d sum digit even
                if (arr[i] >= 100)
                {
                    //2nd
                    int secondNum = (arr[i] % 100) / 10;
                    //3`d
                    int thirdNum = (arr[i] % 1000) / 100;
                    if ((secondNum + thirdNum) % 2 == 0)
                    {
                        //sum adn num increase
                        numOf++;
                        sum += arr[i];
                    }
                }               
            }
        }
        /// <summary>
        /// interval counter in accodin to task 3
        /// </summary>
        /// <param name="arr">in arr</param>
        /// <param name="subIntNum">out sub iterval struck</param>
        /// <returns></returns>
        public static PerсentAndNum[] SubInterval(int[] arr, int subIntNum)
        {
            if (subIntNum == 0) { throw new Exception(); }
            int arrayLen = arr.Length;
            //lenth of sub array = arrlen / subittbun
            int subIntLen = arrayLen / subIntNum;
            int[] subArr = new int[subIntLen];
            //array of subinterval arrays
            PerсentAndNum[] intervArr = new PerсentAndNum[subIntNum];
            for (int i = 0; i < subIntNum - 1; i++)
            {
                for (int j = i * subIntLen, p = 0; j < (i + 1) * subIntLen; j++, p++)
                {
                    subArr[p] = arr[j];
               }
                    intervArr[i] = new PerсentAndNum(i, subArr);
            }
            //allocata memory for last subinterval
            subArr = new int[arr.Length - (subIntNum-1)*subIntLen];
            //separete cucle for last subinterval

            for (int i = (subIntNum - 1) * subIntLen, j = 0; i < arr.Length; i++, j++)
            {
                subArr[j] = arr[i];
            }
            //add lust subarray
            intervArr[intervArr.Length-1] = new PerсentAndNum(intervArr.Length-1, subArr);
            return intervArr;
        }
    }
}
