namespace LMS.Forms
{
    partial class frmReception
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReception));
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumberReceipt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bttnUpdate = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.txtStatement = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lvPostalCodes = new System.Windows.Forms.ListView();
            this.chNumberReceipt = new System.Windows.Forms.ColumnHeader();
            this.chCodeDoctor = new System.Windows.Forms.ColumnHeader();
            this.chCodePatient = new System.Windows.Forms.ColumnHeader();
            this.chCodeInsurance = new System.Windows.Forms.ColumnHeader();
            this.chCodeTest = new System.Windows.Forms.ColumnHeader();
            this.chPercent_Payment = new System.Windows.Forms.ColumnHeader();
            this.chDateReception = new System.Windows.Forms.ColumnHeader();
            this.chStatement = new System.Windows.Forms.ColumnHeader();
            this.cboCodeDoctor = new System.Windows.Forms.ComboBox();
            this.cboCodePatient = new System.Windows.Forms.ComboBox();
            this.cboCodeInsurance = new System.Windows.Forms.ComboBox();
            this.txtPercent_Payment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCodeTest = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtCompletPayment = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.mskDateReception = new System.Windows.Forms.MaskedTextBox();
            this.lblSelected = new System.Windows.Forms.Label();
            this.bttnLast = new System.Windows.Forms.Button();
            this.panelBOTTOM = new System.Windows.Forms.Panel();
            this.panelBOTTOM_RIGHT = new System.Windows.Forms.Panel();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.panelBOTTOM_RIGHT_RIGHT = new System.Windows.Forms.Panel();
            this.bttnNext = new System.Windows.Forms.Button();
            this.bttnPrevious = new System.Windows.Forms.Button();
            this.bttnFirst = new System.Windows.Forms.Button();
            this.ctrlLineHorizontal1 = new LMS.Controls.ctrlLineHorizontal();
            this.label15 = new System.Windows.Forms.Label();
            this.bttnPrint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBOTTOM.SuspendLayout();
            this.panelBOTTOM_RIGHT.SuspendLayout();
            this.panelBOTTOM_RIGHT_RIGHT.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 15);
            this.label4.TabIndex = 264;
            this.label4.Text = "Experiment Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(624, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 263;
            this.label7.Text = "Insurance Code:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 15);
            this.label2.TabIndex = 260;
            this.label2.Text = "Patient Code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 259;
            this.label1.Text = "Doctor Code:";
            // 
            // txtNumberReceipt
            // 
            this.txtNumberReceipt.BackColor = System.Drawing.Color.LemonChiffon;
            this.txtNumberReceipt.Location = new System.Drawing.Point(126, 45);
            this.txtNumberReceipt.MaxLength = 20;
            this.txtNumberReceipt.Name = "txtNumberReceipt";
            this.txtNumberReceipt.Size = new System.Drawing.Size(84, 21);
            this.txtNumberReceipt.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 15);
            this.label8.TabIndex = 258;
            this.label8.Text = "Admission Number:";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(665, 483);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 15);
            this.label13.TabIndex = 255;
            this.label13.Text = "&Update";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(759, 483);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 15);
            this.label11.TabIndex = 254;
            this.label11.Text = "&Cancel";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnUpdate
            // 
            this.bttnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnUpdate.Location = new System.Drawing.Point(668, 440);
            this.bttnUpdate.Name = "bttnUpdate";
            this.bttnUpdate.Size = new System.Drawing.Size(40, 40);
            this.bttnUpdate.TabIndex = 7;
            this.bttnUpdate.UseVisualStyleBackColor = true;
            this.bttnUpdate.Click += new System.EventHandler(this.bttnUpdate_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.Location = new System.Drawing.Point(760, 440);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(40, 40);
            this.bttnCancel.TabIndex = 252;
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // picHeader
            // 
            this.picHeader.Image = ((System.Drawing.Image)(resources.GetObject("picHeader.Image")));
            this.picHeader.Location = new System.Drawing.Point(326, -1);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(504, 36);
            this.picHeader.TabIndex = 253;
            this.picHeader.TabStop = false;
            // 
            // txtStatement
            // 
            this.txtStatement.BackColor = System.Drawing.Color.White;
            this.txtStatement.Location = new System.Drawing.Point(747, 86);
            this.txtStatement.MaxLength = 20;
            this.txtStatement.Name = "txtStatement";
            this.txtStatement.Size = new System.Drawing.Size(83, 21);
            this.txtStatement.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(665, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 15);
            this.label9.TabIndex = 269;
            this.label9.Text = "Description:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(489, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 15);
            this.label10.TabIndex = 266;
            this.label10.Text = "Admission Date";
            // 
            // lvPostalCodes
            // 
            this.lvPostalCodes.BackColor = System.Drawing.Color.White;
            this.lvPostalCodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chNumberReceipt,
            this.chCodeDoctor,
            this.chCodePatient,
            this.chCodeInsurance,
            this.chCodeTest,
            this.chPercent_Payment,
            this.chDateReception,
            this.chStatement});
            this.lvPostalCodes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPostalCodes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPostalCodes.ForeColor = System.Drawing.Color.Black;
            this.lvPostalCodes.FullRowSelect = true;
            this.lvPostalCodes.GridLines = true;
            this.lvPostalCodes.Location = new System.Drawing.Point(17, 132);
            this.lvPostalCodes.Name = "lvPostalCodes";
            this.lvPostalCodes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvPostalCodes.RightToLeftLayout = true;
            this.lvPostalCodes.Size = new System.Drawing.Size(813, 302);
            this.lvPostalCodes.TabIndex = 270;
            this.lvPostalCodes.UseCompatibleStateImageBehavior = false;
            this.lvPostalCodes.View = System.Windows.Forms.View.Details;
            this.lvPostalCodes.SelectedIndexChanged += new System.EventHandler(this.lvPostalCodes_SelectedIndexChanged);
            this.lvPostalCodes.Leave += new System.EventHandler(this.lvPostalCodes_Leave);
            this.lvPostalCodes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvPostalCodes_ColumnClick);
            this.lvPostalCodes.Click += new System.EventHandler(this.lvPostalCodes_Click);
            // 
            // chNumberReceipt
            // 
            this.chNumberReceipt.Text = "Admission Number";
            this.chNumberReceipt.Width = 100;
            // 
            // chCodeDoctor
            // 
            this.chCodeDoctor.Text = "Doctor Code";
            this.chCodeDoctor.Width = 100;
            // 
            // chCodePatient
            // 
            this.chCodePatient.Text = "Patient Code";
            this.chCodePatient.Width = 100;
            // 
            // chCodeInsurance
            // 
            this.chCodeInsurance.Text = "Insurance Code";
            this.chCodeInsurance.Width = 100;
            // 
            // chCodeTest
            // 
            this.chCodeTest.Text = "Experiment Code";
            this.chCodeTest.Width = 100;
            // 
            // chPercent_Payment
            // 
            this.chPercent_Payment.DisplayIndex = 6;
            this.chPercent_Payment.Text = "Cost";
            this.chPercent_Payment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chPercent_Payment.Width = 150;
            // 
            // chDateReception
            // 
            this.chDateReception.DisplayIndex = 7;
            this.chDateReception.Text = "Admission Date";
            this.chDateReception.Width = 100;
            // 
            // chStatement
            // 
            this.chStatement.DisplayIndex = 5;
            this.chStatement.Text = "Description";
            this.chStatement.Width = 100;
            // 
            // cboCodeDoctor
            // 
            this.cboCodeDoctor.BackColor = System.Drawing.Color.White;
            this.cboCodeDoctor.FormattingEnabled = true;
            this.cboCodeDoctor.Location = new System.Drawing.Point(319, 45);
            this.cboCodeDoctor.Name = "cboCodeDoctor";
            this.cboCodeDoctor.Size = new System.Drawing.Size(97, 23);
            this.cboCodeDoctor.TabIndex = 1;
            // 
            // cboCodePatient
            // 
            this.cboCodePatient.BackColor = System.Drawing.Color.White;
            this.cboCodePatient.FormattingEnabled = true;
            this.cboCodePatient.Location = new System.Drawing.Point(511, 45);
            this.cboCodePatient.Name = "cboCodePatient";
            this.cboCodePatient.Size = new System.Drawing.Size(85, 23);
            this.cboCodePatient.TabIndex = 2;
            // 
            // cboCodeInsurance
            // 
            this.cboCodeInsurance.BackColor = System.Drawing.Color.White;
            this.cboCodeInsurance.FormattingEnabled = true;
            this.cboCodeInsurance.Location = new System.Drawing.Point(723, 43);
            this.cboCodeInsurance.Name = "cboCodeInsurance";
            this.cboCodeInsurance.Size = new System.Drawing.Size(107, 23);
            this.cboCodeInsurance.TabIndex = 3;
            this.cboCodeInsurance.SelectedIndexChanged += new System.EventHandler(this.cboCodeInsurance_SelectedIndexChanged);
            // 
            // txtPercent_Payment
            // 
            this.txtPercent_Payment.BackColor = System.Drawing.Color.White;
            this.txtPercent_Payment.Location = new System.Drawing.Point(410, 86);
            this.txtPercent_Payment.MaxLength = 50;
            this.txtPercent_Payment.Name = "txtPercent_Payment";
            this.txtPercent_Payment.ReadOnly = true;
            this.txtPercent_Payment.Size = new System.Drawing.Size(73, 21);
            this.txtPercent_Payment.TabIndex = 274;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 275;
            this.label3.Text = "Cost:";
            // 
            // cboCodeTest
            // 
            this.cboCodeTest.BackColor = System.Drawing.Color.White;
            this.cboCodeTest.FormattingEnabled = true;
            this.cboCodeTest.Location = new System.Drawing.Point(121, 86);
            this.cboCodeTest.Name = "cboCodeTest";
            this.cboCodeTest.Size = new System.Drawing.Size(100, 23);
            this.cboCodeTest.TabIndex = 4;
            this.cboCodeTest.SelectedIndexChanged += new System.EventHandler(this.cboCodeTest_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(504, 36);
            this.pictureBox1.TabIndex = 277;
            this.pictureBox1.TabStop = false;
            // 
            // txtCompletPayment
            // 
            this.txtCompletPayment.BackColor = System.Drawing.Color.White;
            this.txtCompletPayment.Location = new System.Drawing.Point(269, 86);
            this.txtCompletPayment.MaxLength = 50;
            this.txtCompletPayment.Name = "txtCompletPayment";
            this.txtCompletPayment.ReadOnly = true;
            this.txtCompletPayment.Size = new System.Drawing.Size(73, 21);
            this.txtCompletPayment.TabIndex = 278;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(292, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 15);
            this.label12.TabIndex = 279;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(348, 89);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 15);
            this.label14.TabIndex = 280;
            this.label14.Text = "Discount";
            // 
            // mskDateReception
            // 
            this.mskDateReception.BackColor = System.Drawing.Color.White;
            this.mskDateReception.Location = new System.Drawing.Point(590, 86);
            this.mskDateReception.Mask = "13##/##/##";
            this.mskDateReception.Name = "mskDateReception";
            this.mskDateReception.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mskDateReception.Size = new System.Drawing.Size(69, 21);
            this.mskDateReception.TabIndex = 5;
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
            // panelBOTTOM
            // 
            this.panelBOTTOM.BackColor = System.Drawing.Color.White;
            this.panelBOTTOM.Controls.Add(this.panelBOTTOM_RIGHT);
            this.panelBOTTOM.Controls.Add(this.lblSelected);
            this.panelBOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBOTTOM.Location = new System.Drawing.Point(0, 504);
            this.panelBOTTOM.Name = "panelBOTTOM";
            this.panelBOTTOM.Size = new System.Drawing.Size(840, 34);
            this.panelBOTTOM.TabIndex = 281;
            // 
            // panelBOTTOM_RIGHT
            // 
            this.panelBOTTOM_RIGHT.BackColor = System.Drawing.Color.Transparent;
            this.panelBOTTOM_RIGHT.Controls.Add(this.lblRecordCount);
            this.panelBOTTOM_RIGHT.Controls.Add(this.panelBOTTOM_RIGHT_RIGHT);
            this.panelBOTTOM_RIGHT.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBOTTOM_RIGHT.Location = new System.Drawing.Point(383, 0);
            this.panelBOTTOM_RIGHT.Name = "panelBOTTOM_RIGHT";
            this.panelBOTTOM_RIGHT.Size = new System.Drawing.Size(457, 34);
            this.panelBOTTOM_RIGHT.TabIndex = 3;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Location = new System.Drawing.Point(3, 10);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(323, 15);
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
            this.panelBOTTOM_RIGHT_RIGHT.Location = new System.Drawing.Point(328, 0);
            this.panelBOTTOM_RIGHT_RIGHT.Name = "panelBOTTOM_RIGHT_RIGHT";
            this.panelBOTTOM_RIGHT_RIGHT.Size = new System.Drawing.Size(129, 34);
            this.panelBOTTOM_RIGHT_RIGHT.TabIndex = 7;
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
            // ctrlLineHorizontal1
            // 
            this.ctrlLineHorizontal1.BackColor = System.Drawing.Color.Silver;
            this.ctrlLineHorizontal1.Location = new System.Drawing.Point(7, 500);
            this.ctrlLineHorizontal1.Name = "ctrlLineHorizontal1";
            this.ctrlLineHorizontal1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrlLineHorizontal1.Size = new System.Drawing.Size(798, 1);
            this.ctrlLineHorizontal1.TabIndex = 282;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(711, 483);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 15);
            this.label15.TabIndex = 284;
            this.label15.Text = "&Print";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnPrint
            // 
            this.bttnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnPrint.Location = new System.Drawing.Point(714, 440);
            this.bttnPrint.Name = "bttnPrint";
            this.bttnPrint.Size = new System.Drawing.Size(40, 40);
            this.bttnPrint.TabIndex = 283;
            this.bttnPrint.UseVisualStyleBackColor = true;
            this.bttnPrint.Click += new System.EventHandler(this.bttnPrint_Click);
            // 
            // frmReception
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(840, 538);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.bttnPrint);
            this.Controls.Add(this.ctrlLineHorizontal1);
            this.Controls.Add(this.panelBOTTOM);
            this.Controls.Add(this.mskDateReception);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtCompletPayment);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cboCodeTest);
            this.Controls.Add(this.txtPercent_Payment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboCodeInsurance);
            this.Controls.Add(this.cboCodePatient);
            this.Controls.Add(this.cboCodeDoctor);
            this.Controls.Add(this.lvPostalCodes);
            this.Controls.Add(this.txtStatement);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumberReceipt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bttnUpdate);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.picHeader);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "frmReception";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmReception_Load);
            this.Activated += new System.EventHandler(this.frmReception_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBOTTOM.ResumeLayout(false);
            this.panelBOTTOM.PerformLayout();
            this.panelBOTTOM_RIGHT.ResumeLayout(false);
            this.panelBOTTOM_RIGHT_RIGHT.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodeDoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumberReceipt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bttnUpdate;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.TextBox txtStatement;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lvPostalCodes;
        private System.Windows.Forms.ColumnHeader chNumberReceipt;
        private System.Windows.Forms.ColumnHeader chCodeDoctor;
        private System.Windows.Forms.ColumnHeader chCodePatient;
        private System.Windows.Forms.ColumnHeader chCodeInsurance;
        private System.Windows.Forms.ColumnHeader chCodeTest;
        private System.Windows.Forms.ColumnHeader chDateReception;
        private System.Windows.Forms.ColumnHeader chStatement;
        private System.Windows.Forms.ComboBox cboCodeDoctor;
        private System.Windows.Forms.ComboBox cboCodePatient;
        private System.Windows.Forms.ComboBox cboCodeInsurance;
        private System.Windows.Forms.TextBox txtPercent_Payment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCodeTest;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtCompletPayment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ColumnHeader chPercent_Payment;
        private System.Windows.Forms.MaskedTextBox mskDateReception;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Button bttnLast;
        private System.Windows.Forms.Panel panelBOTTOM;
        private System.Windows.Forms.Panel panelBOTTOM_RIGHT;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Panel panelBOTTOM_RIGHT_RIGHT;
        private System.Windows.Forms.Button bttnNext;
        private System.Windows.Forms.Button bttnPrevious;
        private System.Windows.Forms.Button bttnFirst;
        private LMS.Controls.ctrlLineHorizontal ctrlLineHorizontal1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button bttnPrint;
    }
}