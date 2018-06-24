using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Diagrams_lab5_
{
    public partial class StartForm : Form
    {
        DiagramForm diag = null;
        GraphikDrawPrim drawDiag = null;
        Circle drawCircleDiag = null;
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Generate random array values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generate_Click(object sender, EventArgs e)
        {
            DataGridView[] gridView = new DataGridView[2];
            gridView[0] = dataGridView1;
            gridView[1] = dataGridView2;
            int arrNum;
            //double array
            if (checkBoxDoubleArray.Checked)
            {
                arrNum = 2;
                Settings.SeriesNum = 2;
                Settings.yeras = new int[2][];
                Settings.amountOfWages = new double[2][];
            }
            //one array
            else {
                arrNum = 1;
                Settings.SeriesNum = 1;
                Settings.yeras = new int[1][];
                Settings.amountOfWages = new double[1][];
            }
            //clean old data
            for (int i = 0; i < 2; ++i)
            {
                gridView[i].Columns.Clear();
                gridView[i].Rows.Clear();
            }
            int arraySize = (int)numericUpDownSize.Value;
            if (arraySize == 0) return;
            Random rnd = new Random();
            for (int j = 0; j < arrNum; ++j)
            {
                gridView[j].ColumnCount = 2;
                gridView[j].RowCount = arraySize;
                gridView[j].RowHeadersVisible = false;
                gridView[j].Columns[0].Width = 50;
                gridView[j].Columns[1].Width = 50;
                gridView[j].Columns[0].HeaderText = " Year";
                gridView[j].Columns[1].HeaderText = " Average salary";
                gridView[j].Columns[0].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                gridView[j].Columns[1].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleCenter;
                Settings.amountOfWages[j] = new double[arraySize];
                Settings.yeras[j] = new int[arraySize];
                for (int i = 0; i < arraySize; i++)
                {
                    gridView[j][0, i].Value = 2010 + i;
                    Settings.yeras[j][i] = 2010 + i;
                    Settings.amountOfWages[j][i] = rnd.Next(0, 10000) / 100.0;
                    gridView[j][1, i].Value = (Settings.amountOfWages[j][i]).ToString("0.00") + "%";
                }
                if (checkBoxSort.Checked)
                {
                    double[] sortedArray = new double[Settings.amountOfWages[0].Length];
                    Array.Copy(Settings.amountOfWages[j], sortedArray, sortedArray.Length);
                    Array.Sort(sortedArray);
                    for (int i = 0; i < sortedArray.Length; ++i)
                    {
                        Settings.amountOfWages[j][i] = sortedArray[sortedArray.Length - i - 1];
                    }
                }
                for (int i = 0; i < arraySize; i++)
                    gridView[j][1, i].Value = (Settings.amountOfWages[j][i]).ToString("0.00") + "%";
            }

            
            }
        /// <summary>
        /// Select color of columns
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColorSelect_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Settings.ColorOfDiagramMember[0] = colorDialog1.Color;
                colorPanel.BackColor = colorDialog1.Color;
            }
        }
        /// <summary>
        /// Set whow legend or no
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxShowLegend_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowLegend.Checked)
            {
                Settings.legend = true;
            }
            else
            {
                Settings.legend = false;
            }
        }
        /// <summary>
        /// Select font for diagram
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFontSelect_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Settings.fontOfDiagram = fontDialog1.Font;
                textBoxFont.Text = fontDialog1.Font.Name;
            }
        }
        /// <summary>
        /// Show diagram 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowDiagram_Click(object sender, EventArgs e)
        {
            if (Settings.amountOfWages == null || Settings.amountOfWages[0] == null || (Settings.amountOfWages.Length != 2 && checkBoxDoubleArray.Checked))
            {
                MessageBox.Show("Please, generate array firstly.");
                return;
            }
            if (radioButtonGraph.Checked)
            {
                    drawDiag = new GraphikDrawPrim();
                    drawDiag.Show();
                    drawCircleDiag = new Circle();
                    drawCircleDiag.Show(); 
             }
            if (radioButtonChart.Checked)
            {
                if (diag == null || diag.IsDisposed || checkBoxOn2Charts.Checked)
                {
                    diag = new DiagramForm();
                    diag.Show();
                }
                else
                {
                    diag.Redraw();
                }
            }
        }
        /// <summary>
        /// Show informations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonInfo_Click(object sender, EventArgs e)
        {
            AboutAuthor a = new AboutAuthor();
            a.ShowDialog();
        }
        /// <summary>
        /// Select type of chart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxChartStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxChartStyle.Text)
            {
                case "Columns": Settings.typeOfChart = SeriesChartType.Column; break;
                case "Spline": Settings.typeOfChart = SeriesChartType.Spline; break;
                case "Circle": Settings.typeOfChart = SeriesChartType.Pie; break;
                case "Doughnut": Settings.typeOfChart = SeriesChartType.Doughnut; break;
                case "Bar": Settings.typeOfChart = SeriesChartType.Bar; break;
            }
        }
        /// <summary>
        /// Select enable 3D
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxEnable3D_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnable3D.Checked)
            {
                Settings.enable3D = true;
            }
            else {
                Settings.enable3D = false;
            }
        }

        /// <summary>
        /// Selector of marker color
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMarkerSelect_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Settings.ColorOfDiagramMarker[0] = colorDialog1.Color;
                panelMarkerColor.BackColor = colorDialog1.Color;
            }
        }
        /// <summary>
        /// Logic of marker color checkBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxEnMarker_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnMarker.Checked)
            {
                buttonMarkerSelect.Enabled = true;
                Settings.Mstyle[0] = MarkerStyle.Diamond;
            }
            else
            {
                buttonMarkerSelect.Enabled = false;
                Settings.Mstyle[0] = MarkerStyle.None;
            }
        }

        /// <summary>
        /// Double checkBox event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxDoubleArray_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDoubleArray.Checked)
            {
                buttonColorSelect2.Enabled = true;
                checkBoxEnableMarcers2.Enabled = true;
                checkBoxOn2Charts.Enabled = true;
                if (checkBoxEnableMarcers2.Checked)
                {
                    buttonMarkerSelect2.Enabled = true;
                }
                if (checkBox1.Checked)
                {
                    checkBox1.Enabled = true;
                }
            }
            else {
                checkBoxOn2Charts.Enabled = false;
                buttonColorSelect2.Enabled = false;
                checkBoxEnableMarcers2.Enabled = false;
                buttonMarkerSelect2.Enabled = false;
                Settings.SeriesNum = 1;
                checkBox1.Enabled = false;
            }
        }
        /// <summary>
        /// Color select 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColorSelect2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Settings.ColorOfDiagramMember[1] = colorDialog1.Color;
                panelColor2.BackColor = colorDialog1.Color;
            }
        }
        /// <summary>
        /// Marker color select 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMarkerSelect2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Settings.ColorOfDiagramMarker[1] = colorDialog1.Color;
                panelColorMarks2.BackColor = colorDialog1.Color;
            }
        }
        /// <summary>
        /// Set marker style 2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxEnableMarcers2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEnableMarcers2.Checked)
            { buttonMarkerSelect2.Enabled = true;
                Settings.Mstyle[1] = MarkerStyle.Circle;
            }
            else { buttonMarkerSelect2.Enabled = false;
                Settings.Mstyle[1] = MarkerStyle.None;
            }
        }

        /// <summary>
        /// Second chart on/off
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxOn2Charts_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOn2Charts.Checked)
            {
                Settings.TwoCharts = true;
                Settings.SeriesNum = 2;
                checkBox1.Enabled = true;
            }
            else
            {
                Settings.TwoCharts = false;
                checkBox1.Enabled = false;
            }
        }

        private void radioButtonGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonGraph.Checked)
            {
                groupBox4.Enabled = false;
               
                groupBox3.Enabled = false;
                checkBoxDoubleArray.Enabled = false;
            }
            else
            {
                groupBox4.Enabled = true;
               
                groupBox3.Enabled = true;
                checkBoxDoubleArray.Enabled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Settings.FourCharts = true;
            }
            else
            {
                Settings.FourCharts = false;
            }
        }

    }
}