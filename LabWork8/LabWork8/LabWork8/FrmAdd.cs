using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabWork8
{
    public partial class FrmAdd : Form
    {

        public FrmAdd()
        {
            InitializeComponent();
            ListLanguageLoad();
            ListPositionLoad();
        }

        private void ListLanguageLoad()
        {
            cmbLanguage.Items.Clear();
            cmbLanguage.Items.AddRange(Enum.GetNames(typeof(LanguageEnum)));
        }

        private void ListPositionLoad()
        {
            cmbPosition.Items.Clear();
            cmbPosition.Items.AddRange(Enum.GetNames(typeof(PositionEnum)));
        }

        public Tester Tester
        {
            get
            {
                Tester prg = new Tester();
                prg.ID = Convert.ToInt32(this.txtID.Text);
                prg.Surname = this.txtSurname.Text.Trim();
                prg.Name = this.txtName.Text.Trim();
                prg.Middlename = this.txtMiddle.Text.Trim();
                prg.Birthday = this.dtBirthday.Value;
                prg.Language = (LanguageEnum)this.cmbLanguage.SelectedIndex;
                prg.Position = (PositionEnum)this.cmbPosition.SelectedIndex;
                prg.Expirience = (int)this.numExperience.Value;
                prg.Salary = (int)this.numSalary.Value;

                return prg;
            }

            set
            {
                this.txtID.Text = value.ID.ToString();
                this.txtSurname.Text = value.Surname;
                this.txtName.Text = value.Name;
                this.txtMiddle.Text = value.Middlename;
                this.dtBirthday.Value = value.Birthday;
                this.cmbLanguage.SelectedIndex = (int)value.Language;
                this.cmbPosition.SelectedIndex = (int)value.Position;
                this.numExperience.Value = value.Expirience;
                this.numSalary.Value = value.Salary;
            }
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            this.btnOKAdd.Enabled = this.txtSurname.Text.Trim() != "" && this.txtName.Text.Trim() != "" && this.txtMiddle.Text.Trim() != "";
        }
    }
}
