namespace lb7_TP
{
    partial class FrmFilter
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFiltr = new System.Windows.Forms.TextBox();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.cmbProperty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelFilter = new System.Windows.Forms.Button();
            this.btnOKFilter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtFiltr);
            this.groupBox1.Controls.Add(this.cmbCondition);
            this.groupBox1.Controls.Add(this.cmbProperty);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtFiltr
            // 
            this.txtFiltr.Location = new System.Drawing.Point(67, 72);
            this.txtFiltr.Name = "txtFiltr";
            this.txtFiltr.Size = new System.Drawing.Size(171, 20);
            this.txtFiltr.TabIndex = 5;
            // 
            // cmbCondition
            // 
            this.cmbCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Items.AddRange(new object[] {
            "Равно ",
            "Не равно",
            "Cодержит"});
            this.cmbCondition.Location = new System.Drawing.Point(67, 45);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(171, 21);
            this.cmbCondition.TabIndex = 4;
            // 
            // cmbProperty
            // 
            this.cmbProperty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProperty.FormattingEnabled = true;
            this.cmbProperty.Items.AddRange(new object[] {
            "ID",
            "Фамилия",
            "Имя",
            "Отчество",
            "Дата рождения",
            "Технологии тестирования",
            "Должность",
            "Стаж работы",
            "Зарплата"});
            this.cmbProperty.Location = new System.Drawing.Point(67, 17);
            this.cmbProperty.Name = "cmbProperty";
            this.cmbProperty.Size = new System.Drawing.Size(171, 21);
            this.cmbProperty.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Значение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Проверка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cвойство";
            // 
            // btnCancelFilter
            // 
            this.btnCancelFilter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelFilter.Location = new System.Drawing.Point(86, 118);
            this.btnCancelFilter.Name = "btnCancelFilter";
            this.btnCancelFilter.Size = new System.Drawing.Size(75, 23);
            this.btnCancelFilter.TabIndex = 5;
            this.btnCancelFilter.Text = "Отмена";
            this.btnCancelFilter.UseVisualStyleBackColor = true;
            // 
            // btnOKFilter
            // 
            this.btnOKFilter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOKFilter.Location = new System.Drawing.Point(176, 118);
            this.btnOKFilter.Name = "btnOKFilter";
            this.btnOKFilter.Size = new System.Drawing.Size(75, 23);
            this.btnOKFilter.TabIndex = 4;
            this.btnOKFilter.Text = "OK";
            this.btnOKFilter.UseVisualStyleBackColor = true;
            // 
            // FrmFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancelFilter);
            this.Controls.Add(this.btnOKFilter);
            this.Name = "FrmFilter";
            this.Text = "Фильтр";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox txtFiltr;
        public System.Windows.Forms.ComboBox cmbCondition;
        public System.Windows.Forms.ComboBox cmbProperty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelFilter;
        private System.Windows.Forms.Button btnOKFilter;
    }
}