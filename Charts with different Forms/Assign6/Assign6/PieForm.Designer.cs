
namespace Assign6
{
    partial class PieForm
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
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PortalButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            this.SuspendLayout();
            // 
            // PieChart
            // 
            chartArea1.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.PieChart.Legends.Add(legend1);
            this.PieChart.Location = new System.Drawing.Point(12, 12);
            this.PieChart.Name = "PieChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.PieChart.Series.Add(series1);
            this.PieChart.Size = new System.Drawing.Size(865, 598);
            this.PieChart.TabIndex = 0;
            this.PieChart.Text = "chart1";
            // 
            // PortalButton
            // 
            this.PortalButton.Location = new System.Drawing.Point(12, 616);
            this.PortalButton.Name = "PortalButton";
            this.PortalButton.Size = new System.Drawing.Size(865, 40);
            this.PortalButton.TabIndex = 3;
            this.PortalButton.Text = "Return to Portal";
            this.PortalButton.UseVisualStyleBackColor = true;
            this.PortalButton.Click += new System.EventHandler(this.PortalButton_Click);
            // 
            // PieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 659);
            this.Controls.Add(this.PortalButton);
            this.Controls.Add(this.PieChart);
            this.Name = "PieForm";
            this.Text = "PieForm";
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.Button PortalButton;
    }
}