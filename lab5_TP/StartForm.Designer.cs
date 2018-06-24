namespace Diagrams_lab5_
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numericUpDownSize = new System.Windows.Forms.NumericUpDown();
            this.comboBoxChartStyle = new System.Windows.Forms.ComboBox();
            this.generate = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonColorSelect = new System.Windows.Forms.Button();
            this.colorPanel = new System.Windows.Forms.Panel();
            this.checkBoxShowLegend = new System.Windows.Forms.CheckBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.buttonFontSelect = new System.Windows.Forms.Button();
            this.textBoxFont = new System.Windows.Forms.TextBox();
            this.buttonShowDiagram = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxDoubleArray = new System.Windows.Forms.CheckBox();
            this.checkBoxSort = new System.Windows.Forms.CheckBox();
            this.radioButtonGraph = new System.Windows.Forms.RadioButton();
            this.radioButtonChart = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBoxOn2Charts = new System.Windows.Forms.CheckBox();
            this.checkBoxEnable3D = new System.Windows.Forms.CheckBox();
            this.checkBoxEnMarker = new System.Windows.Forms.CheckBox();
            this.buttonMarkerSelect = new System.Windows.Forms.Button();
            this.panelMarkerColor = new System.Windows.Forms.Panel();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.checkBoxEnableMarcers2 = new System.Windows.Forms.CheckBox();
            this.buttonMarkerSelect2 = new System.Windows.Forms.Button();
            this.panelColorMarks2 = new System.Windows.Forms.Panel();
            this.buttonColorSelect2 = new System.Windows.Forms.Button();
            this.panelColor2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(442, 36);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(180, 283);
            this.dataGridView1.TabIndex = 0;
            // 
            // numericUpDownSize
            // 
            this.numericUpDownSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.numericUpDownSize.Location = new System.Drawing.Point(5, 24);
            this.numericUpDownSize.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDownSize.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownSize.Name = "numericUpDownSize";
            this.numericUpDownSize.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownSize.TabIndex = 1;
            this.numericUpDownSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // comboBoxChartStyle
            // 
            this.comboBoxChartStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.comboBoxChartStyle.DisplayMember = "Black";
            this.comboBoxChartStyle.FormattingEnabled = true;
            this.comboBoxChartStyle.Items.AddRange(new object[] {
            "Columns",
            "Spline",
            "Circle",
            "Doughnut",
            "Bar"});
            this.comboBoxChartStyle.Location = new System.Drawing.Point(351, 356);
            this.comboBoxChartStyle.Name = "comboBoxChartStyle";
            this.comboBoxChartStyle.Size = new System.Drawing.Size(163, 21);
            this.comboBoxChartStyle.TabIndex = 3;
            this.comboBoxChartStyle.Text = "Columns";
            this.comboBoxChartStyle.SelectedIndexChanged += new System.EventHandler(this.comboBoxChartStyle_SelectedIndexChanged);
            // 
            // generate
            // 
            this.generate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.generate.Location = new System.Drawing.Point(71, 21);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 23);
            this.generate.TabIndex = 4;
            this.generate.Text = "Generate";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // buttonColorSelect
            // 
            this.buttonColorSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorSelect.Location = new System.Drawing.Point(5, 25);
            this.buttonColorSelect.Name = "buttonColorSelect";
            this.buttonColorSelect.Size = new System.Drawing.Size(114, 21);
            this.buttonColorSelect.TabIndex = 5;
            this.buttonColorSelect.Text = "Column color select...";
            this.buttonColorSelect.UseVisualStyleBackColor = true;
            this.buttonColorSelect.Click += new System.EventHandler(this.buttonColorSelect_Click);
            // 
            // colorPanel
            // 
            this.colorPanel.BackColor = System.Drawing.Color.Black;
            this.colorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.colorPanel.Location = new System.Drawing.Point(125, 25);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(22, 22);
            this.colorPanel.TabIndex = 6;
            // 
            // checkBoxShowLegend
            // 
            this.checkBoxShowLegend.AutoSize = true;
            this.checkBoxShowLegend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBoxShowLegend.Checked = true;
            this.checkBoxShowLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowLegend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxShowLegend.Location = new System.Drawing.Point(351, 334);
            this.checkBoxShowLegend.Name = "checkBoxShowLegend";
            this.checkBoxShowLegend.Size = new System.Drawing.Size(86, 17);
            this.checkBoxShowLegend.TabIndex = 7;
            this.checkBoxShowLegend.Text = "Show legend";
            this.checkBoxShowLegend.UseVisualStyleBackColor = false;
            this.checkBoxShowLegend.CheckedChanged += new System.EventHandler(this.checkBoxShowLegend_CheckedChanged);
            // 
            // buttonFontSelect
            // 
            this.buttonFontSelect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonFontSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFontSelect.Location = new System.Drawing.Point(166, 331);
            this.buttonFontSelect.Name = "buttonFontSelect";
            this.buttonFontSelect.Size = new System.Drawing.Size(160, 23);
            this.buttonFontSelect.TabIndex = 8;
            this.buttonFontSelect.Text = "Font select...";
            this.buttonFontSelect.UseVisualStyleBackColor = false;
            this.buttonFontSelect.Click += new System.EventHandler(this.buttonFontSelect_Click);
            // 
            // textBoxFont
            // 
            this.textBoxFont.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBoxFont.Location = new System.Drawing.Point(166, 360);
            this.textBoxFont.Name = "textBoxFont";
            this.textBoxFont.ReadOnly = true;
            this.textBoxFont.Size = new System.Drawing.Size(160, 20);
            this.textBoxFont.TabIndex = 10;
            this.textBoxFont.Text = "Arial";
            // 
            // buttonShowDiagram
            // 
            this.buttonShowDiagram.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonShowDiagram.Location = new System.Drawing.Point(35, 108);
            this.buttonShowDiagram.Name = "buttonShowDiagram";
            this.buttonShowDiagram.Size = new System.Drawing.Size(84, 30);
            this.buttonShowDiagram.TabIndex = 11;
            this.buttonShowDiagram.Text = "Show diagram";
            this.buttonShowDiagram.UseVisualStyleBackColor = true;
            this.buttonShowDiagram.Click += new System.EventHandler(this.buttonShowDiagram_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.checkBoxDoubleArray);
            this.groupBox1.Controls.Add(this.checkBoxSort);
            this.groupBox1.Controls.Add(this.radioButtonGraph);
            this.groupBox1.Controls.Add(this.numericUpDownSize);
            this.groupBox1.Controls.Add(this.radioButtonChart);
            this.groupBox1.Controls.Add(this.generate);
            this.groupBox1.Controls.Add(this.buttonShowDiagram);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(3, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(158, 147);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Generate properties";
            // 
            // checkBoxDoubleArray
            // 
            this.checkBoxDoubleArray.AutoSize = true;
            this.checkBoxDoubleArray.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxDoubleArray.Location = new System.Drawing.Point(71, 47);
            this.checkBoxDoubleArray.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxDoubleArray.Name = "checkBoxDoubleArray";
            this.checkBoxDoubleArray.Size = new System.Drawing.Size(84, 17);
            this.checkBoxDoubleArray.TabIndex = 6;
            this.checkBoxDoubleArray.Text = "Double array";
            this.checkBoxDoubleArray.UseVisualStyleBackColor = true;
            this.checkBoxDoubleArray.CheckedChanged += new System.EventHandler(this.checkBoxDoubleArray_CheckedChanged);
            // 
            // checkBoxSort
            // 
            this.checkBoxSort.AutoSize = true;
            this.checkBoxSort.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxSort.Location = new System.Drawing.Point(5, 47);
            this.checkBoxSort.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSort.Name = "checkBoxSort";
            this.checkBoxSort.Size = new System.Drawing.Size(69, 17);
            this.checkBoxSort.TabIndex = 5;
            this.checkBoxSort.Text = "Sort array";
            this.checkBoxSort.UseVisualStyleBackColor = true;
            // 
            // radioButtonGraph
            // 
            this.radioButtonGraph.AutoSize = true;
            this.radioButtonGraph.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButtonGraph.Location = new System.Drawing.Point(5, 89);
            this.radioButtonGraph.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonGraph.Name = "radioButtonGraph";
            this.radioButtonGraph.Size = new System.Drawing.Size(113, 17);
            this.radioButtonGraph.TabIndex = 18;
            this.radioButtonGraph.Text = "Graphick primitives";
            this.radioButtonGraph.UseVisualStyleBackColor = true;
            this.radioButtonGraph.CheckedChanged += new System.EventHandler(this.radioButtonGraph_CheckedChanged);
            // 
            // radioButtonChart
            // 
            this.radioButtonChart.AutoSize = true;
            this.radioButtonChart.Checked = true;
            this.radioButtonChart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.radioButtonChart.Location = new System.Drawing.Point(6, 68);
            this.radioButtonChart.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonChart.Name = "radioButtonChart";
            this.radioButtonChart.Size = new System.Drawing.Size(49, 17);
            this.radioButtonChart.TabIndex = 17;
            this.radioButtonChart.TabStop = true;
            this.radioButtonChart.Text = "Chart";
            this.radioButtonChart.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBox1.Enabled = false;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBox1.Location = new System.Drawing.Point(532, 334);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(53, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "4 diag";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxOn2Charts
            // 
            this.checkBoxOn2Charts.AutoSize = true;
            this.checkBoxOn2Charts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBoxOn2Charts.Enabled = false;
            this.checkBoxOn2Charts.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxOn2Charts.Location = new System.Drawing.Point(532, 361);
            this.checkBoxOn2Charts.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxOn2Charts.Name = "checkBoxOn2Charts";
            this.checkBoxOn2Charts.Size = new System.Drawing.Size(90, 17);
            this.checkBoxOn2Charts.TabIndex = 19;
            this.checkBoxOn2Charts.Text = "On two charts";
            this.checkBoxOn2Charts.UseVisualStyleBackColor = false;
            this.checkBoxOn2Charts.CheckedChanged += new System.EventHandler(this.checkBoxOn2Charts_CheckedChanged);
            // 
            // checkBoxEnable3D
            // 
            this.checkBoxEnable3D.AutoSize = true;
            this.checkBoxEnable3D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBoxEnable3D.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxEnable3D.Location = new System.Drawing.Point(442, 334);
            this.checkBoxEnable3D.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnable3D.Name = "checkBoxEnable3D";
            this.checkBoxEnable3D.Size = new System.Drawing.Size(74, 17);
            this.checkBoxEnable3D.TabIndex = 15;
            this.checkBoxEnable3D.Text = "Enable 3D";
            this.checkBoxEnable3D.UseVisualStyleBackColor = false;
            this.checkBoxEnable3D.CheckedChanged += new System.EventHandler(this.checkBoxEnable3D_CheckedChanged);
            // 
            // checkBoxEnMarker
            // 
            this.checkBoxEnMarker.AutoSize = true;
            this.checkBoxEnMarker.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxEnMarker.Location = new System.Drawing.Point(5, 54);
            this.checkBoxEnMarker.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnMarker.Name = "checkBoxEnMarker";
            this.checkBoxEnMarker.Size = new System.Drawing.Size(106, 17);
            this.checkBoxEnMarker.TabIndex = 16;
            this.checkBoxEnMarker.Text = "Enable markers 1";
            this.checkBoxEnMarker.UseVisualStyleBackColor = true;
            this.checkBoxEnMarker.CheckedChanged += new System.EventHandler(this.checkBoxEnMarker_CheckedChanged);
            // 
            // buttonMarkerSelect
            // 
            this.buttonMarkerSelect.Enabled = false;
            this.buttonMarkerSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMarkerSelect.Location = new System.Drawing.Point(5, 77);
            this.buttonMarkerSelect.Name = "buttonMarkerSelect";
            this.buttonMarkerSelect.Size = new System.Drawing.Size(114, 23);
            this.buttonMarkerSelect.TabIndex = 11;
            this.buttonMarkerSelect.Text = "Marker color select...";
            this.buttonMarkerSelect.UseVisualStyleBackColor = true;
            this.buttonMarkerSelect.Click += new System.EventHandler(this.buttonMarkerSelect_Click);
            // 
            // panelMarkerColor
            // 
            this.panelMarkerColor.BackColor = System.Drawing.Color.Red;
            this.panelMarkerColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMarkerColor.ForeColor = System.Drawing.Color.Red;
            this.panelMarkerColor.Location = new System.Drawing.Point(125, 77);
            this.panelMarkerColor.Name = "panelMarkerColor";
            this.panelMarkerColor.Size = new System.Drawing.Size(22, 22);
            this.panelMarkerColor.TabIndex = 12;
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonInfo.Location = new System.Drawing.Point(471, 3);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(134, 28);
            this.buttonInfo.TabIndex = 14;
            this.buttonInfo.Text = "Information about author";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(222, 36);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(172, 283);
            this.dataGridView2.TabIndex = 15;
            // 
            // checkBoxEnableMarcers2
            // 
            this.checkBoxEnableMarcers2.AutoSize = true;
            this.checkBoxEnableMarcers2.Enabled = false;
            this.checkBoxEnableMarcers2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.checkBoxEnableMarcers2.Location = new System.Drawing.Point(5, 54);
            this.checkBoxEnableMarcers2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxEnableMarcers2.Name = "checkBoxEnableMarcers2";
            this.checkBoxEnableMarcers2.Size = new System.Drawing.Size(106, 17);
            this.checkBoxEnableMarcers2.TabIndex = 24;
            this.checkBoxEnableMarcers2.Text = "Enable markers 2";
            this.checkBoxEnableMarcers2.UseVisualStyleBackColor = true;
            this.checkBoxEnableMarcers2.CheckedChanged += new System.EventHandler(this.checkBoxEnableMarcers2_CheckedChanged);
            // 
            // buttonMarkerSelect2
            // 
            this.buttonMarkerSelect2.Enabled = false;
            this.buttonMarkerSelect2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMarkerSelect2.Location = new System.Drawing.Point(5, 77);
            this.buttonMarkerSelect2.Name = "buttonMarkerSelect2";
            this.buttonMarkerSelect2.Size = new System.Drawing.Size(114, 23);
            this.buttonMarkerSelect2.TabIndex = 22;
            this.buttonMarkerSelect2.Text = "Marker color select...";
            this.buttonMarkerSelect2.UseVisualStyleBackColor = true;
            this.buttonMarkerSelect2.Click += new System.EventHandler(this.buttonMarkerSelect2_Click);
            // 
            // panelColorMarks2
            // 
            this.panelColorMarks2.BackColor = System.Drawing.Color.Orange;
            this.panelColorMarks2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelColorMarks2.ForeColor = System.Drawing.Color.Red;
            this.panelColorMarks2.Location = new System.Drawing.Point(125, 77);
            this.panelColorMarks2.Name = "panelColorMarks2";
            this.panelColorMarks2.Size = new System.Drawing.Size(22, 22);
            this.panelColorMarks2.TabIndex = 23;
            // 
            // buttonColorSelect2
            // 
            this.buttonColorSelect2.Enabled = false;
            this.buttonColorSelect2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonColorSelect2.Location = new System.Drawing.Point(5, 25);
            this.buttonColorSelect2.Name = "buttonColorSelect2";
            this.buttonColorSelect2.Size = new System.Drawing.Size(114, 21);
            this.buttonColorSelect2.TabIndex = 20;
            this.buttonColorSelect2.Text = "Column color select...";
            this.buttonColorSelect2.UseVisualStyleBackColor = true;
            this.buttonColorSelect2.Click += new System.EventHandler(this.buttonColorSelect2_Click);
            // 
            // panelColor2
            // 
            this.panelColor2.BackColor = System.Drawing.Color.Green;
            this.panelColor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelColor2.Location = new System.Drawing.Point(125, 25);
            this.panelColor2.Name = "panelColor2";
            this.panelColor2.Size = new System.Drawing.Size(22, 22);
            this.panelColor2.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.buttonMarkerSelect);
            this.groupBox3.Controls.Add(this.panelMarkerColor);
            this.groupBox3.Controls.Add(this.checkBoxEnMarker);
            this.groupBox3.Controls.Add(this.buttonColorSelect);
            this.groupBox3.Controls.Add(this.colorPanel);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Location = new System.Drawing.Point(3, 155);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(158, 115);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color settings: first form";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.buttonMarkerSelect2);
            this.groupBox4.Controls.Add(this.panelColor2);
            this.groupBox4.Controls.Add(this.checkBoxEnableMarcers2);
            this.groupBox4.Controls.Add(this.buttonColorSelect2);
            this.groupBox4.Controls.Add(this.panelColorMarks2);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(3, 260);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(158, 129);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Color settings: second form";
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(633, 400);
            this.Controls.Add(this.comboBoxChartStyle);
            this.Controls.Add(this.textBoxFont);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.buttonFontSelect);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.checkBoxEnable3D);
            this.Controls.Add(this.checkBoxOn2Charts);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.checkBoxShowLegend);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StartForm";
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.StartForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSize)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown numericUpDownSize;
        private System.Windows.Forms.ComboBox comboBoxChartStyle;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonColorSelect;
        private System.Windows.Forms.Panel colorPanel;
        private System.Windows.Forms.CheckBox checkBoxShowLegend;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button buttonFontSelect;
        private System.Windows.Forms.TextBox textBoxFont;
        private System.Windows.Forms.Button buttonShowDiagram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonInfo;
        private System.Windows.Forms.CheckBox checkBoxEnable3D;
        private System.Windows.Forms.CheckBox checkBoxEnMarker;
        private System.Windows.Forms.Button buttonMarkerSelect;
        private System.Windows.Forms.Panel panelMarkerColor;
        private System.Windows.Forms.RadioButton radioButtonGraph;
        private System.Windows.Forms.RadioButton radioButtonChart;
        private System.Windows.Forms.CheckBox checkBoxSort;
        private System.Windows.Forms.CheckBox checkBoxDoubleArray;
        private System.Windows.Forms.CheckBox checkBoxOn2Charts;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.CheckBox checkBoxEnableMarcers2;
        private System.Windows.Forms.Button buttonMarkerSelect2;
        private System.Windows.Forms.Panel panelColorMarks2;
        private System.Windows.Forms.Button buttonColorSelect2;
        private System.Windows.Forms.Panel panelColor2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

