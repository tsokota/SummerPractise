using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_TP
{
    /// <summary>
    /// structure suplyes all information for 3 task
    /// </summary>
    public struct PerсentAndNum
    {
        public double[] perсent;
        public int[] num;
        public int interval;
        int[] subArray;
        public int[] uniqueNum;
        /// <summary>
        /// constructor sets interval number and sets sub array
        /// </summary>
        /// <param name="interval"></param>
        /// <param name="subArr"></param>
        public PerсentAndNum(int interval, int[] subArray)
        {
            this.perсent = null;
            this.num = null;
            this.interval = interval;
            this.subArray = new int[subArray.Length];
            Array.Copy(subArray, this.subArray, subArray.Length);
            this.uniqueNum = null;
        }
        /// <summary>
        /// parse sub array on nums and
        /// </summary>
        public void ParseSubArray()
        {
            num = new int[0];
            perсent = new double[0];
            uniqueNum = new int[0];
            int index;
            for (int i = 0; i < subArray.Length; i++)
            {
                //index of current number
                index = Array.IndexOf(uniqueNum, subArray[i]);
                //if it is unique number - assign
                if (index == -1)
                {
                    //resizing num and uniqueNum arrays
                    Array.Resize(ref num, num.Length + 1);
                    Array.Resize(ref uniqueNum, uniqueNum.Length + 1);
                    //increment new cell of num array
                    num[num.Length - 1]++;
                    //assign unique number
                    uniqueNum[uniqueNum.Length - 1] = subArray[i];
                }
                else
                {
                    //increment if same number 
                    num[index]++;
                }
            }
            PercentCount();
        }
        /// <summary>
        /// count persent
        /// </summary>
        private void PercentCount()
        {
            perсent = new double[uniqueNum.Length];
            for (int i = 0; i < perсent.Length; i++)
            {
                //count persent
                perсent[i] = (double)num[i] / (double)subArray.Length * 100;
            }
        }
    }
}
