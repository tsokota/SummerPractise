namespace lab3_TP

{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericArrayRange = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numericMinArrBorder = new System.Windows.Forms.NumericUpDown();
            this.numericMaxArrBordr = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxArr = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrColum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Generate = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.F1Write = new System.Windows.Forms.Button();
            this.F2write = new System.Windows.Forms.Button();
            this.F1Read = new System.Windows.Forms.Button();
            this.F2read = new System.Windows.Forms.Button();
            this.MeanAndDespRadiobarron = new System.Windows.Forms.RadioButton();
            this.SortArrayRadiobutton = new System.Windows.Forms.RadioButton();
            this.radioButtonInterval = new System.Windows.Forms.RadioButton();
            this.radioButtonCount = new System.Windows.Forms.RadioButton();
            this.ActionButton = new System.Windows.Forms.Button();
            this.grobpBoxTasks = new System.Windows.Forms.GroupBox();
            this.numericSubInterval = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMean = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.textBoxDespersion = new System.Windows.Forms.TextBox();
            this.textBoxSum = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UniqueNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Persent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericArrayRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinArrBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxArrBordr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grobpBoxTasks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSubInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Размер массива N = ";
            // 
            // numericArrayRange
            // 
            this.numericArrayRange.Location = new System.Drawing.Point(129, 16);
            this.numericArrayRange.Margin = new System.Windows.Forms.Padding(2);
            this.numericArrayRange.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericArrayRange.Name = "numericArrayRange";
            this.numericArrayRange.Size = new System.Drawing.Size(48, 20);
            this.numericArrayRange.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = " Границы массива A= ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "B =";
            // 
            // numericMinArrBorder
            // 
            this.numericMinArrBorder.Location = new System.Drawing.Point(317, 16);
            this.numericMinArrBorder.Margin = new System.Windows.Forms.Padding(2);
            this.numericMinArrBorder.Maximum = new decimal(new int[] {
            1999,
            0,
            0,
            0});
            this.numericMinArrBorder.Name = "numericMinArrBorder";
            this.numericMinArrBorder.Size = new System.Drawing.Size(48, 20);
            this.numericMinArrBorder.TabIndex = 4;
            // 
            // numericMaxArrBordr
            // 
            this.numericMaxArrBordr.Location = new System.Drawing.Point(396, 16);
            this.numericMaxArrBordr.Margin = new System.Windows.Forms.Padding(2);
            this.numericMaxArrBordr.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericMaxArrBordr.Name = "numericMaxArrBordr";
            this.numericMaxArrBordr.Size = new System.Drawing.Size(48, 20);
            this.numericMaxArrBordr.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Source array:";
            // 
            // textBoxArr
            // 
            this.textBoxArr.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxArr.Location = new System.Drawing.Point(84, 58);
            this.textBoxArr.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxArr.Name = "textBoxArr";
            this.textBoxArr.ReadOnly = true;
            this.textBoxArr.Size = new System.Drawing.Size(359, 20);
            this.textBoxArr.TabIndex = 7;
            this.textBoxArr.TextChanged += new System.EventHandler(this.textBoxArr_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iColum,
            this.arrColum});
            this.dataGridView1.Location = new System.Drawing.Point(12, 89);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(143, 244);
            this.dataGridView1.TabIndex = 8;
            // 
            // iColum
            // 
            this.iColum.FillWeight = 50F;
            this.iColum.HeaderText = "i";
            this.iColum.Name = "iColum";
            this.iColum.ReadOnly = true;
            this.iColum.Width = 30;
            // 
            // arrColum
            // 
            this.arrColum.HeaderText = "a[ i ]";
            this.arrColum.Name = "arrColum";
            this.arrColum.ReadOnly = true;
            this.arrColum.Width = 70;
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(465, 8);
            this.Generate.Margin = new System.Windows.Forms.Padding(2);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(255, 28);
            this.Generate.TabIndex = 9;
            this.Generate.Text = "Сгенерировать массив";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // F1Write
            // 
            this.F1Write.Enabled = false;
            this.F1Write.Location = new System.Drawing.Point(5, 37);
            this.F1Write.Margin = new System.Windows.Forms.Padding(2);
            this.F1Write.Name = "F1Write";
            this.F1Write.Size = new System.Drawing.Size(97, 28);
            this.F1Write.TabIndex = 10;
            this.F1Write.Text = "Запись  F1";
            this.F1Write.UseVisualStyleBackColor = true;
            this.F1Write.Click += new System.EventHandler(this.F1Write_Click);
            // 
            // F2write
            // 
            this.F2write.Enabled = false;
            this.F2write.Location = new System.Drawing.Point(5, 87);
            this.F2write.Margin = new System.Windows.Forms.Padding(2);
            this.F2write.Name = "F2write";
            this.F2write.Size = new System.Drawing.Size(97, 28);
            this.F2write.TabIndex = 11;
            this.F2write.Text = "Запись F2";
            this.F2write.UseVisualStyleBackColor = true;
            this.F2write.Click += new System.EventHandler(this.F2write_Click);
            // 
            // F1Read
            // 
            this.F1Read.Location = new System.Drawing.Point(5, 134);
            this.F1Read.Margin = new System.Windows.Forms.Padding(2);
            this.F1Read.Name = "F1Read";
            this.F1Read.Size = new System.Drawing.Size(97, 28);
            this.F1Read.TabIndex = 12;
            this.F1Read.Text = "Считать F1";
            this.F1Read.UseVisualStyleBackColor = true;
            this.F1Read.Click += new System.EventHandler(this.F1Read_Click);
            // 
            // F2read
            // 
            this.F2read.Location = new System.Drawing.Point(5, 182);
            this.F2read.Margin = new System.Windows.Forms.Padding(2);
            this.F2read.Name = "F2read";
            this.F2read.Size = new System.Drawing.Size(97, 28);
            this.F2read.TabIndex = 13;
            this.F2read.Text = "Считать F2";
            this.F2read.UseVisualStyleBackColor = true;
            this.F2read.Click += new System.EventHandler(this.F2read_Click);
            // 
            // MeanAndDespRadiobarron
            // 
            this.MeanAndDespRadiobarron.AutoSize = true;
            this.MeanAndDespRadiobarron.Location = new System.Drawing.Point(16, 31);
            this.MeanAndDespRadiobarron.Margin = new System.Windows.Forms.Padding(2);
            this.MeanAndDespRadiobarron.Name = "MeanAndDespRadiobarron";
            this.MeanAndDespRadiobarron.Size = new System.Drawing.Size(184, 17);
            this.MeanAndDespRadiobarron.TabIndex = 15;
            this.MeanAndDespRadiobarron.TabStop = true;
            this.MeanAndDespRadiobarron.Text = "Среднее значение и дисперсия";
            this.MeanAndDespRadiobarron.UseVisualStyleBackColor = true;
            this.MeanAndDespRadiobarron.CheckedChanged += new System.EventHandler(this.MeanAndDespRadiobarron_CheckedChanged);
            // 
            // SortArrayRadiobutton
            // 
            this.SortArrayRadiobutton.AutoSize = true;
            this.SortArrayRadiobutton.Location = new System.Drawing.Point(16, 67);
            this.SortArrayRadiobutton.Margin = new System.Windows.Forms.Padding(2);
            this.SortArrayRadiobutton.Name = "SortArrayRadiobutton";
            this.SortArrayRadiobutton.Size = new System.Drawing.Size(131, 17);
            this.SortArrayRadiobutton.TabIndex = 16;
            this.SortArrayRadiobutton.TabStop = true;
            this.SortArrayRadiobutton.Text = "Сортировать массив";
            this.SortArrayRadiobutton.UseVisualStyleBackColor = true;
            this.SortArrayRadiobutton.CheckedChanged += new System.EventHandler(this.SortArrayRadiobutton_CheckedChanged);
            // 
            // radioButtonInterval
            // 
            this.radioButtonInterval.AutoSize = true;
            this.radioButtonInterval.Location = new System.Drawing.Point(16, 98);
            this.radioButtonInterval.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonInterval.Name = "radioButtonInterval";
            this.radioButtonInterval.Size = new System.Drawing.Size(74, 17);
            this.radioButtonInterval.TabIndex = 17;
            this.radioButtonInterval.TabStop = true;
            this.radioButtonInterval.Text = "Интервал";
            this.radioButtonInterval.UseVisualStyleBackColor = true;
            this.radioButtonInterval.CheckedChanged += new System.EventHandler(this.radioButtonInterval_CheckedChanged);
            // 
            // radioButtonCount
            // 
            this.radioButtonCount.AutoSize = true;
            this.radioButtonCount.Location = new System.Drawing.Point(16, 134);
            this.radioButtonCount.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCount.Name = "radioButtonCount";
            this.radioButtonCount.Size = new System.Drawing.Size(186, 17);
            this.radioButtonCount.TabIndex = 18;
            this.radioButtonCount.TabStop = true;
            this.radioButtonCount.Text = "Подсчет количества элементов";
            this.radioButtonCount.UseVisualStyleBackColor = true;
            this.radioButtonCount.CheckedChanged += new System.EventHandler(this.radioButtonCount_CheckedChanged);
            // 
            // ActionButton
            // 
            this.ActionButton.Location = new System.Drawing.Point(22, 169);
            this.ActionButton.Margin = new System.Windows.Forms.Padding(2);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(97, 28);
            this.ActionButton.TabIndex = 20;
            this.ActionButton.Text = "Выбрать";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // grobpBoxTasks
            // 
            this.grobpBoxTasks.Controls.Add(this.numericSubInterval);
            this.grobpBoxTasks.Controls.Add(this.MeanAndDespRadiobarron);
            this.grobpBoxTasks.Controls.Add(this.ActionButton);
            this.grobpBoxTasks.Controls.Add(this.SortArrayRadiobutton);
            this.grobpBoxTasks.Controls.Add(this.radioButtonInterval);
            this.grobpBoxTasks.Controls.Add(this.radioButtonCount);
            this.grobpBoxTasks.Location = new System.Drawing.Point(278, 98);
            this.grobpBoxTasks.Name = "grobpBoxTasks";
            this.grobpBoxTasks.Size = new System.Drawing.Size(206, 235);
            this.grobpBoxTasks.TabIndex = 21;
            this.grobpBoxTasks.TabStop = false;
            this.grobpBoxTasks.Text = "Операции";
            // 
            // numericSubInterval
            // 
            this.numericSubInterval.Enabled = false;
            this.numericSubInterval.Location = new System.Drawing.Point(88, 98);
            this.numericSubInterval.Margin = new System.Windows.Forms.Padding(2);
            this.numericSubInterval.Name = "numericSubInterval";
            this.numericSubInterval.Size = new System.Drawing.Size(40, 20);
            this.numericSubInterval.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 39);
            this.label5.TabIndex = 25;
            this.label5.Text = "Mат.ожидание:\r\n\r\nНомер:\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(612, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 39);
            this.label6.TabIndex = 26;
            this.label6.Text = "Дисперсия:\r\n\r\nСумма:\r\n";
            // 
            // textBoxMean
            // 
            this.textBoxMean.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxMean.Location = new System.Drawing.Point(567, 41);
            this.textBoxMean.Name = "textBoxMean";
            this.textBoxMean.ReadOnly = true;
            this.textBoxMean.Size = new System.Drawing.Size(40, 20);
            this.textBoxMean.TabIndex = 29;
            this.textBoxMean.Text = "-";
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxNumber.Location = new System.Drawing.Point(567, 68);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.ReadOnly = true;
            this.textBoxNumber.Size = new System.Drawing.Size(40, 20);
            this.textBoxNumber.TabIndex = 30;
            this.textBoxNumber.Text = "-";
            // 
            // textBoxDespersion
            // 
            this.textBoxDespersion.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxDespersion.Location = new System.Drawing.Point(680, 41);
            this.textBoxDespersion.Name = "textBoxDespersion";
            this.textBoxDespersion.ReadOnly = true;
            this.textBoxDespersion.Size = new System.Drawing.Size(40, 20);
            this.textBoxDespersion.TabIndex = 31;
            this.textBoxDespersion.Text = "-";
            // 
            // textBoxSum
            // 
            this.textBoxSum.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxSum.Location = new System.Drawing.Point(680, 67);
            this.textBoxSum.Name = "textBoxSum";
            this.textBoxSum.ReadOnly = true;
            this.textBoxSum.Size = new System.Drawing.Size(40, 20);
            this.textBoxSum.TabIndex = 32;
            this.textBoxSum.Text = "-";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Interval,
            this.UniqueNumber,
            this.Num,
            this.Persent});
            this.dataGridView2.Location = new System.Drawing.Point(490, 98);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(244, 235);
            this.dataGridView2.TabIndex = 33;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Interval
            // 
            this.Interval.FillWeight = 50F;
            this.Interval.HeaderText = "Интервал";
            this.Interval.Name = "Interval";
            this.Interval.ReadOnly = true;
            this.Interval.Width = 50;
            // 
            // UniqueNumber
            // 
            this.UniqueNumber.HeaderText = "Уник. Номер";
            this.UniqueNumber.Name = "UniqueNumber";
            this.UniqueNumber.ReadOnly = true;
            this.UniqueNumber.Width = 50;
            // 
            // Num
            // 
            this.Num.HeaderText = "Номер";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Width = 50;
            // 
            // Persent
            // 
            this.Persent.HeaderText = "%";
            this.Persent.Name = "Persent";
            this.Persent.ReadOnly = true;
            this.Persent.Width = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.F2read);
            this.groupBox1.Controls.Add(this.F1Read);
            this.groupBox1.Controls.Add(this.F1Write);
            this.groupBox1.Controls.Add(this.F2write);
            this.groupBox1.Location = new System.Drawing.Point(160, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 235);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Свойства файлов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(746, 366);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBoxSum);
            this.Controls.Add(this.textBoxDespersion);
            this.Controls.Add(this.textBoxNumber);
            this.Controls.Add(this.textBoxMean);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grobpBoxTasks);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBoxArr);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericMaxArrBordr);
            this.Controls.Add(this.numericMinArrBorder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericArrayRange);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "lab3_TP";
            ((System.ComponentModel.ISupportInitialize)(this.numericArrayRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinArrBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMaxArrBordr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grobpBoxTasks.ResumeLayout(false);
            this.grobpBoxTasks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericSubInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericArrayRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericMinArrBorder;
        private System.Windows.Forms.NumericUpDown numericMaxArrBordr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxArr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button F1Write;
        private System.Windows.Forms.Button F2write;
        private System.Windows.Forms.Button F1Read;
        private System.Windows.Forms.Button F2read;
        private System.Windows.Forms.RadioButton MeanAndDespRadiobarron;
        private System.Windows.Forms.RadioButton SortArrayRadiobutton;
        private System.Windows.Forms.RadioButton radioButtonInterval;
        private System.Windows.Forms.RadioButton radioButtonCount;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.GroupBox grobpBoxTasks;
        private System.Windows.Forms.NumericUpDown numericSubInterval;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxMean;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.TextBox textBoxDespersion;
        private System.Windows.Forms.TextBox textBoxSum;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iColum;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrColum;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn UniqueNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persent;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

