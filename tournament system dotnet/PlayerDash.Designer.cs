
namespace tournament_system_dotnet
{
    partial class PlayerDash
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.createteam = new System.Windows.Forms.Button();
            this.profile_icon = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profile_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(105, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Playing Tournaments :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(95, 90);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(386, 124);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(628, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(95, 282);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(386, 124);
            this.listBox2.TabIndex = 32;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(105, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 23);
            this.label3.TabIndex = 31;
            this.label3.Text = "Finished Tournaments :";
            // 
            // createteam
            // 
            this.createteam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createteam.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createteam.Location = new System.Drawing.Point(530, 192);
            this.createteam.Name = "createteam";
            this.createteam.Size = new System.Drawing.Size(174, 66);
            this.createteam.TabIndex = 34;
            this.createteam.Text = "Create Team";
            this.createteam.UseVisualStyleBackColor = true;
            this.createteam.Click += new System.EventHandler(this.createteam_Click);
            // 
            // profile_icon
            // 
            this.profile_icon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profile_icon.Image = global::tournament_system_dotnet.Properties.Resources.profile_icon;
            this.profile_icon.InitialImage = null;
            this.profile_icon.Location = new System.Drawing.Point(703, 12);
            this.profile_icon.Name = "profile_icon";
            this.profile_icon.Size = new System.Drawing.Size(85, 64);
            this.profile_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_icon.TabIndex = 42;
            this.profile_icon.TabStop = false;
            this.profile_icon.Click += new System.EventHandler(this.profile_icon_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 27);
            this.button2.TabIndex = 43;
            this.button2.Text = "logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(212, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(424, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "You can only view the match details of finished tournament";
            // 
            // PlayerDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.profile_icon);
            this.Controls.Add(this.createteam);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "PlayerDash";
            this.Text = "PlayerDash";
            this.Load += new System.EventHandler(this.PlayerDash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profile_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button createteam;
        private System.Windows.Forms.PictureBox profile_icon;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
    }
}