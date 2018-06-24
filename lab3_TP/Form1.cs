using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab3_TP
{
    public partial class Form1 : Form
    {
        int[] arr = null;
        int? Mean =null;
        int? Despersion = null;     
        int? sumEl = null;
        int? numEl = null;
        PerсentAndNum[] arrayPersAndNum = null;
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// alignment num of data greed rows to to array lenghts
        /// </summary>
        /// <param name="arrLenth">size of array</param>
        private void DataGreedConstructor()
        {
            int arrLenth;
            if (arr == null)
                arrLenth = 0;
            else
                arrLenth = arr.Length;
            int oldRows = dataGridView1.RowCount;
            int diff;
            //add aditional rows
            if (oldRows < arrLenth)
            {
                diff = arrLenth - oldRows;
                for (int i = 0; i < diff; i++)
                {
                    dataGridView1.Rows.Add(new DataGridViewRow());
                }
            }
            //reamove extra rows
            else if (oldRows > arrLenth)
            {
                diff = oldRows - arrLenth;
                for (int i = 0; i < diff; i++)
                {
                    //for cleaning rest cells
                    if (arrLenth == 0 && diff - i == 1)
                    {
                        dataGridView1[1, 0].Value = null;
                        dataGridView1[0, 0].Value = null;
                        return;
                    }
                    dataGridView1.Rows.RemoveAt(0);
                }
            }
            else return;
        }
        /// <summary>
        /// output in data greed and textbox
        /// </summary>
        private void DataOutput()
        {
            if (arr == null)
            {
                textBoxArr.Text = "Пустой массив";
                DataGreedConstructor();
                return;
            }
            //out in textbox
            textBoxArr.Text = RandomArrayGenerate.ArrToStringArr(arr);
            DataGreedConstructor();
            //out in textbox data greed
            int i = 0;
            foreach (var digit in arr)
            {
                dataGridView1[1, i].Value = digit;
                dataGridView1[0, i].Value = i;
                i++;
            }
        }
        private void AllDataOutput()
        {       
            DataOutput();
            IntervalGreedClc();
            if (arrayPersAndNum != null)
            {
                IntervalOut();
            }
            if(Despersion == null)
                textBoxDespersion.Text = "-";
            else
                textBoxDespersion.Text = Despersion.ToString();
            if (Mean == null)
                textBoxMean.Text = "-";
            else
                textBoxMean.Text = Mean.ToString();
            if (sumEl == null)
                textBoxSum.Text = "-";
            else
                textBoxSum.Text = Despersion.ToString();
            if (numEl == null)
                textBoxNumber.Text = "-";
            else
                textBoxNumber.Text = Despersion.ToString();
        }
        private void IntervalOut()
        {
            int j;
            //num of unique numbers
            int klasterSize = arrayPersAndNum[0].uniqueNum.Length;
            int offset = 0;
            for (int i = 0; i < arrayPersAndNum.Length;i++)
            {
                for (j = 0; j < arrayPersAndNum[i].uniqueNum.Length; j++)
                {
                    dataGridView2.Rows.Add(new DataGridViewRow());          
                    //out all data
                    dataGridView2[1, offset + j].Value = arrayPersAndNum[i].uniqueNum[j];
                    dataGridView2[2, offset + j].Value = arrayPersAndNum[i].num[j];
                    dataGridView2[3, offset + j].Value = arrayPersAndNum[i].perсent[j].ToString("0.0") + "%";
                }
                //out interval number
                dataGridView2[0, offset].Value = arrayPersAndNum[i].interval;
                offset += arrayPersAndNum[i].uniqueNum.Length;
            }
        }
        private void IntervalGreedClc()
        {           
            while (dataGridView2.Rows.Count != 1)
            {
                dataGridView2.Rows.RemoveAt(0);
            }
            dataGridView2[0,0].Value = null;
            dataGridView2[1,0].Value = null;
            dataGridView2[2,0].Value = null;
            dataGridView2[3,0].Value = null;
        }
        private void AdditionalDataClc()
        {
            IntervalGreedClc();
            textBoxMean.Text = "-";
            textBoxDespersion.Text = "-";
            textBoxSum.Text = "-";
            textBoxNumber.Text = "-";
        }
        private void Generate_Click(object sender, EventArgs e)
        {
            if (numericArrayRange.Value == 0)
            {
                arr = null;
                DataOutput();
                AdditionalDataClc();
                Mean = null;
                Despersion = null;
                numEl = null;
                sumEl = null;
                arrayPersAndNum = null;
                return;
            }
            try
            {
                 arr = RandomArrayGenerate.Generate
                    ((int)numericArrayRange.Value, //value from range numeric element
                    (int)numericMinArrBorder.Value, //value from A numeric element
                    (int)numericMaxArrBordr.Value); //value from B numeric element
            }
            catch (Exception ex)
            {
                textBoxArr.Text = ex.Message;
                arr = null;
                Mean = null;
                Despersion = null;
                numEl = null;
                sumEl = null;
                arrayPersAndNum = null;
                DataGreedConstructor();
                AdditionalDataClc();
                return;
            }
            numericSubInterval.Maximum = arr.Length;
            //out generated aaray
            DataOutput();
           // IntervalGreedClc();
            Mean = null;
            Despersion = null;
            numEl = null;
            sumEl = null;
            arrayPersAndNum = null;
            AdditionalDataClc();
        }
        private void F2read_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = ".txt";
            openFileDialog1.FileName = "F2.txt";
            //check button pressed
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string path = openFileDialog1.FileName;
            string arrString = File.OpenText(path).ReadLine();
            try
            {
                ReadWriteFile.F2FileRead(
                    path, 
                    ref arr, 
                    ref Despersion,
                    ref Mean,
                    ref sumEl,
                    ref numEl,
                    ref arrayPersAndNum
                    );
            }
            catch (Exception)
            {
                //prompt about file error open
                MessageBox.Show("Не удалось открыть файл", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //data out and prompt about succesfull of file opening 
            AllDataOutput();
            MessageBox.Show("Открытие файла успешно", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void F2write_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.FileName = "F2.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            try
            {
                ReadWriteFile.F2WriteFile(
                    saveFileDialog1.FileName, 
                    RandomArrayGenerate.ArrToStringArr(arr),
                    Despersion,
                    Mean,
                    sumEl,
                    numEl,
                    arrayPersAndNum);
            }
            catch (Exception)
            {
                MessageBox.Show("Запись файла является безуспешной", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("File write is succesful!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void F1Read_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = ".txt";
            openFileDialog1.FileName = "F1.txt";
            //check button pressed
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            string path = openFileDialog1.FileName;
            string arrString =  File.OpenText(path).ReadLine();
            try
            {
                ReadWriteFile.F1FileRead(path, ref arr);
            }
            catch (Exception)
            {
                //prompt about file error open
                //textBoxArr.Text = "Can`t read array from file, check it correctness!";
                MessageBox.Show("Не удалось открыть файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //data out and prompt about succesfull of file opening 
            DataOutput();
            AdditionalDataClc();
            MessageBox.Show("Открытие файла успешно", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void F1Write_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.FileName = "F1.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            try
            {
                ReadWriteFile.F1WriteFile(saveFileDialog1.FileName,
                 RandomArrayGenerate.ArrToStringArr(arr));
       
            }
            catch (Exception)
            {
                MessageBox.Show("Файл запись является безуспешной.", "Ошибка.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Запись файла успешна.", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ActionButton_Click(object sender, EventArgs e)
        {
            //1 task
            if (SortArrayRadiobutton.Checked)
            {
                try
                {
                    Array.Sort(arr);
                    DataOutput();
                }
                catch (Exception)
                {
                    textBoxArr.Text = "Невозможно сортировать несуществующий массив.";
                }
                return;
            }
            //2 task
            if (MeanAndDespRadiobarron.Checked)
            {
                double M = 0, D = 0;
                try
                {
                    TasksClass.MeanAndDespersion(arr, out M, out D);
                }
                catch (Exception ex)
                {
                    textBoxArr.Text = ex.Message;
                    return;
                }
                textBoxMean.Text = M.ToString();
                textBoxDespersion.Text = D.ToString();
                Mean = (int)M;
                Despersion = (int)D;
                return;
            }
            //4 task
            if(radioButtonCount.Checked)
            {
                try
                {
                    int num = 0, sum = 0;
                    TasksClass.SumOfElements_2_3(arr, ref sum, ref num);
                    textBoxSum.Text = sum.ToString();
                    textBoxNumber.Text = num.ToString();
                    sumEl = (int)sum;
                    numEl = (int)num;
                }catch(Exception)
                {
                    textBoxArr.Text = "Невозможно подсчитать количество и сумму в пустом массиве.";
                }
                return;
            }
            //3 task
            if (radioButtonInterval.Checked)
            {
                try
                {
                    IntervalGreedClc();
                    arrayPersAndNum = TasksClass.SubInterval(arr, (int)numericSubInterval.Value);
                    for (int i = 0; i < arrayPersAndNum.Length; i++)
                    {
                        arrayPersAndNum[i].ParseSubArray();
                    }
                    IntervalOut();
                }
                catch (Exception)
                {
                    textBoxArr.Text = "Невозможно построить интервалы пустого массива.";
                }
            }
        }
        private void textBoxArr_TextChanged(object sender, EventArgs e)
        {
            if (arr == null || arr.Length == 0)
            {
                F1Write.Enabled = false;
                F2write.Enabled = false;
            }
            else
            {
                F1Write.Enabled = true;
                F2write.Enabled = true;
            }
        }
        private void radioButtonCount_CheckedChanged(object sender, EventArgs e)
        {
            numericSubInterval.Enabled = false;
        }
        private void radioButtonInterval_CheckedChanged(object sender, EventArgs e)
        {
            numericSubInterval.Enabled = true;
            if(arr == null) numericSubInterval.Maximum = 0;
            else numericSubInterval.Maximum = arr.Length;
        }
        private void MeanAndDespRadiobarron_CheckedChanged(object sender, EventArgs e)
        {
            numericSubInterval.Enabled = false;
        }
        private void SortArrayRadiobutton_CheckedChanged(object sender, EventArgs e)
        {
            numericSubInterval.Enabled = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
