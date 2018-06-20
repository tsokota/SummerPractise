using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassOper;

namespace TP_lb3_Mass
{
    public partial class Form1 : Form
    {
        public int Max, Min; //максимальный и минимальный диапазон генерированых чисел
        ClassOperations l = new ClassOperations();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {  // настройка формы
            button1.Focus();
            textBox1.BorderStyle = BorderStyle.None;
            textBox2.BorderStyle = BorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            button1.Focus();

        }

        private void button1_Click(object sender, EventArgs e)
        {  //кнопка генерации массива
            textBox1.Text = null;
            dataGridView1.Rows.Clear();
            Max = Convert.ToInt32(numericUpDown3.Value);
            Min = Convert.ToInt32(numericUpDown2.Value);
            l.GenerMass(Convert.ToInt32(numericUpDown1.Value), Min,
                Max);
            for (int i = 0; i < l.Mass.Length; i++)
            { // вывод массива в текстбокс1
                if (i == l.Mass.Length - 1)
                    textBox1.Text += l.Mass[i];
                else
                    textBox1.Text += l.Mass[i] + ", ";
                dataGridView1.Rows.Add(i, l.Mass[i]);
            }
            button2.Enabled = true;
            groupBox1.Enabled = true;
        }

        private void numericUpDown2_Click(object sender, EventArgs e)
        {  // обработчик  numericUpDown
            if (Convert.ToInt32(numericUpDown2.Value) > Convert.ToInt32(numericUpDown3.Value))
                button1.Enabled = false;
            else
                button1.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {  // кнопка Help
            string hlp = "№1:\n   Вычислить суммы элементов больших и меньших С1 с нечетными номерами.\n\n" +
                "№2:\n   Отсортировать элементы массива по возрастанию.\n\n" +
                "№3:\n   Определить сумму и количество чисел, меньших С1 и больших С2 (С1 < С2).\n\n" +
                "№4:\n   Вычислить математическое ожидание и дисперсию квадратов элементов массива.";

            MessageBox.Show(hlp, "Информация об операциях");
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {  // обработчик  numericUpDown
            if (Convert.ToInt32(numericUpDown5.Value) >= Convert.ToInt32(numericUpDown4.Value) && radioButton3.Checked)
                button6.Enabled = false;
            else
                button6.Enabled = true;
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {  // обработчик  radioButton - выбор операции
            if (radioButton1.Checked)
            {  // 1 операция
                numericUpDown5.Enabled = true;
                numericUpDown4.Enabled = false;
                button6.Enabled = true;

            }
            else if (radioButton3.Checked)
            {   // 3 операция
                numericUpDown5.Enabled = true;
                numericUpDown4.Enabled = true;
                numericUpDown4.Value = 1;
                numericUpDown5.Value = 0;
                numericUpDown4.Maximum = 3000;
                numericUpDown4.Minimum = -1000;
                numericUpDown5.Maximum = 3000;
                numericUpDown5.Minimum = -1000;
                button6.Enabled = true;
            }
            else
            {  // 2,4 операция
                numericUpDown5.Enabled = false;
                numericUpDown4.Enabled = false;
                button6.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { // кнопка Сохранить в F1
            SaveFileDialog SDial = new SaveFileDialog()
            {  //обработчик  SaveFileDialog
                FileName = ".json",
                Filter = "Файлы JSON (*.json)|*.json|Все файлы (*.*)|*.*"
            };

            if (SDial.ShowDialog() == DialogResult.OK)
            {
                if (!l.SerelMass(SDial.FileName))
                    MessageBox.Show("Ошибка при сериализации!\nВозможно, вы перепутали файл :)", "Error");
                else
                    button3.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {  // кнопка Загрузить из F1
            OpenFileDialog ODial = new OpenFileDialog()
            { //обработчик  OpenFileDialog
                FileName = ".json",
                Filter = "Файлы JSON (*.json)|*.json|Все файлы (*.*)|*.*"
            };

            if (ODial.ShowDialog() == DialogResult.OK)
            {
                if (l.DeSerelMass(ODial.FileName))
                {
                    textBox1.Text = null;
                    dataGridView1.Rows.Clear();
                    for (int i = 0; i < l.Mass.Length; i++)
                    {
                        if (i == l.Mass.Length - 1)
                            textBox1.Text += l.Mass[i];
                        else
                            textBox1.Text += l.Mass[i] + ", ";
                        dataGridView1.Rows.Add(i, l.Mass[i]);
                    }
                }
                else
                    MessageBox.Show("Ошибка при десериализации!\nВозможно, вы перепутали файл :)", "Error");
            }

        }

        private void button4_Click(object sender, EventArgs e)
        { //кнопка сохранить в F2
            SaveFileDialog SDial = new SaveFileDialog()
            { //обработчик  SaveFileDialog
                FileName = ".json",
                Filter = "Файлы JSON (*.json)|*.json|Все файлы (*.*)|*.*"
            };

            if (SDial.ShowDialog() == DialogResult.OK)
            {
                if (!l.SerelChangMass(SDial.FileName, "Исходный массив: " + textBox1.Text + "\n Результат обработки: " + textBox2.Text))
                    MessageBox.Show("Ошибка при сериализации!\nВозможно, вы перепутали файл :)", "Error");
                else
                    button5.Enabled = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        { //кнопка вывести из F2
            OpenFileDialog ODial = new OpenFileDialog()
            {//обработчик  OpenFileDialog
                FileName = ".json",
                Filter = "Файлы JSON (*.json)|*.json|Все файлы (*.*)|*.*"
            };

            if (ODial.ShowDialog() == DialogResult.OK)
            {
                if (l.DeSerelChangMass(ODial.FileName))
                    MessageBox.Show(l.TmpTxt, "Info");
                else
                    MessageBox.Show("Ошибка при десериализации!\nВозможно, вы перепутали файл :)", "Error");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {  // кнопка выполнить
            if (radioButton1.Checked)
            {  // 1 операция
                l.Oper1(Convert.ToInt32(numericUpDown5.Value));
                textBox2.Text = "Sum(<C) = " + l.Summ1 + "   Sum(>C) = " + l.Summ2;
            }
            else if (radioButton2.Checked)
            { // 2 операция
                l.Oper2();
                textBox2.Text = null;
                for (int i = 0; i < l.MassAft.Length; i++)
                {
                    if (i == l.MassAft.Length - 1)
                        textBox2.Text += l.MassAft[i];
                    else
                        textBox2.Text += l.MassAft[i] + ", ";
                }
            }
            else if (radioButton3.Checked)
            { // 3 операция
                l.Oper3(Convert.ToInt32(numericUpDown5.Value), Convert.ToInt32(numericUpDown4.Value));
                textBox2.Text = "Sum = " + l.Summ1 + "     Колличество: " + l.Num;
            }
            else
            {// 4 операция
                l.Oper4();
                textBox2.Text = $"Sr =  {l.Sr:0.##}     D =  {l.D:0.##}";
            }
            button4.Enabled = true;
            groupBox3.Enabled = true;
        }
    }
}
