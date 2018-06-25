namespace LabWork8
{
    partial class FrmAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.btnOKAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtBirthday = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numSalary = new System.Windows.Forms.NumericUpDown();
            this.numExperience = new System.Windows.Forms.NumericUpDown();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.txtMiddle = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExperience)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(154, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Oтмена";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnOKAdd
            // 
            this.btnOKAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOKAdd.Enabled = false;
            this.btnOKAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOKAdd.Location = new System.Drawing.Point(235, 284);
            this.btnOKAdd.Name = "btnOKAdd";
            this.btnOKAdd.Size = new System.Drawing.Size(75, 23);
            this.btnOKAdd.TabIndex = 7;
            this.btnOKAdd.Text = "OK";
            this.btnOKAdd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.dtBirthday);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numSalary);
            this.panel1.Controls.Add(this.numExperience);
            this.panel1.Controls.Add(this.cmbPosition);
            this.panel1.Controls.Add(this.cmbLanguage);
            this.panel1.Controls.Add(this.txtMiddle);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Location = new System.Drawing.Point(6, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 271);
            this.panel1.TabIndex = 6;
            // 
            // dtBirthday
            // 
            this.dtBirthday.Location = new System.Drawing.Point(124, 118);
            this.dtBirthday.Name = "dtBirthday";
            this.dtBirthday.Size = new System.Drawing.Size(181, 20);
            this.dtBirthday.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(32, 124);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "Дата рождения";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(18, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Заработная плата";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(43, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Стаж работы";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(49, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Должность";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(37, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Технология";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(60, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(88, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(60, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Идентификатор";
            // 
            // numSalary
            // 
            this.numSalary.Location = new System.Drawing.Point(123, 224);
            this.numSalary.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numSalary.Name = "numSalary";
            this.numSalary.Size = new System.Drawing.Size(82, 20);
            this.numSalary.TabIndex = 7;
            // 
            // numExperience
            // 
            this.numExperience.Location = new System.Drawing.Point(123, 198);
            this.numExperience.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numExperience.Name = "numExperience";
            this.numExperience.Size = new System.Drawing.Size(82, 20);
            this.numExperience.TabIndex = 6;
            // 
            // cmbPosition
            // 
            this.cmbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(123, 171);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(182, 21);
            this.cmbPosition.TabIndex = 5;
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(123, 144);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(182, 21);
            this.cmbLanguage.TabIndex = 4;
            // 
            // txtMiddle
            // 
            this.txtMiddle.Location = new System.Drawing.Point(123, 92);
            this.txtMiddle.Name = "txtMiddle";
            this.txtMiddle.Size = new System.Drawing.Size(182, 20);
            this.txtMiddle.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(182, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(123, 40);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(182, 20);
            this.txtSurname.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(123, 14);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(82, 20);
            this.txtID.TabIndex = 0;
            // 
            // FrmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 319);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnOKAdd);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAdd";
            this.Text = "FrmAdd";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSalary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExperience)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button btnOKAdd;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DateTimePicker dtBirthday;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown numSalary;
        public System.Windows.Forms.NumericUpDown numExperience;
        public System.Windows.Forms.ComboBox cmbPosition;
        public System.Windows.Forms.ComboBox cmbLanguage;
        public System.Windows.Forms.TextBox txtMiddle;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtSurname;
        public System.Windows.Forms.TextBox txtID;
    }
}