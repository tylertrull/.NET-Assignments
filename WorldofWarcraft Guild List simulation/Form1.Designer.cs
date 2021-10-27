
namespace Assign2
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
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Output_textbox = new System.Windows.Forms.RichTextBox();
            this.playerListBox = new System.Windows.Forms.ListBox();
            this.guildListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Management_Groupbox = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SearchGuild_Combobox = new System.Windows.Forms.ComboBox();
            this.SearchPlayer_Textbox = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.NewRole_Combobox = new System.Windows.Forms.ComboBox();
            this.NewRace_Combobox = new System.Windows.Forms.ComboBox();
            this.NewClass_Combobox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NewName_Textbox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AddGuild_Button = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.GuildType_Combobox = new System.Windows.Forms.ComboBox();
            this.Server_Combobox = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.GuildName_Textbox = new System.Windows.Forms.TextBox();
            this.Management_Groupbox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(520, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(263, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(525, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "Player/Guild Management System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 576);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 27);
            this.label4.TabIndex = 5;
            this.label4.Text = "Output";
            // 
            // Output_textbox
            // 
            this.Output_textbox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_textbox.Location = new System.Drawing.Point(17, 606);
            this.Output_textbox.Name = "Output_textbox";
            this.Output_textbox.ReadOnly = true;
            this.Output_textbox.Size = new System.Drawing.Size(1129, 96);
            this.Output_textbox.TabIndex = 6;
            this.Output_textbox.Text = "";
            // 
            // playerListBox
            // 
            this.playerListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerListBox.FormattingEnabled = true;
            this.playerListBox.ItemHeight = 14;
            this.playerListBox.Location = new System.Drawing.Point(524, 76);
            this.playerListBox.Name = "playerListBox";
            this.playerListBox.Size = new System.Drawing.Size(234, 438);
            this.playerListBox.Sorted = true;
            this.playerListBox.TabIndex = 7;
            this.playerListBox.SelectedIndexChanged += new System.EventHandler(this.PlayerListBox_Change);
            // 
            // guildListBox
            // 
            this.guildListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guildListBox.FormattingEnabled = true;
            this.guildListBox.ItemHeight = 14;
            this.guildListBox.Location = new System.Drawing.Point(764, 76);
            this.guildListBox.Name = "guildListBox";
            this.guildListBox.Size = new System.Drawing.Size(339, 438);
            this.guildListBox.Sorted = true;
            this.guildListBox.TabIndex = 9;
            this.guildListBox.SelectedIndexChanged += new System.EventHandler(this.guildListBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(760, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Guilds";
            // 
            // Management_Groupbox
            // 
            this.Management_Groupbox.Controls.Add(this.label6);
            this.Management_Groupbox.Controls.Add(this.label5);
            this.Management_Groupbox.Controls.Add(this.SearchGuild_Combobox);
            this.Management_Groupbox.Controls.Add(this.SearchPlayer_Textbox);
            this.Management_Groupbox.Controls.Add(this.button5);
            this.Management_Groupbox.Controls.Add(this.button4);
            this.Management_Groupbox.Controls.Add(this.button3);
            this.Management_Groupbox.Controls.Add(this.button2);
            this.Management_Groupbox.Controls.Add(this.button1);
            this.Management_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Management_Groupbox.ForeColor = System.Drawing.SystemColors.Control;
            this.Management_Groupbox.Location = new System.Drawing.Point(17, 52);
            this.Management_Groupbox.Name = "Management_Groupbox";
            this.Management_Groupbox.Size = new System.Drawing.Size(462, 211);
            this.Management_Groupbox.TabIndex = 11;
            this.Management_Groupbox.TabStop = false;
            this.Management_Groupbox.Text = "Management Functions";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Search Guild (by Server)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Search Player (by Name)";
            // 
            // SearchGuild_Combobox
            // 
            this.SearchGuild_Combobox.FormattingEnabled = true;
            this.SearchGuild_Combobox.Items.AddRange(new object[] {
            "Beta4Azeroth",
            "TKWasASetback",
            "ZappyBoi"});
            this.SearchGuild_Combobox.Location = new System.Drawing.Point(215, 131);
            this.SearchGuild_Combobox.Name = "SearchGuild_Combobox";
            this.SearchGuild_Combobox.Size = new System.Drawing.Size(236, 32);
            this.SearchGuild_Combobox.TabIndex = 6;
            // 
            // SearchPlayer_Textbox
            // 
            this.SearchPlayer_Textbox.Location = new System.Drawing.Point(215, 65);
            this.SearchPlayer_Textbox.Name = "SearchPlayer_Textbox";
            this.SearchPlayer_Textbox.Size = new System.Drawing.Size(236, 29);
            this.SearchPlayer_Textbox.TabIndex = 5;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(17, 170);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 27);
            this.button5.TabIndex = 4;
            this.button5.Text = "Apply Search Criteria";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.ApplySearchCriteria_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(17, 137);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "Leave Guild";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.LeaveGuild_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(17, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "Join Guild";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.JoinGuild_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(17, 71);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Disband Guild";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.GuildDisband_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(17, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Print Guild Roster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.PrintGuildRoster_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.NewRole_Combobox);
            this.groupBox1.Controls.Add(this.NewRace_Combobox);
            this.groupBox1.Controls.Add(this.NewClass_Combobox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.NewName_Textbox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(17, 269);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(462, 156);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create New Player";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Location = new System.Drawing.Point(326, 53);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(128, 32);
            this.button6.TabIndex = 9;
            this.button6.Text = "Add Player";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.AddPlayer_Click);
            // 
            // NewRole_Combobox
            // 
            this.NewRole_Combobox.FormattingEnabled = true;
            this.NewRole_Combobox.Items.AddRange(new object[] {
            "DPS",
            "Healer",
            "Tank"});
            this.NewRole_Combobox.Location = new System.Drawing.Point(178, 115);
            this.NewRole_Combobox.Name = "NewRole_Combobox";
            this.NewRole_Combobox.Size = new System.Drawing.Size(142, 32);
            this.NewRole_Combobox.Sorted = true;
            this.NewRole_Combobox.TabIndex = 10;
            // 
            // NewRace_Combobox
            // 
            this.NewRace_Combobox.FormattingEnabled = true;
            this.NewRace_Combobox.Items.AddRange(new object[] {
            "Forsaken",
            "Orc",
            "Tauren",
            "Troll"});
            this.NewRace_Combobox.Location = new System.Drawing.Point(178, 53);
            this.NewRace_Combobox.Name = "NewRace_Combobox";
            this.NewRace_Combobox.Size = new System.Drawing.Size(142, 32);
            this.NewRace_Combobox.Sorted = true;
            this.NewRace_Combobox.TabIndex = 9;
            // 
            // NewClass_Combobox
            // 
            this.NewClass_Combobox.FormattingEnabled = true;
            this.NewClass_Combobox.Items.AddRange(new object[] {
            "Druid",
            "Hunter",
            "Mage",
            "Paladin",
            "Priest",
            "Rouge",
            "Shaman",
            "Warlock",
            "Warrior"});
            this.NewClass_Combobox.Location = new System.Drawing.Point(17, 116);
            this.NewClass_Combobox.Name = "NewClass_Combobox";
            this.NewClass_Combobox.Size = new System.Drawing.Size(142, 32);
            this.NewClass_Combobox.Sorted = true;
            this.NewClass_Combobox.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(174, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 24);
            this.label10.TabIndex = 7;
            this.label10.Text = "Role";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Class";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 24);
            this.label8.TabIndex = 5;
            this.label8.Text = "Race";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Player Name";
            // 
            // NewName_Textbox
            // 
            this.NewName_Textbox.Location = new System.Drawing.Point(17, 56);
            this.NewName_Textbox.Name = "NewName_Textbox";
            this.NewName_Textbox.Size = new System.Drawing.Size(142, 29);
            this.NewName_Textbox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AddGuild_Button);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.GuildType_Combobox);
            this.groupBox2.Controls.Add(this.Server_Combobox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.GuildName_Textbox);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(17, 431);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(462, 142);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Create New Guild";
            // 
            // AddGuild_Button
            // 
            this.AddGuild_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGuild_Button.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddGuild_Button.Location = new System.Drawing.Point(326, 49);
            this.AddGuild_Button.Name = "AddGuild_Button";
            this.AddGuild_Button.Size = new System.Drawing.Size(128, 32);
            this.AddGuild_Button.TabIndex = 11;
            this.AddGuild_Button.Text = "Add Guild";
            this.AddGuild_Button.UseVisualStyleBackColor = true;
            this.AddGuild_Button.Click += new System.EventHandler(this.AddGuild_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(174, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 24);
            this.label13.TabIndex = 14;
            this.label13.Text = "Type";
            // 
            // GuildType_Combobox
            // 
            this.GuildType_Combobox.FormattingEnabled = true;
            this.GuildType_Combobox.Items.AddRange(new object[] {
            "Casual",
            "Mythic+",
            "PVP",
            "Questing",
            "Raiding"});
            this.GuildType_Combobox.Location = new System.Drawing.Point(178, 110);
            this.GuildType_Combobox.Name = "GuildType_Combobox";
            this.GuildType_Combobox.Size = new System.Drawing.Size(142, 32);
            this.GuildType_Combobox.Sorted = true;
            this.GuildType_Combobox.TabIndex = 13;
            // 
            // Server_Combobox
            // 
            this.Server_Combobox.FormattingEnabled = true;
            this.Server_Combobox.Items.AddRange(new object[] {
            "Beta4Azeroth",
            "TKWasASetback",
            "Zappyboi"});
            this.Server_Combobox.Location = new System.Drawing.Point(178, 49);
            this.Server_Combobox.Name = "Server_Combobox";
            this.Server_Combobox.Size = new System.Drawing.Size(142, 32);
            this.Server_Combobox.Sorted = true;
            this.Server_Combobox.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(174, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 24);
            this.label12.TabIndex = 12;
            this.label12.Text = "Server";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Guild Name";
            // 
            // GuildName_Textbox
            // 
            this.GuildName_Textbox.Location = new System.Drawing.Point(17, 52);
            this.GuildName_Textbox.Name = "GuildName_Textbox";
            this.GuildName_Textbox.Size = new System.Drawing.Size(142, 29);
            this.GuildName_Textbox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1158, 714);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Management_Groupbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guildListBox);
            this.Controls.Add(this.playerListBox);
            this.Controls.Add(this.Output_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "World of ConflictCraft: Player/Guild Management System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Management_Groupbox.ResumeLayout(false);
            this.Management_Groupbox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Output_textbox;
        private System.Windows.Forms.ListBox playerListBox;
        private System.Windows.Forms.ListBox guildListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox Management_Groupbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SearchGuild_Combobox;
        private System.Windows.Forms.TextBox SearchPlayer_Textbox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox NewRole_Combobox;
        private System.Windows.Forms.ComboBox NewRace_Combobox;
        private System.Windows.Forms.ComboBox NewClass_Combobox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NewName_Textbox;
        private System.Windows.Forms.Button AddGuild_Button;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox GuildType_Combobox;
        private System.Windows.Forms.ComboBox Server_Combobox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox GuildName_Textbox;
    }
}

