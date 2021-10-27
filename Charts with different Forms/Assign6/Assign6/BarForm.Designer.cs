
namespace Assign6
{
    partial class BarForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PortalButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            this.SuspendLayout();
            // 
            // BarChart
            // 
            chartArea3.Name = "ChartArea1";
            this.BarChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.BarChart.Legends.Add(legend3);
            this.BarChart.Location = new System.Drawing.Point(12, 12);
            this.BarChart.Name = "BarChart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.BarChart.Series.Add(series3);
            this.BarChart.Size = new System.Drawing.Size(865, 599);
            this.BarChart.TabIndex = 0;
            this.BarChart.Text = "chart1";
            // 
            // PortalButton
            // 
            this.PortalButton.Location = new System.Drawing.Point(12, 617);
            this.PortalButton.Name = "PortalButton";
            this.PortalButton.Size = new System.Drawing.Size(865, 40);
            this.PortalButton.TabIndex = 1;
            this.PortalButton.Text = "Return to Portal";
            this.PortalButton.UseVisualStyleBackColor = true;
            this.PortalButton.Click += new System.EventHandler(this.PortalButton_Click);
            // 
            // BarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 661);
            this.Controls.Add(this.PortalButton);
            this.Controls.Add(this.BarChart);
            this.Name = "BarForm";
            this.Text = "BarForm";
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
        private System.Windows.Forms.Button PortalButton;
    }
}