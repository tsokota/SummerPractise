using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace lab4_TP
{
    public class ReadWriteFile
    {
        /// <summary>
        /// Desirialize file
        /// </summary>
        /// <param name="path"></param>
        /// <param name="matrix"></param>
        public static Matrix Read(string path)
        {
            Matrix matrix = new Matrix(); 
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Matrix));
            //deserialize
            try
            {
                using (FileStream stream = new FileStream(path, FileMode.Open))
                {
                    //read object
                    matrix = js.ReadObject(stream) as Matrix;
                }
            }
            catch (Exception) { throw new Exception("Не удается десериализовать файл "); }
            matrix.MatrSerialToMatr();
            return matrix;
        }
        /// <summary>
        /// Serialize in file
        /// </summary>
        /// <param name="path"></param>
        /// <param name="matrix"></param>
        public static void Write(string path, Matrix matrix)
        {
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Matrix));
            try
            {    
                    using (FileStream stream = new FileStream(path, FileMode.Create))
                    {
                        matrix.MatrToMatrSerial();

                        //write object
                        js.WriteObject(stream, matrix);

                    }
            }
            catch (Exception) { throw new Exception(" Не удается десериализовать файл "); }
        }
    }
}
