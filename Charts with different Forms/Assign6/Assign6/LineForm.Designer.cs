
namespace Assign6
{
    partial class LineForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.LineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PortalButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).BeginInit();
            this.SuspendLayout();
            // 
            // LineChart
            // 
            chartArea2.Name = "ChartArea1";
            this.LineChart.ChartAreas.Add(chartArea2);
            this.LineChart.Location = new System.Drawing.Point(12, 12);
            this.LineChart.Name = "LineChart";
            series2.ChartArea = "ChartArea1";
            series2.Name = "Series1";
            this.LineChart.Series.Add(series2);
            this.LineChart.Size = new System.Drawing.Size(865, 600);
            this.LineChart.TabIndex = 0;
            this.LineChart.Text = "chart1";
            title2.BackColor = System.Drawing.Color.Transparent;
            title2.Name = "Random X and Y";
            title2.Text = "Random X and Y";
            this.LineChart.Titles.Add(title2);
            // 
            // PortalButton
            // 
            this.PortalButton.Location = new System.Drawing.Point(11, 618);
            this.PortalButton.Name = "PortalButton";
            this.PortalButton.Size = new System.Drawing.Size(865, 40);
            this.PortalButton.TabIndex = 2;
            this.PortalButton.Text = "Return to Portal";
            this.PortalButton.UseVisualStyleBackColor = true;
            this.PortalButton.Click += new System.EventHandler(this.PortalButton_Click);
            // 
            // LineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 658);
            this.Controls.Add(this.PortalButton);
            this.Controls.Add(this.LineChart);
            this.Name = "LineForm";
            this.Text = "LineForm";
            ((System.ComponentModel.ISupportInitialize)(this.LineChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart LineChart;
        private System.Windows.Forms.Button PortalButton;
    }
}