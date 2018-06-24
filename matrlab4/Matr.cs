using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace lab4_TP
{
    [DataContract]
    public class Matrix
    {
        [DataMember]
        public int[][] matrSerial;
        public int[,] matrix;
        [DataMember]
        public int[] indexI = null;
        [DataMember]
        public int[] indexJ = null;
        [DataMember]
        public int primitNumbers = 0;
        public int size;
        [DataMember]
        public bool Sorted = false;

        /// <summary>
        /// Random array generate
        /// </summary>
        /// <param name="size"></param>
        /// <param name="LeftBorder"></param>
        /// <param name="RightBorder"></param>
        public void RandomGen(int size, int LeftBorder, int RightBorder)
        {
            if (LeftBorder > RightBorder) throw new Exception("Check border correcthess!");
            matrix = new int[size, size];
            this.size = size;
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = rnd.Next(LeftBorder, RightBorder + 1);
                }
            }
        }

        /// <summary>
        /// search all index of current data
        /// </summary>
        /// <param name="Data"></param>
        public void SearchDataIndexs(int Data)
        {
            if (size == 0) throw new Exception("Can`t search in empty matrix.");
            indexI = new int[0];
            indexJ = new int[0];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (Data == matrix[i, j])
                    {
                        Array.Resize(ref indexI, indexI.Length + 1);
                        Array.Resize(ref indexJ, indexJ.Length + 1);
                        indexI[indexI.Length-1] = i;
                        indexJ[indexJ.Length-1] = j;
                    }
                }
            }
        }

        /// <summary>
        /// Transfer martix[,] to matrix[][] for serialization
        /// </summary>
        public void MatrToMatrSerial()
        {
            //allocate memory for rows
            matrSerial = new int[size][];
            for (int i = 0; i < size; i++)
            {
                //allocate memory for columns
                matrSerial[i] = new int[size];
                for (int j = 0; j < size; j++)
                {
                    matrSerial[i][j] = matrix[i, j];
                }
            }
        }

        /// <summary>
        /// Transfer martix[][] to matrix[,] for deserialization 
        /// </summary>
        public void MatrSerialToMatr()
        {
            if (matrSerial == null) { matrix = null; return; }
            //assign size
            size = matrSerial[0].Length;
            //allocate memory for mart 
            matrix = new int[size,size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = matrSerial[i][j];
                }
            }
        }

        /// <summary>
        /// Sort columns in decreasing ascending 
        /// </summary>
        public void ColumnSort()
        {
            int[] subArr = new int[size];
            for (int i = 0; i < size; i++)
            {
                //assign column to subarray
                for (int j = 0; j < size; j++)
                {
                    subArr[j] = matrix[i, j];
                }
                //sort subarray
                Array.Sort(subArr);
                //assign
                for (int j = 0; j < size; j++)
                {
                   matrix[i, j] = subArr[size - j - 1 ];
                }
            }
            Sorted = true;
        }
        /// <summary>
        /// count primitive numbers
        /// </summary>
        public void PrimitiveNumbers()
        {
            primitNumbers = 0;
            //passage through an array
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    //for 2 and 3 - it`s primitive number
                    if (matrix[i, j] == 2 || matrix[i,j] == 3)
                    {
                        primitNumbers++;
                        continue;
                    }
                    //if primitive not 0 and not 1
                    if (matrix[i, j] != 0 || matrix[i, j] != 1)
                    {
                        int endPoint = (int)Math.Sqrt(matrix[i, j]);
                        for (int p = 2; p <= endPoint; p++)
                        {
                            if (matrix[i, j] % p == 0) break;
                            if (matrix[i, j] % p != 0 && p == endPoint)
                            {
                                primitNumbers++;
                            }
                        }
                    }
                }
            }
        }
    }
}
