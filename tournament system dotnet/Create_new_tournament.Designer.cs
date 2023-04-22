
namespace tournament_system_dotnet
{
    partial class Create_new_tournament
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
            this.Teams = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tournament_name = new System.Windows.Forms.TextBox();
            this.member_listbox = new System.Windows.Forms.ListBox();
            this.teame_name = new System.Windows.Forms.Label();
            this.create_tournament = new System.Windows.Forms.Button();
            this.Create_prize = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.select_team_combox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Selected_prize_list_listbox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Teams
            // 
            this.Teams.AutoSize = true;
            this.Teams.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Teams.Location = new System.Drawing.Point(69, 174);
            this.Teams.Name = "Teams";
            this.Teams.Size = new System.Drawing.Size(61, 25);
            this.Teams.TabIndex = 36;
            this.Teams.Text = "Teams";
            this.Teams.Click += new System.EventHandler(this.Teams_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tournament_system_dotnet.Properties.Resources.back_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tournament_name
            // 
            this.tournament_name.Location = new System.Drawing.Point(218, 23);
            this.tournament_name.Name = "tournament_name";
            this.tournament_name.Size = new System.Drawing.Size(273, 27);
            this.tournament_name.TabIndex = 34;
            // 
            // member_listbox
            // 
            this.member_listbox.FormattingEnabled = true;
            this.member_listbox.ItemHeight = 20;
            this.member_listbox.Location = new System.Drawing.Point(69, 202);
            this.member_listbox.Name = "member_listbox";
            this.member_listbox.Size = new System.Drawing.Size(282, 244);
            this.member_listbox.TabIndex = 33;
            this.member_listbox.SelectedIndexChanged += new System.EventHandler(this.member_listbox_SelectedIndexChanged);
            // 
            // teame_name
            // 
            this.teame_name.AutoSize = true;
            this.teame_name.Location = new System.Drawing.Point(69, 23);
            this.teame_name.Name = "teame_name";
            this.teame_name.Size = new System.Drawing.Size(132, 20);
            this.teame_name.TabIndex = 32;
            this.teame_name.Text = "Tournament Name";
            // 
            // create_tournament
            // 
            this.create_tournament.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create_tournament.Location = new System.Drawing.Point(495, 362);
            this.create_tournament.Name = "create_tournament";
            this.create_tournament.Size = new System.Drawing.Size(188, 70);
            this.create_tournament.TabIndex = 31;
            this.create_tournament.Text = "Create Tournament";
            this.create_tournament.UseVisualStyleBackColor = true;
            this.create_tournament.Click += new System.EventHandler(this.create_tournament_Click);
            // 
            // Create_prize
            // 
            this.Create_prize.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Create_prize.Location = new System.Drawing.Point(533, 299);
            this.Create_prize.Name = "Create_prize";
            this.Create_prize.Size = new System.Drawing.Size(113, 44);
            this.Create_prize.TabIndex = 37;
            this.Create_prize.Text = "Create Prize";
            this.Create_prize.UseVisualStyleBackColor = true;
            this.Create_prize.Click += new System.EventHandler(this.Create_prize_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(97, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 29);
            this.button1.TabIndex = 38;
            this.button1.Text = "Add Team";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Select team :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // select_team_combox
            // 
            this.select_team_combox.FormattingEnabled = true;
            this.select_team_combox.Location = new System.Drawing.Point(69, 103);
            this.select_team_combox.Name = "select_team_combox";
            this.select_team_combox.Size = new System.Drawing.Size(342, 28);
            this.select_team_combox.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(460, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Prizes :";
            // 
            // Selected_prize_list_listbox
            // 
            this.Selected_prize_list_listbox.FormattingEnabled = true;
            this.Selected_prize_list_listbox.ItemHeight = 20;
            this.Selected_prize_list_listbox.Location = new System.Drawing.Point(460, 136);
            this.Selected_prize_list_listbox.Name = "Selected_prize_list_listbox";
            this.Selected_prize_list_listbox.Size = new System.Drawing.Size(282, 144);
            this.Selected_prize_list_listbox.TabIndex = 41;
            this.Selected_prize_list_listbox.SelectedIndexChanged += new System.EventHandler(this.Selected_prize_list_listbox_SelectedIndexChanged);
            // 
            // Create_new_tournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 482);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Selected_prize_list_listbox);
            this.Controls.Add(this.select_team_combox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Create_prize);
            this.Controls.Add(this.Teams);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tournament_name);
            this.Controls.Add(this.member_listbox);
            this.Controls.Add(this.teame_name);
            this.Controls.Add(this.create_tournament);
            this.Name = "Create_new_tournament";
            this.Text = "Create_new_tournament";
            this.Load += new System.EventHandler(this.Create_new_tournament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Teams;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tournament_name;
        private System.Windows.Forms.ListBox member_listbox;
        private System.Windows.Forms.Label teame_name;
        private System.Windows.Forms.Button create_tournament;
        private System.Windows.Forms.Button Create_prize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox select_team_combox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox Selected_prize_list_listbox;
    }
}