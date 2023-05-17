
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Teams
            // 
            this.Teams.AutoSize = true;
            this.Teams.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Teams.Location = new System.Drawing.Point(3, 107);
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
            this.tournament_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tournament_name.Location = new System.Drawing.Point(327, 7);
            this.tournament_name.Name = "tournament_name";
            this.tournament_name.Size = new System.Drawing.Size(434, 27);
            this.tournament_name.TabIndex = 34;
            // 
            // member_listbox
            // 
            this.member_listbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.member_listbox.FormattingEnabled = true;
            this.member_listbox.ItemHeight = 20;
            this.member_listbox.Location = new System.Drawing.Point(3, 138);
            this.member_listbox.Name = "member_listbox";
            this.member_listbox.Size = new System.Drawing.Size(387, 244);
            this.member_listbox.TabIndex = 33;
            this.member_listbox.SelectedIndexChanged += new System.EventHandler(this.member_listbox_SelectedIndexChanged);
            // 
            // teame_name
            // 
            this.teame_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.teame_name.AutoSize = true;
            this.teame_name.Location = new System.Drawing.Point(3, 11);
            this.teame_name.Name = "teame_name";
            this.teame_name.Size = new System.Drawing.Size(318, 20);
            this.teame_name.TabIndex = 32;
            this.teame_name.Text = "Tournament Name";
            // 
            // create_tournament
            // 
            this.create_tournament.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.create_tournament.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.create_tournament.Location = new System.Drawing.Point(85, 264);
            this.create_tournament.Name = "create_tournament";
            this.create_tournament.Size = new System.Drawing.Size(188, 70);
            this.create_tournament.TabIndex = 31;
            this.create_tournament.Text = "Create Tournament";
            this.create_tournament.UseVisualStyleBackColor = true;
            this.create_tournament.Click += new System.EventHandler(this.create_tournament_Click);
            // 
            // Create_prize
            // 
            this.Create_prize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Create_prize.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Create_prize.Location = new System.Drawing.Point(123, 204);
            this.Create_prize.Name = "Create_prize";
            this.Create_prize.Size = new System.Drawing.Size(113, 39);
            this.Create_prize.TabIndex = 37;
            this.Create_prize.Text = "Create Prize";
            this.Create_prize.UseVisualStyleBackColor = true;
            this.Create_prize.Click += new System.EventHandler(this.Create_prize_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(144, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 28);
            this.button1.TabIndex = 38;
            this.button1.Text = "Add Team";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 39;
            this.label1.Text = "Select team :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // select_team_combox
            // 
            this.select_team_combox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.select_team_combox.FormattingEnabled = true;
            this.select_team_combox.Location = new System.Drawing.Point(3, 36);
            this.select_team_combox.Name = "select_team_combox";
            this.select_team_combox.Size = new System.Drawing.Size(387, 28);
            this.select_team_combox.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Prizes :";
            // 
            // Selected_prize_list_listbox
            // 
            this.Selected_prize_list_listbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Selected_prize_list_listbox.FormattingEnabled = true;
            this.Selected_prize_list_listbox.ItemHeight = 20;
            this.Selected_prize_list_listbox.Location = new System.Drawing.Point(3, 33);
            this.Selected_prize_list_listbox.Name = "Selected_prize_list_listbox";
            this.Selected_prize_list_listbox.Size = new System.Drawing.Size(353, 164);
            this.Selected_prize_list_listbox.TabIndex = 41;
            this.Selected_prize_list_listbox.SelectedIndexChanged += new System.EventHandler(this.Selected_prize_list_listbox_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.Create_prize, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.create_tournament, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Selected_prize_list_listbox, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(402, 22);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.86989F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.13011F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(359, 352);
            this.tableLayoutPanel1.TabIndex = 43;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.select_team_combox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Teams, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.member_listbox, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.68116F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.31884F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 255F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(393, 391);
            this.tableLayoutPanel2.TabIndex = 44;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.26629F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.73371F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 88);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(764, 397);
            this.tableLayoutPanel3.TabIndex = 45;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(53, 22);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.54032F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.45968F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(770, 488);
            this.tableLayoutPanel4.TabIndex = 46;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.50814F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.49186F));
            this.tableLayoutPanel5.Controls.Add(this.tournament_name, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.teame_name, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 21);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(764, 42);
            this.tableLayoutPanel5.TabIndex = 47;
            // 
            // Create_new_tournament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 548);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Create_new_tournament";
            this.Text = "Create_new_tournament";
            this.Load += new System.EventHandler(this.Create_new_tournament_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}