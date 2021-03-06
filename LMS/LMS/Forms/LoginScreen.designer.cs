namespace LMS
{
    partial class LoginScreen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.chkUnmask = new System.Windows.Forms.CheckBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAttempt = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bttnLogin = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.i32x32 = new System.Windows.Forms.ImageList(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsTab = true;
            this.txtPassword.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtPassword.Location = new System.Drawing.Point(183, 118);
            this.txtPassword.MaxLength = 9000;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(207, 21);
            this.txtPassword.TabIndex = 40;
            this.txtPassword.Tag = "Password";
            this.txtPassword.Text = "321";
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(183, 75);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(207, 21);
            this.txtUsername.TabIndex = 39;
            this.txtUsername.Text = "ali";
            // 
            // chkUnmask
            // 
            this.chkUnmask.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkUnmask.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkUnmask.Location = new System.Drawing.Point(80, 145);
            this.chkUnmask.Name = "chkUnmask";
            this.chkUnmask.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkUnmask.Size = new System.Drawing.Size(171, 28);
            this.chkUnmask.TabIndex = 41;
            this.chkUnmask.Text = "Show password mask";
            this.chkUnmask.CheckedChanged += new System.EventHandler(this.chkUnmask_CheckedChanged);
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.Color.Transparent;
            this.Label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(96, 118);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(72, 16);
            this.Label3.TabIndex = 43;
            this.Label3.Text = "پسورد:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "نام کاربری:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblAttempt
            // 
            this.lblAttempt.AutoSize = true;
            this.lblAttempt.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttempt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAttempt.Location = new System.Drawing.Point(206, 208);
            this.lblAttempt.Name = "lblAttempt";
            this.lblAttempt.Size = new System.Drawing.Size(15, 16);
            this.lblAttempt.TabIndex = 47;
            this.lblAttempt.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 14);
            this.label2.TabIndex = 46;
            this.label2.Text = "Number of effort:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(349, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 14);
            this.label13.TabIndex = 329;
            this.label13.Text = "انصراف";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(390, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 14);
            this.label11.TabIndex = 328;
            this.label11.Text = "ورود";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnLogin
            // 
            this.bttnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnLogin.Location = new System.Drawing.Point(391, 198);
            this.bttnLogin.Name = "bttnLogin";
            this.bttnLogin.Size = new System.Drawing.Size(36, 37);
            this.bttnLogin.TabIndex = 326;
            this.bttnLogin.UseVisualStyleBackColor = true;
            this.bttnLogin.Click += new System.EventHandler(this.bttnLogin_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.Location = new System.Drawing.Point(351, 198);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(37, 37);
            this.bttnCancel.TabIndex = 327;
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // i32x32
            // 
            this.i32x32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("i32x32.ImageStream")));
            this.i32x32.TransparentColor = System.Drawing.Color.Transparent;
            this.i32x32.Images.SetKeyName(0, "hand.png");
            this.i32x32.Images.SetKeyName(1, "error.png");
            this.i32x32.Images.SetKeyName(2, "Document Add.png");
            this.i32x32.Images.SetKeyName(3, "Document 2 Add.png");
            this.i32x32.Images.SetKeyName(4, "Document Check.png");
            this.i32x32.Images.SetKeyName(5, "Security.png");
            this.i32x32.Images.SetKeyName(6, "Symbol Check 2.png");
            this.i32x32.Images.SetKeyName(7, "Symbol Check.png");
            this.i32x32.Images.SetKeyName(8, "Security Enabled.png");
            this.i32x32.Images.SetKeyName(9, "Security Security.png");
            this.i32x32.Images.SetKeyName(10, "Security View.png");
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.ForeColor = System.Drawing.Color.DarkGray;
            this.label5.Location = new System.Drawing.Point(80, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 1);
            this.label5.TabIndex = 331;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 258);
            this.pictureBox1.TabIndex = 330;
            this.pictureBox1.TabStop = false;
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 254);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bttnLogin);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.lblAttempt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.chkUnmask);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label4);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Screen";
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.Activated += new System.EventHandler(this.LoginScreen_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtPassword;
        internal System.Windows.Forms.TextBox txtUsername;
        internal System.Windows.Forms.CheckBox chkUnmask;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
      //  private ctrlLineHorizontal ctrlLineHorizontal1;
        private System.Windows.Forms.Label lblAttempt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bttnLogin;
        private System.Windows.Forms.Button bttnCancel;
        public System.Windows.Forms.ImageList i32x32;
        private System.Windows.Forms.Label label5;
    }
}