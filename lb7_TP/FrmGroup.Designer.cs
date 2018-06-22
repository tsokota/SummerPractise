namespace lb7_TP
{
    partial class FrmGroup
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
            this.btnCancelSort = new System.Windows.Forms.Button();
            this.btnOKSort = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPropertyGroup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelSort
            // 
            this.btnCancelSort.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelSort.Location = new System.Drawing.Point(95, 73);
            this.btnCancelSort.Name = "btnCancelSort";
            this.btnCancelSort.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSort.TabIndex = 11;
            this.btnCancelSort.Text = "Отмена";
            this.btnCancelSort.UseVisualStyleBackColor = true;
            // 
            // btnOKSort
            // 
            this.btnOKSort.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOKSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOKSort.Location = new System.Drawing.Point(176, 73);
            this.btnOKSort.Name = "btnOKSort";
            this.btnOKSort.Size = new System.Drawing.Size(75, 23);
            this.btnOKSort.TabIndex = 10;
            this.btnOKSort.Text = "OK";
            this.btnOKSort.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPropertyGroup);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 55);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // cmbPropertyGroup
            // 
            this.cmbPropertyGroup.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cmbPropertyGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPropertyGroup.FormattingEnabled = true;
            this.cmbPropertyGroup.Items.AddRange(new object[] {
            "Фамилия",
            "Имя",
            "Отчество",
            "Дата рождения",
            "Технология тестирования",
            "Должность",
            "Стаж работы",
            "Зарплата"});
            this.cmbPropertyGroup.Location = new System.Drawing.Point(79, 17);
            this.cmbPropertyGroup.Name = "cmbPropertyGroup";
            this.cmbPropertyGroup.Size = new System.Drawing.Size(159, 21);
            this.cmbPropertyGroup.TabIndex = 3;
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
            // FrmGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 111);
            this.Controls.Add(this.btnCancelSort);
            this.Controls.Add(this.btnOKSort);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGroup";
            this.Text = "Групировка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelSort;
        private System.Windows.Forms.Button btnOKSort;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cmbPropertyGroup;
        private System.Windows.Forms.Label label1;
    }
}