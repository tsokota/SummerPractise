using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace lab3_TP
{
    public static class ReadWriteFile
    {
        /// <summary>
        /// open and read array from file
        /// </summary>
        /// <param name="path">path to file</param>
        /// <param name="arr">output array</param>
        public static void F1FileRead(string path, ref int[] arr)
        {
            string arrString = File.OpenText(path).ReadLine();
            StringToArrayInFile(arrString, ref arr);
        }        
        /// <summary>
        /// write in F1.txt
        /// </summary>
        /// <param name="path">path to F1.txt</param>
        /// <param name="data">data to write</param>
        public static void F1WriteFile(string path, string data)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            fs.Close();
            StreamWriter sw= new StreamWriter(path);
            sw.Write(data);
            sw.Close();         
        }
        /// <summary>
        ///  write in F2.txt
        /// </summary>
        /// <param name="path">path to F2.txt</param>
        public static void F2WriteFile(string path, string arrData, int? D, int? M, int? sum, int? num, PerсentAndNum[] PND)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            fs.Close();
            StreamWriter sw = new StreamWriter(path);
            sw.WriteLine(arrData);
            if (D == null) sw.WriteLine("-");
            else sw.WriteLine(D);
            if (M == null) sw.WriteLine("-");
            else sw.WriteLine(M);
            if (sum == null) sw.WriteLine("-");
            else sw.WriteLine(sum);
            if (num == null) sw.WriteLine("-");
            else sw.WriteLine(num);
            if (PND == null) sw.WriteLine("-");
            else
                foreach (var i in PND)
                {
                    sw.WriteLine(i.interval);
                    sw.WriteLine(RandomArrayGenerate.ArrToStringArr(i.uniqueNum));
                    sw.WriteLine(RandomArrayGenerate.ArrToStringArr(i.num));
                    sw.WriteLine(RandomArrayGenerate.ArrToStringArr(i.perсent));
                }
            sw.Close();
        }
        /// <summary>
        /// read from F2.txt
        /// </summary>
        /// <param name="path">path to F2.txt</param>
        public static void F2FileRead(string path, ref int[] arr, ref int? D, ref int? M, ref int? sum, ref int? num, ref PerсentAndNum[] PND)
        {
            StreamReader sr = new StreamReader(path);
            StringToArrayInFile(sr.ReadLine(), ref arr);
            string bufer = sr.ReadLine();
            if (bufer == "-") D = null;
            else { D = Convert.ToInt32(bufer); }
            bufer = sr.ReadLine();
            if (bufer == "-") M = null;
            else {  M = Convert.ToInt32(bufer); }
            bufer = sr.ReadLine();
            if (bufer == "-") sum = null;
            else { sum = Convert.ToInt32(bufer); }
            bufer = sr.ReadLine();
            if (bufer == "-") num = null;
            else { num = Convert.ToInt32(bufer); }
            bufer = sr.ReadLine();
            if (bufer == "-") PND = null;
            else
            {
                PND = new PerсentAndNum[0];
                for (int i = 0; ; i++)
                {
                    if (String.IsNullOrEmpty(bufer)) break;
                    Array.Resize(ref PND, PND.Length + 1);
                    //sr.WriteLine(i.interval);                 
                    PND[i].interval = Convert.ToInt32(bufer);
                    bufer = sr.ReadLine();
                    //sr.WriteLine(RandomArrayGen.ArrToStringArr(i.uniqueNum));
                    StringToArrayInFile(bufer, ref PND[i].uniqueNum);
                    bufer = sr.ReadLine();
                    //sr.WriteLine(RandomArrayGen.ArrToStringArr(i.num));
                    StringToArrayInFile(bufer, ref PND[i].num);
                    bufer = sr.ReadLine();
                    //  sr.WriteLine(RandomArrayGen.ArrToStringArr(i.persent));
                    StringToArrayInFile(bufer, ref PND[i].perсent);
                    bufer = sr.ReadLine();
                }
            }
            sr.Close();
        }
        /// <summary>
        /// text string array to integer array
        /// </summary>
        /// <param name="inputString">input string array</param>
        public static void StringToArrayInFile(string inputString, ref int[] arr)
        {
            int index;
            int numOfspaces = 0;
            //count num of scaces
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == ' ') numOfspaces++;
            }
            //allocate memory for arrey
            arr = new int[numOfspaces + 1];
            //fill arraay with string array values
            for (int i = 0; i < numOfspaces; i++)
            {
                index = inputString.IndexOf(" ");
                if (index == -1) { break; }
                string subString = inputString.Substring(0, index);
                inputString = inputString.Substring(index + 1);
                arr[i] = Convert.ToInt32(subString);
            }
            arr[arr.Length - 1] = Convert.ToInt32(inputString);
        }
        /// <summary>
        ///  text string array to double array
        /// </summary>
        /// <param name="inputString">input string array</param>
        /// <param name="arr">out array</param>
        public static void StringToArrayInFile(string inputString, ref double[] arr)
        {
            int index;
            int numOfspaces = 0;
            //count num of scaces
            for (int i = 0; i < inputString.Length; i++)
            {
                if (inputString[i] == ' ') numOfspaces++;
            }
            //allocate memory for arrey
            arr = new double[numOfspaces + 1];
            //fill arraay with string array values
            for (int i = 0; i < numOfspaces; i++)
            {
                index = inputString.IndexOf(" ");
                if (index == -1) { break; }
                string subString = inputString.Substring(0, index);
                inputString = inputString.Substring(index + 1);
                arr[i] = Convert.ToDouble(subString);
            }
            arr[arr.Length - 1] = Convert.ToDouble(inputString);
        }
    }
}
