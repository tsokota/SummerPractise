using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lb7_TP
{
    public partial class Form1 : Form
    {
        TesterArr tstArr;
        public Form1()
        {
            InitializeComponent();
            tstArr = new TesterArr();
        }

        private void btnStripExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (MessageBox.Show("Вы  действительно хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        // проверка доступности кнопок
        private void Dostup()
        {
            bool Value = tstArr.Count != 0;
            // Доступность кнопки изменить
            button18.Enabled = Value;
            // Доступность кнопки удалить одного
            button16.Enabled = Value;
            // Доступность кнопки удалить всю группу
            button17.Enabled = Value;
            // Доступность кнопки сортировка
            button13.Enabled = Value;
            // Доступность кнопки фильтрация
            button10.Enabled = Value;
            // Доступность кнопки группировка
            button11.Enabled = Value;
            // Доступность агрегатных функций
            button12.Enabled = Value;

        }

        private void DataGridUpdate()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = tstArr.ToArray();

            if (dataGridView.Columns.Count > 0)
            {
                dataGridView.Columns[1].HeaderText = "Фамилия";
                dataGridView.Columns[2].HeaderText = "Имя";
                dataGridView.Columns[3].HeaderText = "Отчество";
                dataGridView.Columns[4].HeaderText = "Дата рождения";
                dataGridView.Columns[5].HeaderText = "Технология тестирования";
                dataGridView.Columns[6].HeaderText = "Должность";
                dataGridView.Columns[7].HeaderText = "Стаж работы";
                dataGridView.Columns[8].HeaderText = "Зарплата";
            }
                      
        }

        private void btnStripAbout_Click(object sender, EventArgs e)
        {
            // создание экземпляра формы
            using (FrmAbout frm = new FrmAbout())
            {
                frm.ShowDialog();
            }
        }

        private void btnStripGroupGenerate_Click(object sender, EventArgs e)
        {
            using (FrmGenerate frm = new FrmGenerate())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    tstArr.GenerateArray((int)frm.numNumberElement.Value);
                    DataGridUpdate();
                }
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Dostup();
            }
        }

        private void btnStripGroupDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы  действительно хотите очистить базу?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tstArr.Clear();
                DataGridUpdate();
                Dostup();
            }
        }

        private void btnStripOneGenerate_Click(object sender, EventArgs e)
        {
            // создание экземпляра формы
            using (FrmAdd frm = new FrmAdd())
            {
                Tester prg = tstArr.Generate();
                frm.Tester = prg;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    prg = frm.Tester;
                    tstArr.Add(prg);
                    DataGridUpdate();
                }
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Dostup();
            }
        }

        private void btnStripOneAdd_Click(object sender, EventArgs e)
        {
            // создание экземпляра формы
            using (FrmAdd frm = new FrmAdd())
            {
                Tester prg = new Tester();
                prg.ID = tstArr.NewID();
                frm.Tester = prg;

                if (frm.ShowDialog() == DialogResult.OK)
                {
                    prg = frm.Tester;
                    tstArr.Add(prg);
                    DataGridUpdate();
                }
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Dostup();
            }
        }

        private void btnStripChange_Click(object sender, EventArgs e)
        {
            // создание экземпляра формы
            if (dataGridView.RowCount == 0)
                return;
            using (FrmAdd frm = new FrmAdd())
            {
                frm.Text = "Изменить";
                int pID = Convert.ToInt32(dataGridView[0, dataGridView.CurrentRow.Index].Value);

                frm.Tester = tstArr[tstArr.FindIndexFromID(pID)];
                frm.btnOKAdd.Enabled = (frm.txtSurname.Text == "" || frm.txtName.Text == "" || frm.txtMiddle.Text == "") ? true : false;
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    tstArr[tstArr.FindIndexFromID(pID)] = frm.Tester;
                    DataGridUpdate();
                }
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                Dostup();
            }
        }

        private void btnStripOneDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы  действительно хотите удалить запись одного тестировщика?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int pID = Convert.ToInt32(dataGridView[0, dataGridView.CurrentRow.Index].Value);
                tstArr.RemoveAt(pID);
                DataGridUpdate();
                Dostup();
            }

        }

        private void btnStripSort_Click(object sender, EventArgs e)
        {
            // создание экземпляра формы
            using (FrmSort frm = new FrmSort())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    using (FrmResult frm1 = new FrmResult())
                    {
                        frm1.dataGridViewResult.DataSource = null;
                        frm1.dataGridViewResult.DataSource = tstArr.Sort(frm.cmbPropertySort.SelectedIndex, frm.cmbSort.SelectedIndex);
                        frm1.dataGridViewResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        frm1.ShowDialog();
                    }
                }
            }
        }

        private void btnStripFilter_Click(object sender, EventArgs e)
        {
            // создание экземпляра формы
            using (FrmFilter frm = new FrmFilter())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    using (FrmResult frm1 = new FrmResult())
                    {
                        frm1.dataGridViewResult.DataSource = null;
                        frm1.dataGridViewResult.DataSource = tstArr.Filtr(frm.cmbProperty.SelectedIndex, frm.cmbCondition.SelectedIndex, frm.txtFiltr.Text);
                        frm1.dataGridViewResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        frm1.ShowDialog();
                    }
                }
            }
        }

        private void btnStripGroupMake_Click(object sender, EventArgs e)
        {
            // создание экземпляра формы
            using (FrmGroup frm = new FrmGroup())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    using (FrmResult frm1 = new FrmResult())
                    {
                        frm1.dataGridViewResult.DataSource = null;
                        frm1.dataGridViewResult.DataSource = tstArr.Group(frm.cmbPropertyGroup.SelectedIndex);
                        frm1.dataGridViewResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        frm1.ShowDialog();
                    }
                }
            }
        }

        private void btnStripAgregateFunction_Click(object sender, EventArgs e)
        {
            // создание экземпляра формы
            using (FrmAgregate frm = new FrmAgregate())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    using (FrmResult frm1 = new FrmResult())
                    {
                        frm1.dataGridViewResult.DataSource = null;
                        frm1.dataGridViewResult.DataSource = tstArr.Agregate(frm.cmbPropertyAgregate.SelectedIndex);
                        frm1.dataGridViewResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        frm1.ShowDialog();
                    }
                }
            }
        }


    }
}
