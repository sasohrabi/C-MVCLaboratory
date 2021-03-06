namespace LMS.Forms
{
    partial class frmUsers_Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers_Modify));
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCompleteName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAdminType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMobileNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelephoneNumber = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.BackColor = System.Drawing.Color.White;
            this.txtStreetAddress.Location = new System.Drawing.Point(100, 206);
            this.txtStreetAddress.MaxLength = 50;
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(246, 21);
            this.txtStreetAddress.TabIndex = 262;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 264;
            this.label4.Text = "Address:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCompleteName
            // 
            this.txtCompleteName.BackColor = System.Drawing.Color.White;
            this.txtCompleteName.Location = new System.Drawing.Point(120, 165);
            this.txtCompleteName.MaxLength = 20;
            this.txtCompleteName.Name = "txtCompleteName";
            this.txtCompleteName.Size = new System.Drawing.Size(226, 21);
            this.txtCompleteName.TabIndex = 261;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 15);
            this.label7.TabIndex = 263;
            this.label7.Text = "Name and Family:";
            // 
            // txtUPassword
            // 
            this.txtUPassword.BackColor = System.Drawing.Color.White;
            this.txtUPassword.Location = new System.Drawing.Point(100, 126);
            this.txtUPassword.MaxLength = 50;
            this.txtUPassword.Name = "txtUPassword";
            this.txtUPassword.Size = new System.Drawing.Size(246, 21);
            this.txtUPassword.TabIndex = 250;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 260;
            this.label2.Text = "Password:";
            // 
            // txtAdminType
            // 
            this.txtAdminType.BackColor = System.Drawing.Color.White;
            this.txtAdminType.Location = new System.Drawing.Point(100, 84);
            this.txtAdminType.MaxLength = 50;
            this.txtAdminType.Name = "txtAdminType";
            this.txtAdminType.Size = new System.Drawing.Size(246, 21);
            this.txtAdminType.TabIndex = 249;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 259;
            this.label1.Text = "User Type:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(100, 43);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(246, 21);
            this.txtUsername.TabIndex = 248;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodeTest_KeyDown);
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeTest_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 15);
            this.label8.TabIndex = 258;
            this.label8.Text = "User Name:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(257, 407);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 15);
            this.label13.TabIndex = 255;
            this.label13.Text = "&Update";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(305, 407);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 254;
            this.label11.Text = "&Cancel";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnUpdate.Location = new System.Drawing.Point(260, 364);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(40, 40);
            this.bttnUpdate.TabIndex = 251;
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.Location = new System.Drawing.Point(306, 364);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(40, 40);
            this.bttnCancel.TabIndex = 252;
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // picHeader
            // 
            this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            this.picHeader.Location = new System.Drawing.Point(0, 0);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(358, 36);
            this.picHeader.TabIndex = 253;
            this.picHeader.TabStop = false;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BackColor = System.Drawing.Color.White;
            this.txtEmailAddress.Location = new System.Drawing.Point(100, 328);
            this.txtEmailAddress.MaxLength = 50;
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(246, 21);
            this.txtEmailAddress.TabIndex = 267;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 15);
            this.label3.TabIndex = 270;
            this.label3.Text = "Email:";
            // 
            // txtMobileNumber
            // 
            this.txtMobileNumber.BackColor = System.Drawing.Color.White;
            this.txtMobileNumber.Location = new System.Drawing.Point(100, 286);
            this.txtMobileNumber.MaxLength = 50;
            this.txtMobileNumber.Name = "txtMobileNumber";
            this.txtMobileNumber.Size = new System.Drawing.Size(246, 21);
            this.txtMobileNumber.TabIndex = 266;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 269;
            this.label9.Text = "Mobile:";
            // 
            // txtTelephoneNumber
            // 
            this.txtTelephoneNumber.BackColor = System.Drawing.Color.White;
            this.txtTelephoneNumber.Location = new System.Drawing.Point(100, 245);
            this.txtTelephoneNumber.MaxLength = 20;
            this.txtTelephoneNumber.Name = "txtTelephoneNumber";
            this.txtTelephoneNumber.Size = new System.Drawing.Size(246, 21);
            this.txtTelephoneNumber.TabIndex = 265;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 15);
            this.label10.TabIndex = 268;
            this.label10.Text = "Telephone:";
            // 
            // frmUsers_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(358, 427);
            this.Controls.Add(this.txtEmailAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMobileNumber);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTelephoneNumber);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtStreetAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCompleteName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtUPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdminType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.picHeader);
            this.Font = new System.Drawing.Font("Arial", 9F);
            this.MaximizeBox = false;
            this.Name = "frmUsers_Modify";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmUsers_Modify_Load);
            this.Activated += new System.EventHandler(this.frmUsers_Modify_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCompleteName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAdminType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMobileNumber;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelephoneNumber;
        private System.Windows.Forms.Label label10;
    }
}