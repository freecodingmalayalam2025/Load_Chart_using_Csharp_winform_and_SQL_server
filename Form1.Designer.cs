namespace WindowsFormsAppLoadChart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartstudent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // chartstudent
            // 
            chartArea1.Name = "ChartArea1";
            this.chartstudent.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartstudent.Legends.Add(legend1);
            this.chartstudent.Location = new System.Drawing.Point(112, 127);
            this.chartstudent.Name = "chartstudent";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartstudent.Series.Add(series1);
            this.chartstudent.Size = new System.Drawing.Size(702, 368);
            this.chartstudent.TabIndex = 0;
            this.chartstudent.Text = "chart1";
            this.chartstudent.Visible = false;
            // 
            // btnload
            // 
            this.btnload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnload.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnload.Location = new System.Drawing.Point(112, 69);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(219, 52);
            this.btnload.TabIndex = 1;
            this.btnload.Text = "Load Student Chart";
            this.btnload.UseVisualStyleBackColor = false;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 538);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.chartstudent);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load Chart";
            ((System.ComponentModel.ISupportInitialize)(this.chartstudent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartstudent;
        private System.Windows.Forms.Button btnload;
    }
}

