
namespace Assign4
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
            this.errorLogBox = new System.Windows.Forms.RichTextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.linearGraphButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.yIntervalBox = new System.Windows.Forms.RichTextBox();
            this.yMaxBox = new System.Windows.Forms.RichTextBox();
            this.xMaxBox = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.xIntervalBox = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.yMinBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.xMinBox = new System.Windows.Forms.RichTextBox();
            this.xMinLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lineColorBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.graphSelectorBox = new System.Windows.Forms.ComboBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linearBBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linearMBox = new System.Windows.Forms.RichTextBox();
            this.linearOutputBox = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.quadraticCBox = new System.Windows.Forms.RichTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.quadraticBBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.quadraticABox = new System.Windows.Forms.RichTextBox();
            this.quadraticOutputBox = new System.Windows.Forms.RichTextBox();
            this.quadraticGraphButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cubicDBox = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.cubicCBox = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cubicBBox = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cubicABox = new System.Windows.Forms.RichTextBox();
            this.cubicOutputBox = new System.Windows.Forms.RichTextBox();
            this.cubicGraphButton = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.circleRBox = new System.Windows.Forms.RichTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.circleKBox = new System.Windows.Forms.RichTextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.circleHBox = new System.Windows.Forms.RichTextBox();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.circleGraphButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // errorLogBox
            // 
            this.errorLogBox.Location = new System.Drawing.Point(407, 961);
            this.errorLogBox.Name = "errorLogBox";
            this.errorLogBox.ReadOnly = true;
            this.errorLogBox.Size = new System.Drawing.Size(970, 75);
            this.errorLogBox.TabIndex = 4;
            this.errorLogBox.Text = "";
            // 
            // linearGraphButton
            // 
            this.linearGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearGraphButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linearGraphButton.Location = new System.Drawing.Point(266, 106);
            this.linearGraphButton.Name = "linearGraphButton";
            this.linearGraphButton.Size = new System.Drawing.Size(97, 27);
            this.linearGraphButton.TabIndex = 5;
            this.linearGraphButton.Text = "Graph it!";
            this.linearGraphButton.UseVisualStyleBackColor = true;
            this.linearGraphButton.Click += new System.EventHandler(this.linearGraphButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.yIntervalBox);
            this.groupBox1.Controls.Add(this.yMaxBox);
            this.groupBox1.Controls.Add(this.xMaxBox);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.xIntervalBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.yMinBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.xMinBox);
            this.groupBox1.Controls.Add(this.xMinLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lineColorBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.graphSelectorBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 271);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(180, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 35;
            this.label10.Text = "yMax";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(180, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Y-Interval";
            // 
            // yIntervalBox
            // 
            this.yIntervalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yIntervalBox.Location = new System.Drawing.Point(184, 232);
            this.yIntervalBox.Name = "yIntervalBox";
            this.yIntervalBox.Size = new System.Drawing.Size(121, 29);
            this.yIntervalBox.TabIndex = 33;
            this.yIntervalBox.Text = "";
            // 
            // yMaxBox
            // 
            this.yMaxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yMaxBox.Location = new System.Drawing.Point(184, 177);
            this.yMaxBox.Name = "yMaxBox";
            this.yMaxBox.Size = new System.Drawing.Size(121, 29);
            this.yMaxBox.TabIndex = 32;
            this.yMaxBox.Text = "";
            // 
            // xMaxBox
            // 
            this.xMaxBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xMaxBox.Location = new System.Drawing.Point(184, 122);
            this.xMaxBox.Name = "xMaxBox";
            this.xMaxBox.Size = new System.Drawing.Size(121, 29);
            this.xMaxBox.TabIndex = 31;
            this.xMaxBox.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(180, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 20);
            this.label8.TabIndex = 30;
            this.label8.Text = "xMax";
            // 
            // xIntervalBox
            // 
            this.xIntervalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xIntervalBox.Location = new System.Drawing.Point(10, 232);
            this.xIntervalBox.Name = "xIntervalBox";
            this.xIntervalBox.Size = new System.Drawing.Size(121, 29);
            this.xIntervalBox.TabIndex = 29;
            this.xIntervalBox.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "X-Interval";
            // 
            // yMinBox
            // 
            this.yMinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yMinBox.Location = new System.Drawing.Point(10, 177);
            this.yMinBox.Name = "yMinBox";
            this.yMinBox.Size = new System.Drawing.Size(121, 29);
            this.yMinBox.TabIndex = 27;
            this.yMinBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "yMin";
            // 
            // xMinBox
            // 
            this.xMinBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xMinBox.Location = new System.Drawing.Point(10, 122);
            this.xMinBox.Name = "xMinBox";
            this.xMinBox.Size = new System.Drawing.Size(121, 29);
            this.xMinBox.TabIndex = 25;
            this.xMinBox.Text = "";
            // 
            // xMinLabel
            // 
            this.xMinLabel.AutoSize = true;
            this.xMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xMinLabel.Location = new System.Drawing.Point(6, 99);
            this.xMinLabel.Name = "xMinLabel";
            this.xMinLabel.Size = new System.Drawing.Size(41, 20);
            this.xMinLabel.TabIndex = 22;
            this.xMinLabel.Text = "xMin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Line Color";
            // 
            // lineColorBox
            // 
            this.lineColorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineColorBox.FormattingEnabled = true;
            this.lineColorBox.ItemHeight = 20;
            this.lineColorBox.Items.AddRange(new object[] {
            "Red",
            "Green",
            "Blue",
            "Purple"});
            this.lineColorBox.Location = new System.Drawing.Point(184, 68);
            this.lineColorBox.Name = "lineColorBox";
            this.lineColorBox.Size = new System.Drawing.Size(121, 28);
            this.lineColorBox.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Graph Selector";
            // 
            // graphSelectorBox
            // 
            this.graphSelectorBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphSelectorBox.FormattingEnabled = true;
            this.graphSelectorBox.ItemHeight = 20;
            this.graphSelectorBox.Items.AddRange(new object[] {
            "Graph 1",
            "Graph 2",
            "Graph 3",
            "Graph 4"});
            this.graphSelectorBox.Location = new System.Drawing.Point(10, 68);
            this.graphSelectorBox.Name = "graphSelectorBox";
            this.graphSelectorBox.Size = new System.Drawing.Size(121, 28);
            this.graphSelectorBox.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linearBBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.linearMBox);
            this.groupBox2.Controls.Add(this.linearOutputBox);
            this.groupBox2.Controls.Add(this.linearGraphButton);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(12, 280);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 141);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Linear";
            // 
            // linearBBox
            // 
            this.linearBBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearBBox.Location = new System.Drawing.Point(184, 69);
            this.linearBBox.Name = "linearBBox";
            this.linearBBox.Size = new System.Drawing.Size(113, 29);
            this.linearBBox.TabIndex = 24;
            this.linearBBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "b = The Y-Intercept";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "m = The Slope";
            // 
            // linearMBox
            // 
            this.linearMBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearMBox.Location = new System.Drawing.Point(184, 34);
            this.linearMBox.Name = "linearMBox";
            this.linearMBox.Size = new System.Drawing.Size(113, 29);
            this.linearMBox.TabIndex = 16;
            this.linearMBox.Text = "";
            // 
            // linearOutputBox
            // 
            this.linearOutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linearOutputBox.Location = new System.Drawing.Point(10, 104);
            this.linearOutputBox.Name = "linearOutputBox";
            this.linearOutputBox.ReadOnly = true;
            this.linearOutputBox.Size = new System.Drawing.Size(250, 29);
            this.linearOutputBox.TabIndex = 14;
            this.linearOutputBox.Text = "y = mx + b";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.quadraticCBox);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.quadraticBBox);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.quadraticABox);
            this.groupBox3.Controls.Add(this.quadraticOutputBox);
            this.groupBox3.Controls.Add(this.quadraticGraphButton);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(12, 427);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(369, 176);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quadratic";
            // 
            // quadraticCBox
            // 
            this.quadraticCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quadraticCBox.Location = new System.Drawing.Point(184, 104);
            this.quadraticCBox.Name = "quadraticCBox";
            this.quadraticCBox.Size = new System.Drawing.Size(113, 29);
            this.quadraticCBox.TabIndex = 26;
            this.quadraticCBox.Text = "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 20);
            this.label12.TabIndex = 25;
            this.label12.Text = "c = real number";
            // 
            // quadraticBBox
            // 
            this.quadraticBBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quadraticBBox.Location = new System.Drawing.Point(184, 69);
            this.quadraticBBox.Name = "quadraticBBox";
            this.quadraticBBox.Size = new System.Drawing.Size(113, 29);
            this.quadraticBBox.TabIndex = 24;
            this.quadraticBBox.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "b = real number";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "a = real number";
            // 
            // quadraticABox
            // 
            this.quadraticABox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quadraticABox.Location = new System.Drawing.Point(184, 34);
            this.quadraticABox.Name = "quadraticABox";
            this.quadraticABox.Size = new System.Drawing.Size(113, 29);
            this.quadraticABox.TabIndex = 16;
            this.quadraticABox.Text = "";
            // 
            // quadraticOutputBox
            // 
            this.quadraticOutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quadraticOutputBox.Location = new System.Drawing.Point(10, 139);
            this.quadraticOutputBox.Name = "quadraticOutputBox";
            this.quadraticOutputBox.ReadOnly = true;
            this.quadraticOutputBox.Size = new System.Drawing.Size(250, 29);
            this.quadraticOutputBox.TabIndex = 14;
            this.quadraticOutputBox.Text = "y = ax^2 + bx + c";
            // 
            // quadraticGraphButton
            // 
            this.quadraticGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quadraticGraphButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.quadraticGraphButton.Location = new System.Drawing.Point(266, 141);
            this.quadraticGraphButton.Name = "quadraticGraphButton";
            this.quadraticGraphButton.Size = new System.Drawing.Size(97, 27);
            this.quadraticGraphButton.TabIndex = 5;
            this.quadraticGraphButton.Text = "Graph it!";
            this.quadraticGraphButton.UseVisualStyleBackColor = true;
            this.quadraticGraphButton.Click += new System.EventHandler(this.quadraticGraphButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cubicDBox);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.cubicCBox);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.cubicBBox);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.cubicABox);
            this.groupBox4.Controls.Add(this.cubicOutputBox);
            this.groupBox4.Controls.Add(this.cubicGraphButton);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(12, 609);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(369, 214);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cubic";
            // 
            // cubicDBox
            // 
            this.cubicDBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cubicDBox.Location = new System.Drawing.Point(184, 139);
            this.cubicDBox.Name = "cubicDBox";
            this.cubicDBox.Size = new System.Drawing.Size(113, 29);
            this.cubicDBox.TabIndex = 28;
            this.cubicDBox.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 142);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "d = real number";
            // 
            // cubicCBox
            // 
            this.cubicCBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cubicCBox.Location = new System.Drawing.Point(184, 104);
            this.cubicCBox.Name = "cubicCBox";
            this.cubicCBox.Size = new System.Drawing.Size(113, 29);
            this.cubicCBox.TabIndex = 26;
            this.cubicCBox.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(118, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "c = real number";
            // 
            // cubicBBox
            // 
            this.cubicBBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cubicBBox.Location = new System.Drawing.Point(184, 69);
            this.cubicBBox.Name = "cubicBBox";
            this.cubicBBox.Size = new System.Drawing.Size(113, 29);
            this.cubicBBox.TabIndex = 24;
            this.cubicBBox.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 78);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "b = real number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 20);
            this.label15.TabIndex = 22;
            this.label15.Text = "a = real number";
            // 
            // cubicABox
            // 
            this.cubicABox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cubicABox.Location = new System.Drawing.Point(184, 34);
            this.cubicABox.Name = "cubicABox";
            this.cubicABox.Size = new System.Drawing.Size(113, 29);
            this.cubicABox.TabIndex = 16;
            this.cubicABox.Text = "";
            // 
            // cubicOutputBox
            // 
            this.cubicOutputBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cubicOutputBox.Location = new System.Drawing.Point(10, 177);
            this.cubicOutputBox.Name = "cubicOutputBox";
            this.cubicOutputBox.ReadOnly = true;
            this.cubicOutputBox.Size = new System.Drawing.Size(250, 29);
            this.cubicOutputBox.TabIndex = 14;
            this.cubicOutputBox.Text = "y = ax^3 + bx^2 + cx + d";
            // 
            // cubicGraphButton
            // 
            this.cubicGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cubicGraphButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cubicGraphButton.Location = new System.Drawing.Point(266, 179);
            this.cubicGraphButton.Name = "cubicGraphButton";
            this.cubicGraphButton.Size = new System.Drawing.Size(97, 27);
            this.cubicGraphButton.TabIndex = 5;
            this.cubicGraphButton.Text = "Graph it!";
            this.cubicGraphButton.UseVisualStyleBackColor = true;
            this.cubicGraphButton.Click += new System.EventHandler(this.cubicGraphButton_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.circleRBox);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.circleKBox);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.circleHBox);
            this.groupBox5.Controls.Add(this.richTextBox5);
            this.groupBox5.Controls.Add(this.circleGraphButton);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(12, 829);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(369, 176);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Circle";
            // 
            // circleRBox
            // 
            this.circleRBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleRBox.Location = new System.Drawing.Point(184, 104);
            this.circleRBox.Name = "circleRBox";
            this.circleRBox.Size = new System.Drawing.Size(113, 29);
            this.circleRBox.TabIndex = 26;
            this.circleRBox.Text = "";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(142, 20);
            this.label17.TabIndex = 25;
            this.label17.Text = "r = Radius of Circle";
            // 
            // circleKBox
            // 
            this.circleKBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleKBox.Location = new System.Drawing.Point(184, 69);
            this.circleKBox.Name = "circleKBox";
            this.circleKBox.Size = new System.Drawing.Size(113, 29);
            this.circleKBox.TabIndex = 24;
            this.circleKBox.Text = "";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(157, 20);
            this.label18.TabIndex = 23;
            this.label18.Text = "k = Y coord of middle";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 43);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(158, 20);
            this.label19.TabIndex = 22;
            this.label19.Text = "h = X coord of middle";
            // 
            // circleHBox
            // 
            this.circleHBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleHBox.Location = new System.Drawing.Point(184, 34);
            this.circleHBox.Name = "circleHBox";
            this.circleHBox.Size = new System.Drawing.Size(113, 29);
            this.circleHBox.TabIndex = 16;
            this.circleHBox.Text = "";
            // 
            // richTextBox5
            // 
            this.richTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox5.Location = new System.Drawing.Point(10, 139);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.Size = new System.Drawing.Size(250, 29);
            this.richTextBox5.TabIndex = 14;
            this.richTextBox5.Text = "(x-h)^2 + (y-k)^2 = r^2";
            // 
            // circleGraphButton
            // 
            this.circleGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circleGraphButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.circleGraphButton.Location = new System.Drawing.Point(266, 141);
            this.circleGraphButton.Name = "circleGraphButton";
            this.circleGraphButton.Size = new System.Drawing.Size(97, 27);
            this.circleGraphButton.TabIndex = 5;
            this.circleGraphButton.Text = "Graph it!";
            this.circleGraphButton.UseVisualStyleBackColor = true;
            this.circleGraphButton.Click += new System.EventHandler(this.circleGraphButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(407, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(461, 441);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(888, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(467, 441);
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(407, 496);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(461, 431);
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox3_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(888, 496);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(467, 431);
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox4_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1382, 1041);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.errorLogBox);
            this.Name = "Form1";
            this.Text = "Graphing Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox errorLogBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button linearGraphButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ComboBox graphSelectorBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox lineColorBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox linearBBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox linearMBox;
        private System.Windows.Forms.RichTextBox linearOutputBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox yIntervalBox;
        private System.Windows.Forms.RichTextBox yMaxBox;
        private System.Windows.Forms.RichTextBox xMaxBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox xIntervalBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox yMinBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox xMinBox;
        private System.Windows.Forms.Label xMinLabel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox quadraticBBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox quadraticABox;
        private System.Windows.Forms.RichTextBox quadraticOutputBox;
        private System.Windows.Forms.Button quadraticGraphButton;
        private System.Windows.Forms.RichTextBox quadraticCBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox cubicDBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox cubicCBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RichTextBox cubicBBox;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox cubicABox;
        private System.Windows.Forms.RichTextBox cubicOutputBox;
        private System.Windows.Forms.Button cubicGraphButton;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RichTextBox circleRBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox circleKBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RichTextBox circleHBox;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Button circleGraphButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

