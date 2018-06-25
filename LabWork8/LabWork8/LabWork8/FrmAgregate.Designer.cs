namespace LabWork8
{
    partial class FrmAgregate
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
            this.btnCancelAgr = new System.Windows.Forms.Button();
            this.btnOKAgr = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPropertyAgregate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelAgr
            // 
            this.btnCancelAgr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelAgr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelAgr.Location = new System.Drawing.Point(216, 59);
            this.btnCancelAgr.Name = "btnCancelAgr";
            this.btnCancelAgr.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAgr.TabIndex = 17;
            this.btnCancelAgr.Text = "Отмена";
            this.btnCancelAgr.UseVisualStyleBackColor = true;
            // 
            // btnOKAgr
            // 
            this.btnOKAgr.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOKAgr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOKAgr.Location = new System.Drawing.Point(297, 58);
            this.btnOKAgr.Name = "btnOKAgr";
            this.btnOKAgr.Size = new System.Drawing.Size(75, 23);
            this.btnOKAgr.TabIndex = 16;
            this.btnOKAgr.Text = "OK";
            this.btnOKAgr.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPropertyAgregate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, -3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 55);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // cmbPropertyAgregate
            // 
            this.cmbPropertyAgregate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPropertyAgregate.FormattingEnabled = true;
            this.cmbPropertyAgregate.Items.AddRange(new object[] {
            "Количество однофамильцев",
            "Минимальная дата рождения для технологий тест.",
            "Средняя зарплата по должностям"});
            this.cmbPropertyAgregate.Location = new System.Drawing.Point(67, 21);
            this.cmbPropertyAgregate.Name = "cmbPropertyAgregate";
            this.cmbPropertyAgregate.Size = new System.Drawing.Size(276, 21);
            this.cmbPropertyAgregate.TabIndex = 3;
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
            // FrmAgregate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 99);
            this.Controls.Add(this.btnCancelAgr);
            this.Controls.Add(this.btnOKAgr);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAgregate";
            this.Text = "FrmAgregate";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnCancelAgr;
        public System.Windows.Forms.Button btnOKAgr;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox cmbPropertyAgregate;
        private System.Windows.Forms.Label label1;
    }
}