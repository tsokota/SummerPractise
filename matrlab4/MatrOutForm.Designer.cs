namespace lab4_TP
{
    partial class MatrOutForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIndexI = new System.Windows.Forms.TextBox();
            this.textBoxIndexJ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPrim = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSorted = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(718, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 370);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Координаты элемента d :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 417);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "j:";
            // 
            // textBoxIndexI
            // 
            this.textBoxIndexI.Location = new System.Drawing.Point(28, 394);
            this.textBoxIndexI.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIndexI.Name = "textBoxIndexI";
            this.textBoxIndexI.ReadOnly = true;
            this.textBoxIndexI.Size = new System.Drawing.Size(268, 20);
            this.textBoxIndexI.TabIndex = 3;
            // 
            // textBoxIndexJ
            // 
            this.textBoxIndexJ.Location = new System.Drawing.Point(28, 417);
            this.textBoxIndexJ.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxIndexJ.Name = "textBoxIndexJ";
            this.textBoxIndexJ.ReadOnly = true;
            this.textBoxIndexJ.Size = new System.Drawing.Size(268, 20);
            this.textBoxIndexJ.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 423);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество простых чисел:";
            // 
            // textBoxPrim
            // 
            this.textBoxPrim.Location = new System.Drawing.Point(503, 417);
            this.textBoxPrim.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPrim.Name = "textBoxPrim";
            this.textBoxPrim.ReadOnly = true;
            this.textBoxPrim.Size = new System.Drawing.Size(73, 20);
            this.textBoxPrim.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 394);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Сортировка столбца:";
            // 
            // textBoxSorted
            // 
            this.textBoxSorted.Location = new System.Drawing.Point(503, 391);
            this.textBoxSorted.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSorted.Name = "textBoxSorted";
            this.textBoxSorted.ReadOnly = true;
            this.textBoxSorted.Size = new System.Drawing.Size(73, 20);
            this.textBoxSorted.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "Закрыть окно";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 394);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "j:";
            // 
            // MatrOutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 446);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSorted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPrim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIndexJ);
            this.Controls.Add(this.textBoxIndexI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MatrOutForm";
            this.Text = "Матрица";
            this.Load += new System.EventHandler(this.MatrOutForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIndexI;
        private System.Windows.Forms.TextBox textBoxIndexJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPrim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSorted;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}