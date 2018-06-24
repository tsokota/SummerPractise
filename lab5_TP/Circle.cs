using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diagrams_lab5_
{
    public partial class Circle : Form
    {
        Point center;
        Point circleLocation;
        Size circleSize;
        Rectangle mainCircle;
        int pieNum;
        double coefficient;
        Label[] valueLabel;
        Label[] yearLabel;

        public Circle()
        {
            InitializeComponent();
        }

        private void CircleDiag_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            center = new Point((int)(this.Width / 2), (int)(this.Height / 2));
            circleSize = new Size((int)(this.Width / 2.2), (int)(this.Width / 2.2));
            circleLocation = new Point((int)(center.X - circleSize.Width / 2), (int)(center.Y - circleSize.Width / 2));
            labelTitle.Location = new Point((int)(this.Width / 2 - this.Width * 0.08), (int)(this.Height - this.Height *0.97));
            valueLabel = new Label[Settings.amountOfWages[0].Length];
            yearLabel = new Label[valueLabel.Length];
        }

        private void CountParam()
        {
            coefficient = 360 / Settings.amountOfWages[0].Sum();
            pieNum = Settings.amountOfWages[0].Length;
        }

        private void CircleDiag_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            mainCircle = new Rectangle(circleLocation, circleSize);
            CountParam();   
            FillCirclePie(gr);
            labelYearGen(gr);
            Pen pen = new Pen(Brushes.Black, 1);
            gr.DrawEllipse(pen, mainCircle);
        }

        private void FillCirclePie(Graphics gr)
        {
            float startAngle = 0;
            float endAngle = 0;
            for (int i = 0; i < pieNum; ++i)
            {
                endAngle = (float)(coefficient * Settings.amountOfWages[0][i]);
                switch (i) {
                    case 0: gr.FillPie(Brushes.OrangeRed, mainCircle, startAngle, endAngle); break;
                    case 1: gr.FillPie(Brushes.Green, mainCircle, startAngle, endAngle); break;
                    case 2: gr.FillPie(Brushes.Orange, mainCircle, startAngle, endAngle); break;
                    case 3: gr.FillPie(Brushes.Aqua, mainCircle, startAngle, endAngle); break;
                    case 4: gr.FillPie(Brushes.DarkBlue, mainCircle, startAngle, endAngle); break;
                    case 5: gr.FillPie(Brushes.Magenta, mainCircle, startAngle, endAngle); break;
                    case 6: gr.FillPie(Brushes.Pink, mainCircle, startAngle, endAngle); break;
                    case 7: gr.FillPie(Brushes.Violet, mainCircle, startAngle, endAngle); break;
                    case 8: gr.FillPie(Brushes.Yellow, mainCircle, startAngle, endAngle); break;
                    case 9: gr.FillPie(Brushes.Brown, mainCircle, startAngle, endAngle); break;
                    case 10: gr.FillPie(Brushes.SlateGray, mainCircle, startAngle, endAngle); break;
                    case 11: gr.FillPie(Brushes.Tan, mainCircle, startAngle, endAngle); break;
                    case 12: gr.FillPie(Brushes.Gray, mainCircle, startAngle, endAngle); break;
                    case 13: gr.FillPie(Brushes.Khaki, mainCircle, startAngle, endAngle); break;
                    case 14: gr.FillPie(Brushes.Blue, mainCircle, startAngle, endAngle); break;
                }
                //float buffStAngle = startAngle;
                startAngle += endAngle;
                //float bisectris = (startAngle - buffStAngle) / 2;
                //int x = (int)(circleSize.Width / 4 * Math.Cos((double)bisectris));
                //int y = (int)(circleSize.Width / 4 * Math.Sin((double)bisectris));
                //Point lablCoord;
                //if (bisectris + buffStAngle > 180 && bisectris + buffStAngle < 270)
                //{
                //    lablCoord = new Point(center.X - x, center.Y - y);
                //}
                //else if(bisectris + buffStAngle >= 0 && bisectris + buffStAngle < 90)
                //{
                //    lablCoord = new Point(center.X + x, center.Y - y);
                //}
                //else if (bisectris + buffStAngle >= 90 && bisectris + buffStAngle <= 180)
                //{
                //    lablCoord = new Point(center.X - x, center.Y + y);
                //}
                //else
                //{
                //    lablCoord = new Point(center.X + x, center.Y - y);
                //}

                //pie labels add
            }
        }

        private void labelValueGen()
        { }
        private void labelYearGen(Graphics gr) {
            Size labelSize = new Size(35, 15);
            Size markSize = new Size(15,15);
            Rectangle colorMark;
            Point labelPoint;
            Point recPoint;
            int step = 20;
            for (int i = 0; i < pieNum; ++i)
            {
                //year labels add
                yearLabel[i] = new Label();
                labelPoint = new Point((int)(this.Width * 0.9), (int)(this.Height * 0.1 + step*i));
                yearLabel[i].Location = labelPoint;
                yearLabel[i].Size = labelSize;
                yearLabel[i].Visible = true;
                yearLabel[i].Text = Settings.yeras[0][i].ToString();
                this.Controls.Add(yearLabel[i]);
                recPoint = new Point(labelPoint.X - 25, labelPoint.Y);
                colorMark = new Rectangle(recPoint, new Size(20,15));
                switch (i)
                {
                    case 0: gr.FillRectangle(Brushes.OrangeRed, colorMark); break;
                    case 1: gr.FillRectangle(Brushes.Green, colorMark); break;
                    case 2: gr.FillRectangle(Brushes.Orange, colorMark); break;
                    case 3: gr.FillRectangle(Brushes.Aqua, colorMark); break;
                    case 4: gr.FillRectangle(Brushes.DarkBlue, colorMark); break;
                    case 5: gr.FillRectangle(Brushes.Magenta, colorMark); break;
                    case 6: gr.FillRectangle(Brushes.Pink, colorMark); break;
                    case 7: gr.FillRectangle(Brushes.Violet, colorMark); break;
                    case 8: gr.FillRectangle(Brushes.Yellow, colorMark); break;
                    case 9: gr.FillRectangle(Brushes.Brown, colorMark); break;
                    case 10: gr.FillRectangle(Brushes.SlateGray, colorMark); break;
                    case 11: gr.FillRectangle(Brushes.Tan, colorMark); break;
                    case 12: gr.FillRectangle(Brushes.Gray, colorMark); break;
                    case 13: gr.FillRectangle(Brushes.Khaki, colorMark); break;
                    case 14: gr.FillRectangle(Brushes.Blue, colorMark); break;
                }
                valueLabel[i] = new Label();
                valueLabel[i].Location = new Point(recPoint.X - 60,recPoint.Y);
                valueLabel[i].Size = new Size(50, 15);
                valueLabel[i].Visible = true;
                valueLabel[i].Text = Settings.amountOfWages[0][i].ToString() + " %";
                valueLabel[i].BackColor = Color.White;
                this.Controls.Add(valueLabel[i]);
            }
        }
        public void Redraw()
        {
            CircleDiag_Paint(null, null);
        }

        private void labelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
