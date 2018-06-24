using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_TP
{
    public partial class MatrOutForm : Form
    {
        public MatrOutForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Matr out in data greed
        /// </summary>
        public void DrawMatr()
        {
            Matrix matrix = TransferClass.matrix;
            //cut matrix size if too big
            if (dataGridView1.ColumnCount > matrix.size)
            {
                CutOutMAtrixSize();return;
            }
            if (dataGridView1.ColumnCount <= matrix.size)
            {
                AddOutMatrSize();return;
            }
        }
        /// <summary>
        /// Out index arrays
        /// </summary>
        public void OutDataIndexs()
        {
            Matrix matrix = TransferClass.matrix;
            if (matrix.indexI == null || matrix.indexI.Length == 0)
            {
                textBoxIndexI.Text = "-";
                textBoxIndexJ.Text = "-";
                return;
            }
            int indexLen = matrix.indexI.Length;
            textBoxIndexI.Text = "";
            textBoxIndexJ.Text = "";
            for (int i = 0; i < indexLen; i++)
            {
                textBoxIndexI.Text += matrix.indexI[i].ToString() + " ";
                textBoxIndexJ.Text += matrix.indexJ[i].ToString() + " ";
            }
        }
        /// <summary>
        /// Out num of primitive numbers
        /// </summary>
        public void OutPrimNum()
        {
            textBoxPrim.Text = TransferClass.matrix.primitNumbers.ToString();
        }
        /// <summary>
        /// out si sorted flag
        /// </summary>
        public void OutIsSorted()
        {
            if (TransferClass.matrix.Sorted == true)
            {
                textBoxSorted.Text = "Yes";
            }
            else { textBoxSorted.Text = "No"; }
        }
        /// <summary>
        /// add data out
        /// </summary>
        public void AllDataOut()
        {
            DrawMatr();
            OutDataIndexs();
            OutPrimNum();
            OutIsSorted();
        }
        /// <summary>
        /// cut matrix size
        /// </summary>
        public void CutOutMAtrixSize()
        {
            int diff = dataGridView1.ColumnCount - TransferClass.matrix.size - 1;
            int rmIndexC = dataGridView1.ColumnCount;
            int rmIndexR = dataGridView1.Rows.Count;
            for (int i = 0; i < diff; i++)
            {
                dataGridView1.Columns.Remove(dataGridView1.Columns[rmIndexC - 1 - i]);               
                dataGridView1.Rows.Remove(dataGridView1.Rows[rmIndexR - 2 - i]);
            }
            for (int j = 0; j < TransferClass.matrix.size; j++)
            {
                dataGridView1[0, j].Value = "j[" + j.ToString() + "]";
            }
            MatrixFill();
        }
        /// <summary>
        /// Matrix fill
        /// </summary>
        public void MatrixFill()
        {
            Matrix matrix = TransferClass.matrix;
            for (int i = 0; i < matrix.size; i++)
                for (int j = 0; j < matrix.size; j++)
                    dataGridView1[i+1, j].Value = matrix.matrix[i, j];
        }
        /// <summary>
        /// Matrix add columns and rows
        /// </summary>
        public void AddOutMatrSize()
        {
            Matrix matrix = TransferClass.matrix;
            dataGridView1.ColumnCount = matrix.size + 1;
            for (int i = 0; i < matrix.size+1; i++)
            {
                dataGridView1.Columns[i].Width = 40;
            }
            while (dataGridView1.Rows.Count != matrix.size + 1)
            {                
                dataGridView1.Rows.Add(new DataGridViewRow());
            }
            for (int j = 0; j < matrix.size; j++)
            {
                if (j != 0)
                {
                    dataGridView1.Columns[j].Name = "i[" + (j - 1).ToString() + "]";
                }
                dataGridView1[0, j].Value = "j[" + j.ToString() + "]";
            }
            int ind = matrix.size;
            dataGridView1.Columns[ind].Name = "i[" + (matrix.size - 1).ToString() + "]";
            dataGridView1.Columns[ind].Width = 40;
            MatrixFill();
        }

        /// <summary>
        /// Close the form
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MatrOutForm_Load(object sender, EventArgs e)
        {

        }
    }
}
