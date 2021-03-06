namespace LMS.Forms
{
    partial class frmResult
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResult));
            this.cboNumberReceipt = new System.Windows.Forms.ComboBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.cboCodeTest = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelBOTTOM_RIGHT = new System.Windows.Forms.Panel();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.panelBOTTOM_RIGHT_RIGHT = new System.Windows.Forms.Panel();
            this.bttnLast = new System.Windows.Forms.Button();
            this.bttnNext = new System.Windows.Forms.Button();
            this.bttnPrevious = new System.Windows.Forms.Button();
            this.bttnFirst = new System.Windows.Forms.Button();
            this.panelBOTTOM = new System.Windows.Forms.Panel();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lvPostalCodes = new System.Windows.Forms.ListView();
            this.chNumberReceipt = new System.Windows.Forms.ColumnHeader();
            this.chCodeTest = new System.Windows.Forms.ColumnHeader();
            this.chNameTest = new System.Windows.Forms.ColumnHeader();
            this.chCodePatient = new System.Windows.Forms.ColumnHeader();
            this.chCodeInsurance = new System.Windows.Forms.ColumnHeader();
            this.chPercent_Payment = new System.Windows.Forms.ColumnHeader();
            this.chDateReception = new System.Windows.Forms.ColumnHeader();
            this.chStatement = new System.Windows.Forms.ColumnHeader();
            this.ctrlLineHorizontal1 = new LMS.Controls.ctrlLineHorizontal();
            this.label15 = new System.Windows.Forms.Label();
            this.bttnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.panelBOTTOM_RIGHT.SuspendLayout();
            this.panelBOTTOM_RIGHT_RIGHT.SuspendLayout();
            this.panelBOTTOM.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboNumberReceipt
            // 
            this.cboNumberReceipt.BackColor = System.Drawing.Color.White;
            this.cboNumberReceipt.FormattingEnabled = true;
            this.cboNumberReceipt.Location = new System.Drawing.Point(117, 50);
            this.cboNumberReceipt.Name = "cboNumberReceipt";
            this.cboNumberReceipt.Size = new System.Drawing.Size(375, 23);
            this.cboNumberReceipt.TabIndex = 0;
            this.cboNumberReceipt.SelectedIndexChanged += new System.EventHandler(this.cboNumberReceipt_SelectedIndexChanged);
            // 
            // txtAnswer
            // 
            this.txtAnswer.BackColor = System.Drawing.Color.White;
            this.txtAnswer.Location = new System.Drawing.Point(320, 92);
            this.txtAnswer.MaxLength = 50;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(172, 21);
            this.txtAnswer.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 287;
            this.label1.Text = "Result:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 15);
            this.label8.TabIndex = 286;
            this.label8.Text = "Admission Code:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(355, 431);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 15);
            this.label13.TabIndex = 283;
            this.label13.Text = "&Update";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(452, 431);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 282;
            this.label11.Text = "&Cancel";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnUpdate.Location = new System.Drawing.Point(361, 388);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(40, 40);
            this.bttnUpdate.TabIndex = 3;
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.Location = new System.Drawing.Point(453, 388);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(40, 40);
            this.bttnCancel.TabIndex = 280;
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // picHeader
            // 
            this.picHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            this.picHeader.Location = new System.Drawing.Point(0, 0);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(504, 36);
            this.picHeader.TabIndex = 281;
            this.picHeader.TabStop = false;
            // 
            // cboCodeTest
            // 
            this.cboCodeTest.BackColor = System.Drawing.Color.White;
            this.cboCodeTest.FormattingEnabled = true;
            this.cboCodeTest.Location = new System.Drawing.Point(78, 92);
            this.cboCodeTest.Name = "cboCodeTest";
            this.cboCodeTest.Size = new System.Drawing.Size(174, 23);
            this.cboCodeTest.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 290;
            this.label2.Text = "Test Code:";
            // 
            // panelBOTTOM_RIGHT
            // 
            this.panelBOTTOM_RIGHT.BackColor = System.Drawing.Color.Transparent;
            this.panelBOTTOM_RIGHT.Controls.Add(this.lblRecordCount);
            this.panelBOTTOM_RIGHT.Controls.Add(this.panelBOTTOM_RIGHT_RIGHT);
            this.panelBOTTOM_RIGHT.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBOTTOM_RIGHT.Location = new System.Drawing.Point(184, 0);
            this.panelBOTTOM_RIGHT.Name = "panelBOTTOM_RIGHT";
            this.panelBOTTOM_RIGHT.Size = new System.Drawing.Size(320, 34);
            this.panelBOTTOM_RIGHT.TabIndex = 3;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Location = new System.Drawing.Point(26, 10);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(162, 15);
            this.lblRecordCount.TabIndex = 8;
            this.lblRecordCount.Text = "Record 0 - 0 of 0";
            this.lblRecordCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelBOTTOM_RIGHT_RIGHT
            // 
            this.panelBOTTOM_RIGHT_RIGHT.Controls.Add(this.bttnLast);
            this.panelBOTTOM_RIGHT_RIGHT.Controls.Add(this.bttnNext);
            this.panelBOTTOM_RIGHT_RIGHT.Controls.Add(this.bttnPrevious);
            this.panelBOTTOM_RIGHT_RIGHT.Controls.Add(this.bttnFirst);
            this.panelBOTTOM_RIGHT_RIGHT.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBOTTOM_RIGHT_RIGHT.Location = new System.Drawing.Point(191, 0);
            this.panelBOTTOM_RIGHT_RIGHT.Name = "panelBOTTOM_RIGHT_RIGHT";
            this.panelBOTTOM_RIGHT_RIGHT.Size = new System.Drawing.Size(129, 34);
            this.panelBOTTOM_RIGHT_RIGHT.TabIndex = 7;
            // 
            // bttnLast
            // 
            this.bttnLast.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnLast.Enabled = false;
            this.bttnLast.Location = new System.Drawing.Point(94, 3);
            this.bttnLast.Name = "bttnLast";
            this.bttnLast.Size = new System.Drawing.Size(30, 30);
            this.bttnLast.TabIndex = 10;
            this.bttnLast.UseVisualStyleBackColor = true;
            this.bttnLast.Click += new System.EventHandler(this.bttnLast_Click);
            // 
            // bttnNext
            // 
            this.bttnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnNext.Enabled = false;
            this.bttnNext.Location = new System.Drawing.Point(65, 3);
            this.bttnNext.Name = "bttnNext";
            this.bttnNext.Size = new System.Drawing.Size(30, 30);
            this.bttnNext.TabIndex = 9;
            this.bttnNext.UseVisualStyleBackColor = true;
            this.bttnNext.Click += new System.EventHandler(this.bttnNext_Click);
            // 
            // bttnPrevious
            // 
            this.bttnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnPrevious.Enabled = false;
            this.bttnPrevious.Location = new System.Drawing.Point(36, 3);
            this.bttnPrevious.Name = "bttnPrevious";
            this.bttnPrevious.Size = new System.Drawing.Size(30, 30);
            this.bttnPrevious.TabIndex = 8;
            this.bttnPrevious.UseVisualStyleBackColor = true;
            this.bttnPrevious.Click += new System.EventHandler(this.bttnPrevious_Click);
            // 
            // bttnFirst
            // 
            this.bttnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnFirst.Enabled = false;
            this.bttnFirst.Location = new System.Drawing.Point(7, 3);
            this.bttnFirst.Name = "bttnFirst";
            this.bttnFirst.Size = new System.Drawing.Size(30, 30);
            this.bttnFirst.TabIndex = 7;
            this.bttnFirst.UseVisualStyleBackColor = true;
            this.bttnFirst.Click += new System.EventHandler(this.bttnFirst_Click);
            // 
            // panelBOTTOM
            // 
            this.panelBOTTOM.BackColor = System.Drawing.Color.White;
            this.panelBOTTOM.Controls.Add(this.panelBOTTOM_RIGHT);
            this.panelBOTTOM.Controls.Add(this.lblSelected);
            this.panelBOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBOTTOM.Location = new System.Drawing.Point(0, 452);
            this.panelBOTTOM.Name = "panelBOTTOM";
            this.panelBOTTOM.Size = new System.Drawing.Size(504, 34);
            this.panelBOTTOM.TabIndex = 292;
            // 
            // lblSelected
            // 
            this.lblSelected.AutoSize = true;
            this.lblSelected.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelected.ForeColor = System.Drawing.Color.Maroon;
            this.lblSelected.Location = new System.Drawing.Point(3, 10);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(139, 15);
            this.lblSelected.TabIndex = 0;
            this.lblSelected.Text = "Selected Record: NONE";
            // 
            // lvPostalCodes
            // 
            this.lvPostalCodes.BackColor = System.Drawing.Color.White;
            this.lvPostalCodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNumberReceipt,
            this.chCodeTest,
            this.chNameTest});
            this.lvPostalCodes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPostalCodes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPostalCodes.ForeColor = System.Drawing.Color.Black;
            this.lvPostalCodes.FullRowSelect = true;
            this.lvPostalCodes.GridLines = true;
            this.lvPostalCodes.Location = new System.Drawing.Point(9, 131);
            this.lvPostalCodes.Name = "lvPostalCodes";
            this.lvPostalCodes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvPostalCodes.RightToLeftLayout = true;
            this.lvPostalCodes.Size = new System.Drawing.Size(482, 251);
            this.lvPostalCodes.TabIndex = 293;
            this.lvPostalCodes.UseCompatibleStateImageBehavior = false;
            this.lvPostalCodes.View = System.Windows.Forms.View.Details;
            this.lvPostalCodes.Leave += new System.EventHandler(this.lvPostalCodes_Leave);
            this.lvPostalCodes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvPostalCodes_ColumnClick);
            this.lvPostalCodes.Click += new System.EventHandler(this.lvPostalCodes_Click);
            // 
            // chNumberReceipt
            // 
            this.chNumberReceipt.Text = "Admission Code";
            this.chNumberReceipt.Width = 149;
            // 
            // chCodeTest
            // 
            this.chCodeTest.Text = "Test Code";
            this.chCodeTest.Width = 145;
            // 
            // chNameTest
            // 
            this.chNameTest.Text = "Result";
            this.chNameTest.Width = 184;
            // 
            // chCodePatient
            // 
            this.chCodePatient.Text = "کد بیمار";
            this.chCodePatient.Width = 100;
            // 
            // chCodeInsurance
            // 
            this.chCodeInsurance.Text = "کد بیمه";
            this.chCodeInsurance.Width = 100;
            // 
            // chPercent_Payment
            // 
            this.chPercent_Payment.Text = "قیمت درصدی آزمایش";
            this.chPercent_Payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPercent_Payment.Width = 150;
            // 
            // chDateReception
            // 
            this.chDateReception.Text = "تاریخ پذیرش";
            this.chDateReception.Width = 100;
            // 
            // chStatement
            // 
            this.chStatement.Text = "توضیحات";
            this.chStatement.Width = 100;
            // 
            // ctrlLineHorizontal1
            // 
            this.ctrlLineHorizontal1.BackColor = System.Drawing.Color.Silver;
            this.ctrlLineHorizontal1.Location = new System.Drawing.Point(4, 448);
            this.ctrlLineHorizontal1.Name = "ctrlLineHorizontal1";
            this.ctrlLineHorizontal1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrlLineHorizontal1.Size = new System.Drawing.Size(490, 1);
            this.ctrlLineHorizontal1.TabIndex = 289;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(404, 431);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 15);
            this.label15.TabIndex = 295;
            this.label15.Text = "&Print";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnPrint
            // 
            this.bttnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnPrint.Location = new System.Drawing.Point(407, 388);
            this.bttnPrint.Name = "bttnPrint";
            this.bttnPrint.Size = new System.Drawing.Size(40, 40);
            this.bttnPrint.TabIndex = 294;
            this.bttnPrint.UseVisualStyleBackColor = true;
            this.bttnPrint.Click += new System.EventHandler(this.bttnPrint_Click);
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 486);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.bttnPrint);
            this.Controls.Add(this.lvPostalCodes);
            this.Controls.Add(this.panelBOTTOM);
            this.Controls.Add(this.cboCodeTest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ctrlLineHorizontal1);
            this.Controls.Add(this.cboNumberReceipt);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.picHeader);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "frmResult";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResult";
            this.Load += new System.EventHandler(this.frmResult_Load);
            this.Activated += new System.EventHandler(this.frmResult_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.panelBOTTOM_RIGHT.ResumeLayout(false);
            this.panelBOTTOM_RIGHT_RIGHT.ResumeLayout(false);
            this.panelBOTTOM.ResumeLayout(false);
            this.panelBOTTOM.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LMS.Controls.ctrlLineHorizontal ctrlLineHorizontal1;
        private System.Windows.Forms.ComboBox cboNumberReceipt;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.ComboBox cboCodeTest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelBOTTOM_RIGHT;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Panel panelBOTTOM_RIGHT_RIGHT;
        private System.Windows.Forms.Button bttnLast;
        private System.Windows.Forms.Button bttnNext;
        private System.Windows.Forms.Button bttnPrevious;
        private System.Windows.Forms.Button bttnFirst;
        private System.Windows.Forms.Panel panelBOTTOM;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ListView lvPostalCodes;
        private System.Windows.Forms.ColumnHeader chNumberReceipt;
        private System.Windows.Forms.ColumnHeader chNameTest;
        private System.Windows.Forms.ColumnHeader chCodePatient;
        private System.Windows.Forms.ColumnHeader chCodeInsurance;
        private System.Windows.Forms.ColumnHeader chCodeTest;
        private System.Windows.Forms.ColumnHeader chPercent_Payment;
        private System.Windows.Forms.ColumnHeader chDateReception;
        private System.Windows.Forms.ColumnHeader chStatement;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button bttnPrint;
    }
}