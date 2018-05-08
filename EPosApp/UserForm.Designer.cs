namespace EPosApp
{
    partial class UserForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCngPassword = new EPosApp.ButtonX();
            this.btnSignOut = new EPosApp.ButtonX();
            this.btnProfile = new EPosApp.ButtonX();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(141)))), ((int)(((byte)(188)))));
            this.panel1.Controls.Add(this.pictureBoxProfile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 191);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(90, 38);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(100, 50);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxProfile.TabIndex = 1;
            this.pictureBoxProfile.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName";
            // 
            // btnCngPassword
            // 
            this.btnCngPassword.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnCngPassword.BZBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCngPassword.ChangeColorMouseHC = true;
            this.btnCngPassword.DisplayText = "Change Password";
            this.btnCngPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCngPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnCngPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnCngPassword.Location = new System.Drawing.Point(132, 201);
            this.btnCngPassword.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnCngPassword.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnCngPassword.Name = "btnCngPassword";
            this.btnCngPassword.Size = new System.Drawing.Size(146, 28);
            this.btnCngPassword.TabIndex = 40;
            this.btnCngPassword.Text = "Change Password";
            this.btnCngPassword.TextLocation_X = 22;
            this.btnCngPassword.TextLocation_Y = 4;
            this.btnCngPassword.UseVisualStyleBackColor = false;
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnSignOut.BZBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSignOut.ChangeColorMouseHC = true;
            this.btnSignOut.DisplayText = "Sign Out";
            this.btnSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignOut.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSignOut.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnSignOut.Location = new System.Drawing.Point(184, 235);
            this.btnSignOut.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnSignOut.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(92, 28);
            this.btnSignOut.TabIndex = 41;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.TextLocation_X = 20;
            this.btnSignOut.TextLocation_Y = 4;
            this.btnSignOut.UseVisualStyleBackColor = false;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnProfile.BZBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnProfile.ChangeColorMouseHC = true;
            this.btnProfile.DisplayText = "Profile";
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProfile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnProfile.Location = new System.Drawing.Point(24, 201);
            this.btnProfile.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(180)))), ((int)(((byte)(200)))));
            this.btnProfile.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(92, 28);
            this.btnProfile.TabIndex = 41;
            this.btnProfile.Text = "Profile";
            this.btnProfile.TextLocation_X = 20;
            this.btnProfile.TextLocation_Y = 4;
            this.btnProfile.UseVisualStyleBackColor = false;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 264);
            this.Controls.Add(this.btnCngPassword);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.btnProfile);
            this.Controls.Add(this.panel1);
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.Label label1;
        private ButtonX btnCngPassword;
        private ButtonX btnProfile;
        private ButtonX btnSignOut;
    }
}