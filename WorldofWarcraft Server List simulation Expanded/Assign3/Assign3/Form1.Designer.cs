
namespace Assign3
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
            this.ClassBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ServerBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ServerBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RoleBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ServerBox3 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.RoleGroupBox = new System.Windows.Forms.GroupBox();
            this.DamageButton = new System.Windows.Forms.RadioButton();
            this.HealerButton = new System.Windows.Forms.RadioButton();
            this.TankButton = new System.Windows.Forms.RadioButton();
            this.button5 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.Query = new System.Windows.Forms.RichTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.MinBox = new System.Windows.Forms.NumericUpDown();
            this.MaxBox = new System.Windows.Forms.NumericUpDown();
            this.RoleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassBox
            // 
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.Items.AddRange(new object[] {
            "Warrior",
            "Mage",
            "Druid",
            "Priest",
            "Warlock",
            "Rogue",
            "Paladin",
            "Hunter",
            "Shaman"});
            this.ClassBox.Location = new System.Drawing.Point(16, 56);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(121, 21);
            this.ClassBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Class";
            // 
            // ServerBox
            // 
            this.ServerBox.FormattingEnabled = true;
            this.ServerBox.Items.AddRange(new object[] {
            "Beta4Azeroth",
            "TKWasASetback",
            "ZappyBoi"});
            this.ServerBox.Location = new System.Drawing.Point(180, 56);
            this.ServerBox.Name = "ServerBox";
            this.ServerBox.Size = new System.Drawing.Size(121, 21);
            this.ServerBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(176, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Server";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(12, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(388, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Percentage of Each Race From a Single Server";
            // 
            // ServerBox2
            // 
            this.ServerBox2.FormattingEnabled = true;
            this.ServerBox2.Items.AddRange(new object[] {
            "Beta4Azeroth",
            "TKWasASetback",
            "ZappyBoi"});
            this.ServerBox2.Location = new System.Drawing.Point(180, 144);
            this.ServerBox2.Name = "ServerBox2";
            this.ServerBox2.Size = new System.Drawing.Size(121, 21);
            this.ServerBox2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Silver;
            this.label5.Location = new System.Drawing.Point(176, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Server";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(370, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Show Results";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(370, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Show Results";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Location = new System.Drawing.Point(12, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(466, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "All Role Types from a Single Server Within a Level Range";
            // 
            // RoleBox
            // 
            this.RoleBox.FormattingEnabled = true;
            this.RoleBox.Items.AddRange(new object[] {
            "Tank",
            "Healer",
            "Damage"});
            this.RoleBox.Location = new System.Drawing.Point(16, 232);
            this.RoleBox.Name = "RoleBox";
            this.RoleBox.Size = new System.Drawing.Size(121, 21);
            this.RoleBox.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Silver;
            this.label7.Location = new System.Drawing.Point(12, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Role";
            // 
            // ServerBox3
            // 
            this.ServerBox3.FormattingEnabled = true;
            this.ServerBox3.Items.AddRange(new object[] {
            "Beta4Azeroth",
            "TKWasASetback",
            "ZappyBoi"});
            this.ServerBox3.Location = new System.Drawing.Point(180, 232);
            this.ServerBox3.Name = "ServerBox3";
            this.ServerBox3.Size = new System.Drawing.Size(121, 21);
            this.ServerBox3.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(176, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Server";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(370, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Show Results";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(12, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 20);
            this.label9.TabIndex = 18;
            this.label9.Text = "Min";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Silver;
            this.label10.Location = new System.Drawing.Point(103, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Max";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label11.Location = new System.Drawing.Point(12, 340);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(219, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "All Guilds of a Single Type";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Silver;
            this.label12.Location = new System.Drawing.Point(12, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Type";
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Casual",
            "Mythic+",
            "PVP",
            "Questing",
            "Raiding"});
            this.TypeBox.Location = new System.Drawing.Point(16, 395);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(121, 21);
            this.TypeBox.TabIndex = 23;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(370, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(108, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Show Results";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label13.Location = new System.Drawing.Point(12, 437);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(434, 20);
            this.label13.TabIndex = 25;
            this.label13.Text = "All Players Who Could Fill a Role But Presently Aren\'t";
            // 
            // RoleGroupBox
            // 
            this.RoleGroupBox.Controls.Add(this.DamageButton);
            this.RoleGroupBox.Controls.Add(this.HealerButton);
            this.RoleGroupBox.Controls.Add(this.TankButton);
            this.RoleGroupBox.Location = new System.Drawing.Point(16, 474);
            this.RoleGroupBox.Name = "RoleGroupBox";
            this.RoleGroupBox.Size = new System.Drawing.Size(215, 54);
            this.RoleGroupBox.TabIndex = 26;
            this.RoleGroupBox.TabStop = false;
            // 
            // DamageButton
            // 
            this.DamageButton.AutoSize = true;
            this.DamageButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.DamageButton.Location = new System.Drawing.Point(144, 19);
            this.DamageButton.Name = "DamageButton";
            this.DamageButton.Size = new System.Drawing.Size(65, 17);
            this.DamageButton.TabIndex = 2;
            this.DamageButton.Text = "Damage";
            this.DamageButton.UseVisualStyleBackColor = true;
            // 
            // HealerButton
            // 
            this.HealerButton.AutoSize = true;
            this.HealerButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.HealerButton.Location = new System.Drawing.Point(71, 19);
            this.HealerButton.Name = "HealerButton";
            this.HealerButton.Size = new System.Drawing.Size(56, 17);
            this.HealerButton.TabIndex = 1;
            this.HealerButton.TabStop = true;
            this.HealerButton.Text = "Healer";
            this.HealerButton.UseVisualStyleBackColor = true;
            // 
            // TankButton
            // 
            this.TankButton.AutoSize = true;
            this.TankButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.TankButton.Location = new System.Drawing.Point(6, 19);
            this.TankButton.Name = "TankButton";
            this.TankButton.Size = new System.Drawing.Size(50, 17);
            this.TankButton.TabIndex = 0;
            this.TankButton.TabStop = true;
            this.TankButton.Text = "Tank";
            this.TankButton.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(370, 487);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(108, 23);
            this.button5.TabIndex = 27;
            this.button5.Text = "Show Results";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label14.Location = new System.Drawing.Point(12, 547);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(369, 20);
            this.label14.TabIndex = 28;
            this.label14.Text = "Percentage of Max Level Players in All Guilds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Class Type from a Single Server";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.label15.Location = new System.Drawing.Point(480, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 20);
            this.label15.TabIndex = 29;
            this.label15.Text = "Query";
            // 
            // Query
            // 
            this.Query.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Query.Location = new System.Drawing.Point(484, 35);
            this.Query.Name = "Query";
            this.Query.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Query.Size = new System.Drawing.Size(786, 595);
            this.Query.TabIndex = 30;
            this.Query.Text = "";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(370, 588);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(108, 23);
            this.button6.TabIndex = 31;
            this.button6.Text = "Show Results";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // MinBox
            // 
            this.MinBox.Location = new System.Drawing.Point(16, 301);
            this.MinBox.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.MinBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinBox.Name = "MinBox";
            this.MinBox.Size = new System.Drawing.Size(38, 20);
            this.MinBox.TabIndex = 32;
            this.MinBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MinBox.ValueChanged += new System.EventHandler(this.MinBox_ValueChanged);
            // 
            // MaxBox
            // 
            this.MaxBox.Location = new System.Drawing.Point(107, 301);
            this.MaxBox.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.MaxBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxBox.Name = "MaxBox";
            this.MaxBox.Size = new System.Drawing.Size(36, 20);
            this.MaxBox.TabIndex = 33;
            this.MaxBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaxBox.ValueChanged += new System.EventHandler(this.MaxBox_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1304, 645);
            this.Controls.Add(this.MaxBox);
            this.Controls.Add(this.MinBox);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.Query);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.RoleGroupBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ServerBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.RoleBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ServerBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ServerBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClassBox);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.RoleGroupBox.ResumeLayout(false);
            this.RoleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ClassBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ServerBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ServerBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RoleBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ServerBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox RoleGroupBox;
        private System.Windows.Forms.RadioButton DamageButton;
        private System.Windows.Forms.RadioButton HealerButton;
        private System.Windows.Forms.RadioButton TankButton;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox Query;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.NumericUpDown MinBox;
        private System.Windows.Forms.NumericUpDown MaxBox;
    }
}

