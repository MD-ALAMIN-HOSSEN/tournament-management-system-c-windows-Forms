
namespace tournament_system_dotnet
{
    partial class Create_team
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
            this.createteam = new System.Windows.Forms.Button();
            this.teame_name = new System.Windows.Forms.Label();
            this.member_listbox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Members = new System.Windows.Forms.Label();
            this.select_team_member_combo_box = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Add_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createteam
            // 
            this.createteam.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createteam.Location = new System.Drawing.Point(508, 265);
            this.createteam.Name = "createteam";
            this.createteam.Size = new System.Drawing.Size(174, 66);
            this.createteam.TabIndex = 0;
            this.createteam.Text = "Create Team";
            this.createteam.UseVisualStyleBackColor = true;
            this.createteam.Click += new System.EventHandler(this.createteam_Click);
            // 
            // teame_name
            // 
            this.teame_name.AutoSize = true;
            this.teame_name.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.teame_name.Location = new System.Drawing.Point(93, 28);
            this.teame_name.Name = "teame_name";
            this.teame_name.Size = new System.Drawing.Size(129, 25);
            this.teame_name.TabIndex = 1;
            this.teame_name.Text = "Team name   :";
            this.teame_name.Click += new System.EventHandler(this.teame_name_Click);
            // 
            // member_listbox
            // 
            this.member_listbox.FormattingEnabled = true;
            this.member_listbox.ItemHeight = 20;
            this.member_listbox.Location = new System.Drawing.Point(108, 111);
            this.member_listbox.Name = "member_listbox";
            this.member_listbox.Size = new System.Drawing.Size(282, 244);
            this.member_listbox.TabIndex = 2;
            this.member_listbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 27);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tournament_system_dotnet.Properties.Resources.back_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Members
            // 
            this.Members.AutoSize = true;
            this.Members.Location = new System.Drawing.Point(108, 78);
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(71, 20);
            this.Members.TabIndex = 30;
            this.Members.Text = "Members";
            this.Members.Click += new System.EventHandler(this.Members_Click);
            // 
            // select_team_member_combo_box
            // 
            this.select_team_member_combo_box.FormattingEnabled = true;
            this.select_team_member_combo_box.Location = new System.Drawing.Point(495, 146);
            this.select_team_member_combo_box.Name = "select_team_member_combo_box";
            this.select_team_member_combo_box.Size = new System.Drawing.Size(174, 28);
            this.select_team_member_combo_box.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Select team member :";
            // 
            // Add_button
            // 
            this.Add_button.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Add_button.Location = new System.Drawing.Point(529, 180);
            this.Add_button.Name = "Add_button";
            this.Add_button.Size = new System.Drawing.Size(109, 39);
            this.Add_button.TabIndex = 33;
            this.Add_button.Text = "Add";
            this.Add_button.UseVisualStyleBackColor = true;
            this.Add_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Create_team
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.select_team_member_combo_box);
            this.Controls.Add(this.Members);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.member_listbox);
            this.Controls.Add(this.teame_name);
            this.Controls.Add(this.createteam);
            this.Name = "Create_team";
            this.Text = "Create_team";
            this.Load += new System.EventHandler(this.Create_team_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createteam;
        private System.Windows.Forms.Label teame_name;
        private System.Windows.Forms.ListBox member_listbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Members;
        private System.Windows.Forms.ComboBox select_team_member_combo_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Add_button;
    }
}