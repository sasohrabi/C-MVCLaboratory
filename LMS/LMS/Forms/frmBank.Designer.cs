namespace LMS.Forms
{
    partial class frmBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBank));
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.cboNumberReceipt = new System.Windows.Forms.ComboBox();
            this.ctrlLineHorizontal1 = new LMS.Controls.ctrlLineHorizontal();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPayment
            // 
            this.txtPayment.BackColor = System.Drawing.Color.White;
            this.txtPayment.Location = new System.Drawing.Point(335, 49);
            this.txtPayment.MaxLength = 50;
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(156, 21);
            this.txtPayment.TabIndex = 265;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 275;
            this.label1.Text = "Total cost:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 15);
            this.label8.TabIndex = 274;
            this.label8.Text = "Addmission code:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(402, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 15);
            this.label13.TabIndex = 271;
            this.label13.Text = "&Update";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(450, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 270;
            this.label11.Text = "&Cancel";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnUpdate.Location = new System.Drawing.Point(405, 94);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(40, 40);
            this.bttnUpdate.TabIndex = 267;
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.Location = new System.Drawing.Point(451, 94);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(40, 40);
            this.bttnCancel.TabIndex = 268;
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // picHeader
            // 
            this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            this.picHeader.Location = new System.Drawing.Point(0, 0);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(503, 36);
            this.picHeader.TabIndex = 269;
            this.picHeader.TabStop = false;
            // 
            // cboNumberReceipt
            // 
            this.cboNumberReceipt.BackColor = System.Drawing.Color.White;
            this.cboNumberReceipt.FormattingEnabled = true;
            this.cboNumberReceipt.Location = new System.Drawing.Point(106, 48);
            this.cboNumberReceipt.Name = "cboNumberReceipt";
            this.cboNumberReceipt.Size = new System.Drawing.Size(129, 23);
            this.cboNumberReceipt.TabIndex = 276;
            this.cboNumberReceipt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboNumberReceipt_KeyPress);
            this.cboNumberReceipt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboNumberReceipt_KeyDown);
            // 
            // ctrlLineHorizontal1
            // 
            this.ctrlLineHorizontal1.BackColor = System.Drawing.Color.Silver;
            this.ctrlLineHorizontal1.Location = new System.Drawing.Point(5, 87);
            this.ctrlLineHorizontal1.Name = "ctrlLineHorizontal1";
            this.ctrlLineHorizontal1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrlLineHorizontal1.Size = new System.Drawing.Size(486, 1);
            this.ctrlLineHorizontal1.TabIndex = 277;
            // 
            // frmBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(503, 154);
            this.Controls.Add(this.ctrlLineHorizontal1);
            this.Controls.Add(this.cboNumberReceipt);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.picHeader);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "frmBank";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBank";
            this.Load += new System.EventHandler(this.frmBank_Load);
            this.Activated += new System.EventHandler(this.frmBank_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.ComboBox cboNumberReceipt;
        private LMS.Controls.ctrlLineHorizontal ctrlLineHorizontal1;
    }
}