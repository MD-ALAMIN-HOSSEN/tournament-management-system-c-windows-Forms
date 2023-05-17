
namespace tournament_system_dotnet
{
    partial class update_profile
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
            this.Passwordx = new System.Windows.Forms.TextBox();
            this.Emailx = new System.Windows.Forms.TextBox();
            this.numberx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::tournament_system_dotnet.Properties.Resources.back_icon;
            this.pictureBox1.Location = new System.Drawing.Point(36, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Passwordx
            // 
            this.Passwordx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Passwordx.Location = new System.Drawing.Point(275, 122);
            this.Passwordx.Name = "Passwordx";
            this.Passwordx.Size = new System.Drawing.Size(334, 27);
            this.Passwordx.TabIndex = 32;
            // 
            // Emailx
            // 
            this.Emailx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Emailx.Location = new System.Drawing.Point(275, 169);
            this.Emailx.Name = "Emailx";
            this.Emailx.Size = new System.Drawing.Size(334, 27);
            this.Emailx.TabIndex = 31;
            // 
            // numberx
            // 
            this.numberx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numberx.Location = new System.Drawing.Point(275, 211);
            this.numberx.Name = "numberx";
            this.numberx.Size = new System.Drawing.Size(334, 27);
            this.numberx.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(200, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Number";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Email";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "password";
            // 
            // Update
            // 
            this.Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Update.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Update.Location = new System.Drawing.Point(275, 280);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(133, 69);
            this.Update.TabIndex = 34;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Delete.Location = new System.Drawing.Point(436, 280);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(133, 69);
            this.Delete.TabIndex = 35;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // update_profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Passwordx);
            this.Controls.Add(this.Emailx);
            this.Controls.Add(this.numberx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "update_profile";
            this.Text = "update_profile";
            this.Load += new System.EventHandler(this.update_profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Passwordx;
        private System.Windows.Forms.TextBox Emailx;
        private System.Windows.Forms.TextBox numberx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
    }
}