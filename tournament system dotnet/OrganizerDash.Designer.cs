
namespace tournament_system_dotnet
{
    partial class OrganizerDash
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
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profile_icon = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profile_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // createteam
            // 
            this.createteam.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createteam.Location = new System.Drawing.Point(543, 180);
            this.createteam.Name = "createteam";
            this.createteam.Size = new System.Drawing.Size(161, 99);
            this.createteam.TabIndex = 40;
            this.createteam.Text = "Create New Tournament";
            this.createteam.UseVisualStyleBackColor = true;
            this.createteam.Click += new System.EventHandler(this.createteam_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(84, 267);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(386, 124);
            this.listBox2.TabIndex = 39;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(94, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 23);
            this.label3.TabIndex = 38;
            this.label3.Text = "Finished Tournaments";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(84, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(386, 124);
            this.listBox1.TabIndex = 36;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(94, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "Running Tournaments";
            // 
            // profile_icon
            // 
            this.profile_icon.Image = global::tournament_system_dotnet.Properties.Resources.profile_icon;
            this.profile_icon.InitialImage = null;
            this.profile_icon.Location = new System.Drawing.Point(690, 16);
            this.profile_icon.Name = "profile_icon";
            this.profile_icon.Size = new System.Drawing.Size(85, 64);
            this.profile_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profile_icon.TabIndex = 41;
            this.profile_icon.TabStop = false;
            this.profile_icon.Click += new System.EventHandler(this.profile_icon_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 27);
            this.button2.TabIndex = 44;
            this.button2.Text = "logout";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // OrganizerDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.profile_icon);
            this.Controls.Add(this.createteam);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Name = "OrganizerDash";
            this.Text = "OrganizerDash";
            ((System.ComponentModel.ISupportInitialize)(this.profile_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createteam;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox profile_icon;
        private System.Windows.Forms.Button button2;
    }
}