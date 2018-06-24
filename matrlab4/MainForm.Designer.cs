namespace lab4_TP
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.AboutButton = new System.Windows.Forms.Button();
            this.FileSaveButton = new System.Windows.Forms.Button();
            this.FileReadButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.ActionButton = new System.Windows.Forms.Button();
            this.numericUpDownData = new System.Windows.Forms.NumericUpDown();
            this.errorProviderArrSize = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLowB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderHighB = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderActionButton = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDownLeft = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownRight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderArrSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLowB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHighB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActionButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(16, 79);
            this.AboutButton.Margin = new System.Windows.Forms.Padding(2);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(111, 29);
            this.AboutButton.TabIndex = 0;
            this.AboutButton.Text = "Автор";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // FileSaveButton
            // 
            this.FileSaveButton.Location = new System.Drawing.Point(11, 79);
            this.FileSaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.FileSaveButton.Name = "FileSaveButton";
            this.FileSaveButton.Size = new System.Drawing.Size(111, 42);
            this.FileSaveButton.TabIndex = 1;
            this.FileSaveButton.Text = "Сохранить файл";
            this.FileSaveButton.UseVisualStyleBackColor = true;
            this.FileSaveButton.Click += new System.EventHandler(this.FileSaveButton_Click);
            // 
            // FileReadButton
            // 
            this.FileReadButton.Location = new System.Drawing.Point(11, 27);
            this.FileReadButton.Margin = new System.Windows.Forms.Padding(2);
            this.FileReadButton.Name = "FileReadButton";
            this.FileReadButton.Size = new System.Drawing.Size(111, 38);
            this.FileReadButton.TabIndex = 2;
            this.FileReadButton.Text = "Прочитать файл";
            this.FileReadButton.UseVisualStyleBackColor = true;
            this.FileReadButton.Click += new System.EventHandler(this.FileReadButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // GenerateButton
            // 
            this.GenerateButton.Location = new System.Drawing.Point(16, 28);
            this.GenerateButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(111, 35);
            this.GenerateButton.TabIndex = 6;
            this.GenerateButton.Text = "Генерация массива";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(17, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(86, 17);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "Сортировка\r\n";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(17, 35);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(165, 17);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "Найти индексы элемента d\r\n";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(17, 59);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(251, 17);
            this.checkBox3.TabIndex = 9;
            this.checkBox3.Text = "Количество простых чисел (среди нечетных)\r\n";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // ActionButton
            // 
            this.ActionButton.Location = new System.Drawing.Point(12, 88);
            this.ActionButton.Margin = new System.Windows.Forms.Padding(2);
            this.ActionButton.Name = "ActionButton";
            this.ActionButton.Size = new System.Drawing.Size(256, 31);
            this.ActionButton.TabIndex = 10;
            this.ActionButton.Text = "Выбор действия";
            this.ActionButton.UseVisualStyleBackColor = true;
            this.ActionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // numericUpDownData
            // 
            this.numericUpDownData.Enabled = false;
            this.numericUpDownData.Location = new System.Drawing.Point(186, 34);
            this.numericUpDownData.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownData.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDownData.Name = "numericUpDownData";
            this.numericUpDownData.Size = new System.Drawing.Size(47, 20);
            this.numericUpDownData.TabIndex = 14;
            // 
            // errorProviderArrSize
            // 
            this.errorProviderArrSize.ContainerControl = this;
            // 
            // errorProviderLowB
            // 
            this.errorProviderLowB.ContainerControl = this;
            // 
            // errorProviderHighB
            // 
            this.errorProviderHighB.ContainerControl = this;
            // 
            // errorProviderActionButton
            // 
            this.errorProviderActionButton.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ActionButton);
            this.panel1.Controls.Add(this.numericUpDownData);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Location = new System.Drawing.Point(12, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 137);
            this.panel1.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FileSaveButton);
            this.groupBox1.Controls.Add(this.FileReadButton);
            this.groupBox1.Location = new System.Drawing.Point(314, 139);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 137);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "JSON сериализация";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GenerateButton);
            this.groupBox2.Controls.Add(this.AboutButton);
            this.groupBox2.Location = new System.Drawing.Point(314, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(144, 121);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Действия";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // numericUpDownLeft
            // 
            this.numericUpDownLeft.Location = new System.Drawing.Point(159, 56);
            this.numericUpDownLeft.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownLeft.Maximum = new decimal(new int[] {
            599,
            0,
            0,
            0});
            this.numericUpDownLeft.Name = "numericUpDownLeft";
            this.numericUpDownLeft.Size = new System.Drawing.Size(110, 20);
            this.numericUpDownLeft.TabIndex = 20;
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.Location = new System.Drawing.Point(159, 32);
            this.numericUpDownSize.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(110, 20);
            this.numericUpDownSize.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Максимальное значение :";
            // 
            // numericUpDownRight
            // 
            this.numericUpDownRight.Location = new System.Drawing.Point(159, 81);
            this.numericUpDownRight.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownRight.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.numericUpDownRight.Name = "numericUpDownRight";
            this.numericUpDownRight.Size = new System.Drawing.Size(110, 20);
            this.numericUpDownRight.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Минимальное значение :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Размер матрицы :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericUpDownLeft);
            this.groupBox3.Controls.Add(this.numericUpDownSize);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.numericUpDownRight);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(10, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 121);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Параметры матрицы ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 288);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Задание исходных данных";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderArrSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLowB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHighB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderActionButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRight)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AboutButton;
        private System.Windows.Forms.Button FileSaveButton;
        private System.Windows.Forms.Button FileReadButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button ActionButton;
        private System.Windows.Forms.NumericUpDown numericUpDownData;
        private System.Windows.Forms.ErrorProvider errorProviderArrSize;
        private System.Windows.Forms.ErrorProvider errorProviderLowB;
        private System.Windows.Forms.ErrorProvider errorProviderHighB;
        private System.Windows.Forms.ErrorProvider errorProviderActionButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown numericUpDownLeft;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

