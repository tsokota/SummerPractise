using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork2
{
    public partial class Form1 : Form
    {
        public double a, b, c, d, x1, x2;   // Коефициенты и корни кв. ур-я 
        public int Meth = 1;  //номер метода решения
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {    // Кнопка РЕШИТЬ
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" ||
                textBox1.Text == "-" || textBox2.Text == "-" || textBox3.Text == "-")
            {  // неккоректный ввод
                MessageBox.Show("Неккоректные данные!", "ERROR!");
                label1.Focus();
                return;
            }
            else if (Convert.ToDouble(textBox1.Text) == 0)
            {
                MessageBox.Show("Деление на ноль! Измените коефициент 'А'!", "ERROR!");
                label1.Focus();
                return;
            }

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = Convert.ToDouble(textBox3.Text);

            switch (Meth)
            {
                case 1: //Решение в классе
                    string X1 = null, X2 = null;
                    Meth3InClass l = new Meth3InClass();
                    l.Meth3InCls(a, b, c, ref X1, ref X2);
                    label1.Text = X1;
                    label2.Text = X2;
                    break;
                case 2:  //Решение в форме
                    X1 = null; X2 = null;
                    Form1 k = new Form1();
                    k.Meth2InForm(a, b, c, ref X1, ref X2);
                    label1.Text = X1;
                    label2.Text = X2;
                    break;
                case 3:  //Решение в обработчике
                    d = b * b - 4 * a * c;
                    if (d == 0)
                    {   //Дискриминант равен 0
                        x1 = (-b / (2 * a));
                        if (x1 >= 0.01 || x1 <= -0.01)
                            label1.Text = String.Format("{0:0.##}", x1);
                        else
                            label1.Text = String.Format("{0:G1}", x1);
                        label2.Text = label1.Text;
                    }
                    else if (d > 0)
                    {  //Дискриминант больше 0
                        x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                        x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                        if (x1 >= 0.01 || x1 <= -0.01)
                            label1.Text = String.Format("{0:0.##}", x1);
                        else
                            label1.Text = String.Format("{0:G1}", x1);
                        if (x2 >= 0.01 || x2 <= -0.01)
                            label2.Text = String.Format("{0:0.##}", x2);
                        else
                            label2.Text = String.Format("{0:G1}", x2);
                    }
                    else
                    {  //Дискриминант меньше 0
                        double part1, part2;
                        d *= -1;
                        part1 = -1 * b / (2 * a);
                        part2 = Math.Sqrt(d) / (2 * a);
                        if (part2 < 0)
                            part2 *= -1;
                        label1.Text = String.Format("{0:0.##}", part1) + "-" + String.Format("{0:0.##}", part2) + "i";
                        label2.Text = String.Format("{0:0.##}", part1) + "+" + String.Format("{0:0.##}", part2) + "i";
                    }
                    break;
            }
            label1.Focus();
        }

        public void Meth2InForm(double a, double b, double c, ref string X1, ref string X2)
        {  //Решение в форме
            double d, x1, x2;
            d = b * b - 4 * a * c;
            if (d == 0)
            {  //Дискриминант равен 0
                x1 = (-b / (2 * a));
                if (x1 >= 0.01 || x1 <= -0.01)
                    X1 = String.Format("{0:0.##}", x1);
                else
                    X1 = String.Format("{0:G1}", x1);
                X2 = X1;
            }  //Дискриминант больше 0
            else if (d > 0)
            {
                x1 = ((-b - Math.Sqrt(d)) / (2 * a));
                x2 = ((-b + Math.Sqrt(d)) / (2 * a));
                if (x1 >= 0.01 || x1 <= -0.01)
                    X1 = String.Format("{0:0.##}", x1);
                else
                    X1 = String.Format("{0:G1}", x1);
                if (x2 >= 0.01 || x2 <= -0.01)
                    X2 = String.Format("{0:0.##}", x2);
                else
                    X2 = String.Format("{0:G1}", x2);
            }
            else
            {  //Дискриминант меньше 0
                double part1, part2;
                d *= -1;
                part1 = -1 * b / (2 * a);
                part2 = Math.Sqrt(d) / (2 * a);
                if (part2 < 0)
                    part2 *= -1;
                X1 = String.Format("{0:0.##}", part1) + "-" + String.Format("{0:0.##}", part2) + "i";
                X2 = String.Format("{0:0.##}", part1) + "+" + String.Format("{0:0.##}", part2) + "i";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {  // Обработчик изменеий в текстБоксах
            TextBox textBox = (sender as TextBox);
            if (textBox.Text.Length > 1 && textBox.Text[0] == '0' && textBox.Text[1] != ',')
                textBox.Text = textBox.Text.Substring(1, textBox.Text.Length - 1);
            if (textBox.Text != "" && textBox.Text[0] == ',')
                textBox.Text = "0," + textBox.Text.Substring(1, textBox.Text.Length - 1);
            if (textBox.Text.Length > 2 && textBox.Text[0] == '-' && textBox.Text[1] == '0' && (textBox.Text[2] >= '0' && textBox.Text[2] <= '9'))
                textBox.Text = "-" + textBox.Text.Substring(2);
            textBox.SelectionStart = textBox.Text.Length;
            textBox.Focus();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {  // установка   errorProvider
            TextBox textBox = (sender as TextBox);
            if (textBox.Text == "")
                errorProvider1.SetError(textBox, "Введите коефициент!");
            else
                errorProvider1.SetError(textBox, "");
            if (textBox1.Text == "0")
                errorProvider1.SetError(textBox1, "Коефициент не может равнятся нулю!");
        }

        private void button2_Click(object sender, EventArgs e)
        {  // очистить все поля
            radioButton1.Checked = true;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            label1.Text = null;
            label2.Text = null;
            errorProvider1.SetError(textBox1, "");
            errorProvider1.SetError(textBox2, "");
            textBox1.Focus();
            errorProvider1.SetError(textBox3, "");
        }

        private void button3_Click(object sender, EventArgs e)
        { // Кнопка выхода из формы
            errorProvider1.SetError(textBox1, "");
            errorProvider1.SetError(textBox2, "");
            errorProvider1.SetError(textBox3, "");
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "EXIT", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
                Environment.Exit(0);
            textBox1.Focus();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // обработчик события отпуска клавиши в окне ввода
            if (e.KeyCode == Keys.Delete)
                e.SuppressKeyPress = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {     // обработчик события нажатия клавиши в окне ввода
            TextBox textBox = (sender as TextBox);
            try
            {
                textBox.Focus();
                if (Char.IsDigit(e.KeyChar) || (e.KeyChar == '-') || (e.KeyChar == ','))
                {
                    switch (e.KeyChar)
                    {
                        case '0':
                            if (textBox.Text == "-")
                                return;
                            if (textBox.Text.Length > 0 && textBox.Text[0] == '-' && textBox.SelectionStart == 1)
                                e.KeyChar = (char)Keys.None; break;
                        case '-':  // клавиша '-'
                            if (textBox.Text.Length > 0 && textBox.Text[0] != '-' && textBox.SelectionStart == 0)
                                return;
                            if (textBox.Text.Length != 0)
                                e.KeyChar = (char)Keys.None; break;
                        case ',':     // клавиша ','
                            if (textBox.SelectionStart < textBox.Text.Length - 2)
                            {
                                e.KeyChar = (char)Keys.None; break;
                            }  // проверка на корректность ввода ',' при диапазоне
                            else if (textBox.Text.IndexOf('-') == 0 && textBox.SelectionStart == 1)
                                if (textBox.Text == "-")
                                {
                                    textBox.Text = null;
                                    e.KeyChar = (char)Keys.None; break;
                                }  // проверка на корректность ввода ',' при диапазоне
                                else if (textBox.Text.IndexOf('-') == 0 && textBox.SelectionStart == 1)
                                {
                                    e.KeyChar = (char)Keys.None; break;
                                }  // проверка на корректность ввода ',' при диапазоне

                            if (textBox.Text == "1000000" || textBox.Text == "-1000000" || (textBox.Text.IndexOf(',') != (-1)) || textBox.Text == "")
                                e.KeyChar = (char)Keys.None; break;
                    }   // если символ  ',' присутствует и после него уже имеется 2 цифры
                    if ((((textBox.Text).Length - 1) - textBox.Text.IndexOf(',')) > 1 && textBox.Text.IndexOf(',') != -1 &&
                                                         textBox.SelectionStart > textBox.Text.Length - 2 || textBox.Text.Length == 9)
                        e.KeyChar = (char)Keys.None;
                    if (textBox.Text.IndexOf('-') != -1 && textBox.SelectionStart == 0)
                    {
                        e.KeyChar = (char)Keys.None; return;
                    }
                    // если выход за перделы диапазона
                    if (textBox.Text != "" && (Convert.ToDouble(textBox.Text + e.KeyChar) > 1000000 || Convert.ToDouble(textBox.Text + e.KeyChar) < -1000000))
                        e.KeyChar = (char)Keys.None;
                }      // запрет клавиши Back при значении флага act=false
                else if (e.KeyChar != (char)Keys.Back)
                    e.KeyChar = (char)Keys.None;
                else if (textBox.Text.IndexOf('-') == 0 && textBox.Text.IndexOf(',') == 2 && textBox.SelectionStart == 2 && e.KeyChar == (char)Keys.Back)
                {
                    e.KeyChar = (char)Keys.None; return;
                }
            }
            catch (Exception)
            {
                e.KeyChar = (char)Keys.None;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        { // настройки формы
            textBox1.BorderStyle = BorderStyle.None;
            textBox2.BorderStyle = BorderStyle.None;
            textBox3.BorderStyle = BorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Meth = 1;  // решить методом в классе
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Meth = 2;  // решить методом в форме
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Meth = 3;  // решить в обработчике
        }

   

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
