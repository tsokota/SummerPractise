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
    public partial class MainForm : Form
    {
        /// <summary>
        /// Child window, contain matrix and matrix info 
        /// </summary>
        MatrOutForm MOF;
        public MainForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Shows about author information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutButton_Click(object sender, EventArgs e)
        {
            AuthorForm AF = new AuthorForm();
            AF.ShowDialog();
        }
        /// <summary>
        /// Handle save fele click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileSaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "File1.json";
            saveFileDialog1.DefaultExt = ".json";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            ReadWriteFile.Write(saveFileDialog1.FileName, TransferClass.matrix);
        }
        /// <summary>
        /// Heandle generate utton click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDownSize.Value == 0) { ErrPromptSize(); return; }
            else { ErrClc(); }
            try
            {
                TransferClass.matrix = new Matrix();
                TransferClass.matrix.RandomGen
                    ((int)numericUpDownSize.Value,
                    (int)numericUpDownLeft.Value,
                    (int)numericUpDownRight.Value);
            }catch(Exception ex)
            {
                ErrPromptBorders(ex.Message);return;
            }
            ErrClc();
            
            if (MOF == null || MOF.IsDisposed)
            {
                MOF = new MatrOutForm();
                MOF.Show();
            }
            MOF.AllDataOut();
        }
        /// <summary>
        /// Handle File read button press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileReadButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "File1.json";
            openFileDialog1.DefaultExt = ".json";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;
            try
            {
                TransferClass.matrix = ReadWriteFile.Read(openFileDialog1.FileName);
                if (MOF == null || MOF.IsDisposed)
                {
                    MOF = new MatrOutForm();
                    MOF.Show();
                }
                MOF.AllDataOut();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message,"Error!",MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        /// <summary>
        /// Enable or disable data numericUpDown element
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                numericUpDownData.Enabled = true;
            }
            else
            {
                numericUpDownData.Enabled = false;
            }
        }
        /// <summary>
        /// Handle action button click 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ActionButton_Click(object sender, EventArgs e)
        {
            //set error if matrix empty
            if (TransferClass.matrix.matrix == null)
            {
                ErrPromptAction("Can`t operate with nonexistent matrix!"); return;
            }
            //show matrix if it not showed
            if (MOF == null)
            {
                MOF.AllDataOut();
            }
            if (checkBox1.Checked)
            {
                TransferClass.matrix.ColumnSort();
                MOF.DrawMatr();
                MOF.OutIsSorted();
            }
            if (checkBox2.Checked)
            {
                TransferClass.matrix.SearchDataIndexs((int)numericUpDownData.Value);
                MOF.OutDataIndexs();
            }
            if (checkBox3.Checked)
            {
                TransferClass.matrix.PrimitiveNumbers();
                MOF.OutPrimNum();
            }
            if (!checkBox1.Checked && !checkBox2.Checked && !checkBox3.Checked)
            {
                ErrPromptAction("Please, select some options."); 
            }
        }
        /// <summary>
        /// Error provide prompt for size
        /// </summary>
        private void ErrPromptSize()
        {
            errorProviderArrSize.SetError(numericUpDownSize, "Incorrect size, it`s may be more than 0");
            numericUpDownSize.BackColor = Color.OrangeRed;
        }
        /// <summary>
        /// Error provide prompt for action
        /// </summary>
        /// <param name="message"></param>
        private void ErrPromptAction(string message)
        {
            errorProviderActionButton.SetError(ActionButton, message);
        }
        /// <summary>
        /// Error provide prompt for matrix borders
        /// </summary>
        /// <param name="message"></param>
        private void ErrPromptBorders(string message)
        {
            errorProviderLowB.SetError(numericUpDownLeft, message);
            errorProviderHighB.SetError(numericUpDownRight, message);
            numericUpDownLeft.BackColor = Color.OrangeRed;
            numericUpDownRight.BackColor = Color.OrangeRed;
        }
        /// <summary>
        /// Clean all errors prompt
        /// </summary>
        private void ErrClc()
        {
            errorProviderArrSize.Clear();
            errorProviderHighB.Clear();
            errorProviderLowB.Clear();
            errorProviderActionButton.Clear();
            numericUpDownSize.BackColor = Color.White;
            numericUpDownLeft.BackColor = Color.White;
            numericUpDownRight.BackColor = Color.White;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
