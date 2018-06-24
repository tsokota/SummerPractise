namespace Diagrams_lab5_
{
    partial class GraphikDrawPrim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.
        /// </param>
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
            this.labelAvg = new System.Windows.Forms.Label();
            this.labelYears = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelInfl
            // 
            this.labelAvg.AutoSize = true;
            this.labelAvg.Location = new System.Drawing.Point(51, 44);
            this.labelAvg.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAvg.Name = "labelAvg";
            this.labelAvg.Size = new System.Drawing.Size(61, 13);
            this.labelAvg.TabIndex = 0;
            this.labelAvg.Text = "Price (%)";
            this.labelAvg.Click += new System.EventHandler(this.labelInfl_Click);
            // 
            // labelYears
            // 
            this.labelYears.AutoSize = true;
            this.labelYears.Location = new System.Drawing.Point(68, 78);
            this.labelYears.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelYears.Name = "labelYears";
            this.labelYears.Size = new System.Drawing.Size(43, 13);
            this.labelYears.TabIndex = 1;
            this.labelYears.Text = "Year (y)";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(53, 129);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(294, 25);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Price increase (y/%) ";
            // 
            // GraphikDrawPrim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 232);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelYears);
            this.Controls.Add(this.labelAvg);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GraphikDrawPrim";
            this.Text = "Primitives drow";
            this.Load += new System.EventHandler(this.GraphikDrawPrim_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphikDrawPrim_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAvg;
        private System.Windows.Forms.Label labelYears;
        private System.Windows.Forms.Label labelName;
    }
}