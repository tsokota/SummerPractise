using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;
namespace TP2_laba_6
{
    public partial class Form1 : Form
    {
        double Lenght = 160;
        Graphics graphics;
        SolidBrush col1;
        Color color1=Color.Black;
        Color color2=Color.White;
        ColorDialog mon = new ColorDialog();
        Rectangle rect = new Rectangle(5, 5, 500, 500);
        public Form1()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 1000;
            timer1.Enabled = true;
            graphics = this.CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            openFileDialog1.Filter = "Text files(*.json)|*.json|All files(*.*)|*.*";
            saveFileDialog1.Filter = "Text files(*.json)|*.json|All files(*.*)|*.*";
        }

        private void Form1_Shown(object sender, EventArgs e)//открытие формы
        {
            FormBorderStyle = FormBorderStyle.None;
            AllowTransparency = true;
            BackColor = Color.AliceBlue;//цвет фона  
            TransparencyKey = this.BackColor;
        }


        private void PaintArrows(DateTime dt)//прорисовка стрелок и значений цифровых часов
        {
            
            graphics.FillEllipse( col1 = new SolidBrush(color2), 75,75,375,375);

            graphics.DrawRectangle(new Pen(Color.Black,3),157,390,200,40);
            graphics.DrawString(dt.Hour+": "+dt.Minute+": "+dt.Second,new Font ("Arial", 30), new SolidBrush(Color.Black), new Point(160, 390));
            graphics.FillEllipse(col1=new SolidBrush(color1), 250, 250, 10, 10);

            graphics.DrawLine(
                new Pen(color1, 1),
                new Point(255, 255),
                new Point((int)(255 + (Lenght - 4) * Math.Sin(2 * Math.PI / 60 * dt.Second)), (int)(255 - (Lenght - 4) * Math.Cos(2 * Math.PI / 60 * dt.Second))));

            graphics.DrawLine(
                new Pen(color1, 3),
                new Point(255, 255),
                new Point((int)(255 + (Lenght - 4) * Math.Sin(2 * Math.PI / 60 * dt.Minute)), (int)(255 - (Lenght - 4) * Math.Cos(2 * Math.PI / 60 * dt.Minute))));

            int hour;
            if (dt.Hour <= 12)
            {
                hour = dt.Hour;
            }
            else
            {
                hour = dt.Hour - 12;
            }

            graphics.DrawLine(
                new Pen(color1, 4),
                new Point(255, 255),
                new Point((int)(255 + (Lenght - 30) * Math.Sin(2 * Math.PI / 12 * hour + 2 * Math.PI / (12 * 60) * dt.Minute))+5, (int)(255 - (Lenght - 30) * Math.Cos(2 * Math.PI / 12 * hour + 2 * Math.PI / (12 * 60) * dt.Minute))-5));
        }


        private void timer1_Tick(object sender, EventArgs e)//Событие возникающие через заданные равные промежутки времени
        {
            PaintClock(DateTime.Now);
        }
        private void PaintClock(DateTime dtArg)//вызов события перерисовки формы
        {
           PaintArrows(dtArg);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)//обновление положения стрелок и значений цифровых часов
        {
            Pen bl = new Pen(Color.Black, 6);
           

            graphics.FillEllipse(col1=new SolidBrush(color2), 5, 5, 500, 500);
            graphics.DrawEllipse(bl, 5, 5, 500, 500);
            graphics.FillEllipse(new SolidBrush(Color.Black), 250, 250, 10, 10);
            graphics.DrawString("9", new Font("Arial", 32), new SolidBrush(Color.Black), new Point(10, 234));
            graphics.DrawString("3", new Font("Arial", 32), new SolidBrush(Color.Black), new Point(465, 234));
            graphics.DrawString("12", new Font("Arial", 32), new SolidBrush(Color.Black), new Point(222, 10));
            graphics.DrawString("6", new Font("Arial", 32), new SolidBrush(Color.Black), new Point(236, 455));
            for (int i = 1; i < 12; i++)
            {
                if (i!=3 && i!=6 && i!=9) {
                    graphics.DrawLine(new Pen(Color.Black, 1),
                        new Point((int)(255 + 230 * Math.Cos(Math.PI / 6 * i)),
                        (int)(255 + 230 * Math.Sin(Math.PI / 6 * i))),
                        new Point((int)(255 + 250 * Math.Cos(Math.PI / 6 * i)),
                        (int)(255 + 250 * Math.Sin(Math.PI / 6 * i))));
                }
            }

        }

        private void циферблатаToolStripMenuItem_Click(object sender, EventArgs e)//изменение цвета циферблата
        {
            if (mon.ShowDialog() == DialogResult.OK)
                color2 =mon.Color;
            Rectangle rec = new Rectangle();
            PaintEventArgs es = new PaintEventArgs(graphics, rec);
            Form1_Paint(graphics, es);
        }

        private void стрелокToolStripMenuItem_Click(object sender, EventArgs e)//изменение цвета стрелок
        {
            if (mon.ShowDialog() == DialogResult.OK)
                color1 = mon.Color;
            Rectangle rec = new Rectangle();
            PaintEventArgs es = new PaintEventArgs(graphics, rec);
            Form1_Paint(graphics, es);
        }
        [DataContract]
        class ColorJson//класс для создания объекта для записи в формате json
        {
            [DataMember]
            public Color colo1 { get; set; }
            [DataMember]
            public Color colo2 { get; set; }
            public ColorJson(Color col1, Color col2)
            {
                colo1 = col1;
                colo2 = col2;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)//Закрытие программы
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)//Запись в файл
        { 
            ColorJson color = new ColorJson(color1,color2);
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(ColorJson));
            saveFileDialog1.FileName = "Save_color";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            using (FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, color);
            }

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)//считывание информации
        {
            openFileDialog1.FileName = "Save_color";
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(ColorJson));
            using (FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.OpenOrCreate))
            {
                ColorJson color = (ColorJson)jsonFormatter.ReadObject(fs);
                color1 = color.colo1;
                color2 = color.colo2;
            }
            Rectangle rec = new Rectangle();
            PaintEventArgs es = new PaintEventArgs(graphics, rec);
            Form1_Paint(graphics, es);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)//вызов формы с информацией о разработчике
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)//Реализует возможность перемещать форму
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
