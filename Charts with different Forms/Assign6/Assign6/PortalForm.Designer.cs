
namespace Assign6
{
    partial class PortalForm
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
            this.ChartCharterBox = new System.Windows.Forms.GroupBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.BubbleChartButton = new System.Windows.Forms.Button();
            this.PieChartButton = new System.Windows.Forms.Button();
            this.LineChartButton = new System.Windows.Forms.Button();
            this.BarChartButton = new System.Windows.Forms.Button();
            this.ChartCharterBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // ChartCharterBox
            // 
            this.ChartCharterBox.Controls.Add(this.ExitButton);
            this.ChartCharterBox.Controls.Add(this.BubbleChartButton);
            this.ChartCharterBox.Controls.Add(this.PieChartButton);
            this.ChartCharterBox.Controls.Add(this.LineChartButton);
            this.ChartCharterBox.Controls.Add(this.BarChartButton);
            this.ChartCharterBox.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartCharterBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ChartCharterBox.Location = new System.Drawing.Point(12, 9);
            this.ChartCharterBox.Name = "ChartCharterBox";
            this.ChartCharterBox.Size = new System.Drawing.Size(429, 311);
            this.ChartCharterBox.TabIndex = 2;
            this.ChartCharterBox.TabStop = false;
            this.ChartCharterBox.Text = "Ian and Tyler\'s Cool Chart Charter";
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ExitButton.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ExitButton.Location = new System.Drawing.Point(110, 211);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(197, 55);
            this.ExitButton.TabIndex = 4;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // BubbleChartButton
            // 
            this.BubbleChartButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BubbleChartButton.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BubbleChartButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BubbleChartButton.Location = new System.Drawing.Point(226, 115);
            this.BubbleChartButton.Name = "BubbleChartButton";
            this.BubbleChartButton.Size = new System.Drawing.Size(197, 55);
            this.BubbleChartButton.TabIndex = 3;
            this.BubbleChartButton.Text = "Bubble Chart";
            this.BubbleChartButton.UseVisualStyleBackColor = false;
            this.BubbleChartButton.Click += new System.EventHandler(this.BubbleChartButton_Click);
            // 
            // PieChartButton
            // 
            this.PieChartButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PieChartButton.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PieChartButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PieChartButton.Location = new System.Drawing.Point(6, 115);
            this.PieChartButton.Name = "PieChartButton";
            this.PieChartButton.Size = new System.Drawing.Size(197, 55);
            this.PieChartButton.TabIndex = 2;
            this.PieChartButton.Text = "Pie Chart";
            this.PieChartButton.UseVisualStyleBackColor = false;
            this.PieChartButton.Click += new System.EventHandler(this.PieChartButton_Click);
            // 
            // LineChartButton
            // 
            this.LineChartButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LineChartButton.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineChartButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LineChartButton.Location = new System.Drawing.Point(226, 34);
            this.LineChartButton.Name = "LineChartButton";
            this.LineChartButton.Size = new System.Drawing.Size(197, 55);
            this.LineChartButton.TabIndex = 1;
            this.LineChartButton.Text = "Line Chart";
            this.LineChartButton.UseVisualStyleBackColor = false;
            this.LineChartButton.Click += new System.EventHandler(this.LineChartButton_Click);
            // 
            // BarChartButton
            // 
            this.BarChartButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BarChartButton.Font = new System.Drawing.Font("Elephant", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarChartButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BarChartButton.Location = new System.Drawing.Point(6, 34);
            this.BarChartButton.Name = "BarChartButton";
            this.BarChartButton.Size = new System.Drawing.Size(197, 55);
            this.BarChartButton.TabIndex = 0;
            this.BarChartButton.Text = "Bar Chart";
            this.BarChartButton.UseVisualStyleBackColor = false;
            this.BarChartButton.Click += new System.EventHandler(this.BarChartButton_Click);
            // 
            // PortalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(453, 332);
            this.Controls.Add(this.ChartCharterBox);
            this.Controls.Add(this.label1);
            this.Name = "PortalForm";
            this.Text = "Form1";
            this.ChartCharterBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ChartCharterBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button BubbleChartButton;
        private System.Windows.Forms.Button PieChartButton;
        private System.Windows.Forms.Button LineChartButton;
        private System.Windows.Forms.Button BarChartButton;
    }
}

