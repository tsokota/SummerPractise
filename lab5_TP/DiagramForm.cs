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
using System.Windows.Forms.DataVisualization;

namespace Diagrams_lab5_
{
    public partial class DiagramForm : Form
    {
        public DiagramForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Draw chart wih all settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DiagramForm_Load(object sender, EventArgs e)
        {
            //set full screan form
            WindowState = FormWindowState.Maximized;
            Point point = new Point(this.Location.X, this.Location.Y + 10);
            chart1.Location = point;
            chart1.Width = this.Width;
            chart1.Height = this.Height - 10;
            int ChartsNum;
            Series newSerie = new Series();
            chart1.ChartAreas[0].Name = "PriceIncreaseUkr";
            if (Settings.TwoCharts)
            {
                ChartArea newArea = new ChartArea();
                newArea.Name = "PriceIncrease_Rus";
                chart1.ChartAreas.Add(newArea);
                newSerie.ChartArea = "PriceIncrease_Rus";
                ChartsNum = 2;
                if (Settings.FourCharts && Settings.amountOfWages.Length == 2 && Settings.amountOfWages[1] != null)
                {
                    Series newSeris3 = new Series();
                    chart1.Series.Add(newSeris3);
                    newSeris3.ChartArea = "Price increase Ukr";
                    Series newSeris4 = new Series();
                    chart1.Series.Add(newSeris4);
                    newSeris4.ChartArea = "Price increase Rus";
                    Settings.SeriesNum = 4;
                }
            }
            else {
                ChartsNum = 1;
            }
            if (Settings.TwoCharts || Settings.SeriesNum == 2)
            {
                chart1.Series.Add(newSerie);
            }
            for (int j = 0; j < ChartsNum; ++j)
            {
                chart1.ChartAreas[j].AxisX.TitleFont = Settings.fontOfDiagram;
                chart1.ChartAreas[j].AxisY.TitleFont = Settings.fontOfDiagram;
                chart1.ChartAreas[j].AxisX.LabelAutoFitMinFontSize = (int)Settings.fontOfDiagram.Size;
                chart1.ChartAreas[j].AxisY.LabelAutoFitMinFontSize = (int)Settings.fontOfDiagram.Size;
                //set 3d stile
                ChartArea3DStyle N3d = new ChartArea3DStyle();
                if (Settings.enable3D)
                {
                    N3d.Enable3D = true;
                }
                else
                {
                    N3d.Enable3D = false;
                }
                chart1.ChartAreas[j].Area3DStyle = N3d;
                //Title settings set
                chart1.ChartAreas[j].AxisX.Title = " Year (y)";
                chart1.ChartAreas[j].AxisX.TitleAlignment = StringAlignment.Near;
                chart1.ChartAreas[j].AxisY.Title = " Price increase (%)";
                chart1.ChartAreas[j].AxisY.TitleAlignment = StringAlignment.Center;
            }
            for (int i = 0; i < Settings.SeriesNum; ++i)
            {
                    chart1.Series[i].ChartType = Settings.typeOfChart;
                    //setrs all  fonts
                    chart1.Series[i].Font = Settings.fontOfDiagram;
                   
                    //series name set
                    if (Settings.legend == true)
                    {
                        if (i == 0)
                            chart1.Series[i].Name = "Price increase  Ukr ";
                        if (i == 1)
                            chart1.Series[i].Name = "Price increase Rus ";
                    }
                    else { chart1.Series[i].IsVisibleInLegend = false; }
                //draw chart obj with current cordinate
                int index = i;
                if (i >= 2)
                {
                        index = i - 2;
                }
                chart1.Series[i].Points.DataBindXY(Settings.yeras[index], Settings.amountOfWages[index]);
                    //Set color
                    chart1.Series[i].Color = Settings.ColorOfDiagramMember[index];
                    chart1.Series[i].BackGradientStyle = GradientStyle.TopBottom;

                    //Label settings
                    chart1.Series[i].IsValueShownAsLabel = true;
                    //Marks settings
                    chart1.Series[i].MarkerStyle = Settings.Mstyle[index];
                    chart1.Series[i].MarkerColor = Settings.ColorOfDiagramMarker[index];
                    chart1.Series[i].MarkerSize = 10;         
            }
        }

        public void Redraw()
        {
            DiagramForm_Load(null, null);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
