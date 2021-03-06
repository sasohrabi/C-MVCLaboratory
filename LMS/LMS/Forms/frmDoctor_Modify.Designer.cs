namespace LMS.Forms
{
    partial class frmDoctor_Modify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoctor_Modify));
            this.txtProficiency = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodeDoctor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.picHeader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProficiency
            // 
            this.txtProficiency.BackColor = System.Drawing.Color.White;
            this.txtProficiency.Location = new System.Drawing.Point(115, 165);
            this.txtProficiency.MaxLength = 20;
            this.txtProficiency.Name = "txtProficiency";
            this.txtProficiency.Size = new System.Drawing.Size(231, 21);
            this.txtProficiency.TabIndex = 261;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 263;
            this.label7.Text = "Doctor Specialty:";
            // 
            // txtFamily
            // 
            this.txtFamily.BackColor = System.Drawing.Color.White;
            this.txtFamily.Location = new System.Drawing.Point(115, 126);
            this.txtFamily.MaxLength = 50;
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(231, 21);
            this.txtFamily.TabIndex = 250;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 260;
            this.label2.Text = "Doctor Family:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Location = new System.Drawing.Point(115, 84);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(231, 21);
            this.txtName.TabIndex = 249;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 15);
            this.label1.TabIndex = 259;
            this.label1.Text = "Doctor Name:\r\n";
            // 
            // txtCodeDoctor
            // 
            this.txtCodeDoctor.BackColor = System.Drawing.Color.White;
            this.txtCodeDoctor.Location = new System.Drawing.Point(115, 43);
            this.txtCodeDoctor.MaxLength = 20;
            this.txtCodeDoctor.Name = "txtCodeDoctor";
            this.txtCodeDoctor.Size = new System.Drawing.Size(231, 21);
            this.txtCodeDoctor.TabIndex = 248;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 15);
            this.label8.TabIndex = 258;
            this.label8.Text = "Doctor Code:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(258, 244);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 15);
            this.label13.TabIndex = 255;
            this.label13.Text = "&Update";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(306, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 254;
            this.label11.Text = "&Cancel";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnUpdate.Location = new System.Drawing.Point(261, 201);
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
            this.bttnCancel.Location = new System.Drawing.Point(307, 201);
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
            // frmDoctor_Modify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.bttnCancel;
            this.ClientSize = new System.Drawing.Size(358, 261);
            this.Controls.Add(this.txtProficiency);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtFamily);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodeDoctor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.picHeader);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "frmDoctor_Modify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDoctor_Modify";
            this.Load += new System.EventHandler(this.frmDoctor_Modify_Load);
            this.Activated += new System.EventHandler(this.frmDoctor_Modify_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProficiency;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodeDoctor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.PictureBox picHeader;

    }
}