using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace ClassOper
{
    public class ClassOperations
    {
        public int[] Mass, MassAft;
        public int Summ1, Summ2, Num;
        public double Summ3, Sr, D;
        public string TmpTxt;
        public void GenerMass(int Size, int A, int B)
        {  // генерация массива по диапазону
            Mass = new int[Size];
            Random rand = new Random((int)(DateTime.Now.Ticks));
            for (int i = 0; i < Size; i++)
                Mass[i] = rand.Next(A, B + 1);
        }

        public void Oper1(int C1)
        {  // Операция 1
            Summ1 = 0; Summ2 = 0;
            for (int i = 1; i < Mass.Length; i += 2)
            {
                if (Mass[i] < C1)
                    Summ1 += Mass[i];
                else if (Mass[i] > C1)
                    Summ2 += Mass[i];
            }
        }

        public void Oper2()
        {  // Операция 2
            int metka;
            MassAft = Mass;
            for (int i = 1; i < MassAft.Length; ++i)
            {
                for (int j = MassAft.Length - 1; j >= i; --j)
                {
                    if (MassAft[j - 1] > MassAft[j]) // Сравнение 
                    {
                        metka = MassAft[j - 1];  // Обмен  
                        MassAft[j - 1] = MassAft[j];
                        MassAft[j] = metka;
                    }
                }
            }
        }

        public void Oper3(int C1, int C2)
        {  // Операция 3
            Summ1 = 0; Num = 0;
            for (int i = 0; i < Mass.Length; i++)
            {
                if (Mass[i] < C1 || Mass[i] > C2)
                {
                    Summ1 += Mass[i];
                    Num++;
                }
            }
        }

        public void Oper4()
        {  // Операция 4
            Summ3 = 0;
            for (int i = 0; i < Mass.Length; i++)
                Summ3 += Mass[i];
            Sr = Summ3 / Mass.Length;

            Summ3 = 0;
            for (int i = 0; i < Mass.Length; i++)
                Summ3 += (Mass[i] - Sr) * (Mass[i] - Sr);
            D = Summ3 / (Mass.Length - 1);
        }


        public bool SerelMass(string FileName)
        { // сериализация массива Ф1
            try
            {
                FileStream fileExp = new FileStream(FileName, FileMode.Create, FileAccess.Write);
                DataContractJsonSerializer serExp = new DataContractJsonSerializer(typeof(List<int>));
                List<int> list = new List<int>(Mass);
                serExp.WriteObject(fileExp, list);
                fileExp.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeSerelMass(string FileName)
        { // десериализация массива Ф1
            try
            {
                FileStream file = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                DataContractJsonSerializer DeserExp = new DataContractJsonSerializer(typeof(List<int>));
                //Mass = new int [] ((int[]) DeserExp.ReadObject(file));
                List<int> list = new List<int>((List<int>)DeserExp.ReadObject(file));
                file.Close();
                Mass = new int[list.Count];

                for (int i = 0; i < Mass.Length; i++)
                    Mass[i] = list[i];
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool SerelChangMass(string FileName, string Txt)
        {  // сериализация массива Ф2
            try
            {
                FileStream fileExp = new FileStream(FileName, FileMode.Create, FileAccess.Write);
                DataContractJsonSerializer serExp = new DataContractJsonSerializer(typeof(string));
                serExp.WriteObject(fileExp, Txt);
                fileExp.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeSerelChangMass(string FileName)
        {  // сериализация массива Ф2
            try
            {
                FileStream file = new FileStream(FileName, FileMode.Open, FileAccess.Read);
                DataContractJsonSerializer DeserExp = new DataContractJsonSerializer(typeof(string));
                //Mass = new int [] ((int[]) DeserExp.ReadObject(file));
                TmpTxt = ((string)DeserExp.ReadObject(file));
                file.Close();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

