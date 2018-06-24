using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Diagrams_lab5_
{
    public partial class GraphikDrawPrim : Form
    {
        private Label[] labelsOy;
        private Label[] labelsCol;
        private Button button = new Button();
        Point zeroCoord;
        Point oY;
        Point oX;
        int coordHeight;
        int coordWidth;
        int StepY;
        int columnNum;
        int columnWidth;
        int yCoordCoefficient;
        public GraphikDrawPrim()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Set start window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GraphikDrawPrim_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;    
            zeroCoord = new Point(50, this.Height-100);
            oX = new Point(this.Width - 150, this.Height-100);
            oY = new Point(50, 50);
            coordHeight = zeroCoord.Y - oY.Y;
            coordWidth = oX.X - zeroCoord.X;
            labelName.Location = new Point(coordWidth / 2, oY.Y - 30);
            labelYears.Location = new Point(zeroCoord.X, zeroCoord.Y + 20);
            labelAvg.Location = new Point(oY.X - 50, oY.Y - 20);
        }
        public void Redraw()
        {
            GraphikDrawPrim_Paint(null, null);
        }
        /// <summary>
        /// Size bar count
        /// </summary>
        private void ReCount()
        {
            columnNum = Settings.amountOfWages[0].Length;
            StepY = (int)(coordHeight / (columnNum + 1));
            columnWidth = (int)(StepY * 2 / 3);
            yCoordCoefficient = (int)(coordWidth / (int)(Settings.amountOfWages[0].Max()));
        }
        /// <summary>
        /// Draw oY oX and bars
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GraphikDrawPrim_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            //draw ox oy
            Size Yline = new Size(2, this.Height - 150);
            Size Xline = new Size(this.Width - 200, 2);
            Rectangle fone = new Rectangle(oY, new Size(coordWidth, coordHeight));
            Rectangle rctY = new Rectangle(oY, Yline);
            Rectangle rctX = new Rectangle(zeroCoord, Xline);
            gr.FillRectangle(Brushes.White, fone);
            gr.FillRectangle(Brushes.Black, rctY);
            gr.FillRectangle(Brushes.Black, rctX);
            DrawBars(gr);
        }

        private void DrawBars(Graphics gr) {
            //column draw
            ReCount();       
            Point currentColumnCoord;
            Rectangle currentColumn;
            Rectangle currentDash;
            Size columnSize = new Size(0, columnWidth);
            Size dash = new Size(10, 2);
            for (int i = 0; i < columnNum; ++i)
            {
                columnSize.Width = (int)(yCoordCoefficient * Settings.amountOfWages[0][i] * 0.9);
                if (columnSize.Width == 0)
                { columnSize.Width = 2; }
                currentColumnCoord = new Point(zeroCoord.X + 2, oY.Y + StepY*(i + 1));
                currentColumn = new Rectangle(currentColumnCoord, columnSize);
                //dashes
                currentColumnCoord.Y += (columnWidth / 2);
                currentDash = new Rectangle(currentColumnCoord, dash);
                //draw elements
                gr.FillRectangle(Brushes.BlueViolet, currentColumn);
                Pen pen = new Pen(Brushes.Blue, 1);
                gr.DrawRectangle(pen, currentColumn);
                gr.FillRectangle(Brushes.Black, currentDash);

            }
            Size dashLabelSize = new Size(35, 15);
            Point dashPoint = new Point((int)(yCoordCoefficient * Settings.amountOfWages[0].Max() * 0.9 + zeroCoord.X), zeroCoord.Y - 10);
            Rectangle oyDash1 = new Rectangle(dashPoint, new Size(2, 10));
            Label deshLabel1 = new Label();
            deshLabel1.Location = new Point(dashPoint.X - 15,dashPoint.Y + 15);
            deshLabel1.Size = dashLabelSize;
            deshLabel1.Visible = true;
            deshLabel1.Text = ((int)(Settings.amountOfWages[0].Max())).ToString();
            this.Controls.Add(deshLabel1);
            dashPoint.X =(int)(dashPoint.X / 2) + zeroCoord.X;
            Rectangle oyDash2 = new Rectangle(dashPoint, new Size(2, 10));
            gr.FillRectangle(Brushes.Black, oyDash1);
            gr.FillRectangle(Brushes.Black, oyDash2);
            Label deshLabel2 = new Label();
            deshLabel2.Text = ((int)(Settings.amountOfWages[0].Max() / 2)).ToString();
            deshLabel2.Size = dashLabelSize;
            deshLabel2.Visible = true;
            deshLabel2.Location = new Point(dashPoint.X - 15, dashPoint.Y + 15);
            this.Controls.Add(deshLabel2);
            LabelGen();
        }

        public void LabelGen()
        {
            labelsCol = new Label[columnNum];
            labelsOy = new Label[columnNum];
            Size labelSize = new Size(35, 15);
            Point labelPoint;
            for (int i = 0; i < columnNum; ++i)
            {
                //oy labels add
                labelsOy[i] = new Label();
                labelPoint = new Point (zeroCoord.X - 35, oY.Y + StepY * (i + 1) +(int)(columnWidth / 2) - 15);
                labelsOy[i].Location = labelPoint;
                labelsOy[i].Size = labelSize;
                labelsOy[i].Visible = true;
                labelsOy[i].Text = Settings.yeras[0][i].ToString();
                this.Controls.Add(labelsOy[i]);
                //columns labels
                labelsCol[i] = new Label();
                labelPoint = new Point((int)(yCoordCoefficient * Settings.amountOfWages[0][i] * 0.9 + 5 + zeroCoord.X),
                          oY.Y + StepY * (i + 1) + (int)(columnWidth / 2) - 7);
                labelsCol[i].Location = labelPoint;
                labelsCol[i].Size = labelSize;
                labelsCol[i].Visible = true;
                labelsCol[i].Text = Settings.amountOfWages[0][i].ToString();
                labelsCol[i].BackColor = Color.White;
                this.Controls.Add(labelsCol[i]);
            }
        }

        public int ReCount(int coordWidth,int coordHeight, double pers, int size)
        {
            columnNum = size;
            StepY = (int)(coordHeight / (columnNum + 1));
            columnWidth = (int)(StepY * 2 / 3);
            yCoordCoefficient = (int)(coordWidth / (int)(pers));
            return yCoordCoefficient;
        }

        private void labelInfl_Click(object sender, EventArgs e)
        {

        }
    }
}
