
namespace tournament_system_dotnet
{
    partial class Create_user
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Userx = new System.Windows.Forms.ComboBox();
            this.Passwordx = new System.Windows.Forms.TextBox();
            this.Emailx = new System.Windows.Forms.TextBox();
            this.numberx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Namex = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::tournament_system_dotnet.Properties.Resources.back_icon;
            this.pictureBox1.Location = new System.Drawing.Point(34, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Userx
            // 
            this.Userx.FormattingEnabled = true;
            this.Userx.Items.AddRange(new object[] {
            "Organizer",
            "Player"});
            this.Userx.Location = new System.Drawing.Point(304, 262);
            this.Userx.Name = "Userx";
            this.Userx.Size = new System.Drawing.Size(186, 28);
            this.Userx.TabIndex = 23;
            this.Userx.Text = "select user (compulsory)";
            // 
            // Passwordx
            // 
            this.Passwordx.Location = new System.Drawing.Point(273, 115);
            this.Passwordx.Name = "Passwordx";
            this.Passwordx.Size = new System.Drawing.Size(334, 27);
            this.Passwordx.TabIndex = 22;
            // 
            // Emailx
            // 
            this.Emailx.Location = new System.Drawing.Point(273, 162);
            this.Emailx.Name = "Emailx";
            this.Emailx.Size = new System.Drawing.Size(334, 27);
            this.Emailx.TabIndex = 21;
            this.Emailx.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // numberx
            // 
            this.numberx.Location = new System.Drawing.Point(273, 204);
            this.numberx.Name = "numberx";
            this.numberx.Size = new System.Drawing.Size(334, 27);
            this.numberx.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "password";
            // 
            // Namex
            // 
            this.Namex.Location = new System.Drawing.Point(273, 68);
            this.Namex.Name = "Namex";
            this.Namex.Size = new System.Drawing.Size(334, 27);
            this.Namex.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(382, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 69);
            this.button1.TabIndex = 14;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(198, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name  ";
            // 
            // Create_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Userx);
            this.Controls.Add(this.Passwordx);
            this.Controls.Add(this.Emailx);
            this.Controls.Add(this.numberx);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Namex);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Create_user";
            this.Text = "Create_user";
            this.Load += new System.EventHandler(this.Create_user_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox Userx;
        private System.Windows.Forms.TextBox Passwordx;
        private System.Windows.Forms.TextBox Emailx;
        private System.Windows.Forms.TextBox numberx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Namex;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}