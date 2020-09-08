namespace LMS
{
    partial class ShortcutKeys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShortcutKeys));
            this.bttnCancel = new System.Windows.Forms.Button();
            this.txtKeys = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlLineHorizontal1 = new LMS.Controls.ctrlLineHorizontal();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttnCancel
            // 
            this.bttnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnCancel.ForeColor = System.Drawing.Color.Maroon;
            this.bttnCancel.Location = new System.Drawing.Point(179, 180);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(90, 28);
            this.bttnCancel.TabIndex = 43;
            this.bttnCancel.Text = "&Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // txtKeys
            // 
            this.txtKeys.BackColor = System.Drawing.Color.White;
            this.txtKeys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKeys.Location = new System.Drawing.Point(59, 12);
            this.txtKeys.Multiline = true;
            this.txtKeys.Name = "txtKeys";
            this.txtKeys.ReadOnly = true;
            this.txtKeys.Size = new System.Drawing.Size(223, 160);
            this.txtKeys.TabIndex = 42;
            this.txtKeys.Text = resources.GetString("txtKeys.Text");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 22);
            this.label1.TabIndex = 44;
            // 
            // ctrlLineHorizontal1
            // 
            this.ctrlLineHorizontal1.BackColor = System.Drawing.Color.Silver;
            this.ctrlLineHorizontal1.Location = new System.Drawing.Point(6, 173);
            this.ctrlLineHorizontal1.Name = "ctrlLineHorizontal1";
            this.ctrlLineHorizontal1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ctrlLineHorizontal1.Size = new System.Drawing.Size(272, 1);
            this.ctrlLineHorizontal1.TabIndex = 45;
            // 
            // ShortcutKeys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 215);
            this.Controls.Add(this.ctrlLineHorizontal1);
            this.Controls.Add(this.txtKeys);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ShortcutKeys";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShortcutKeys";
            this.Load += new System.EventHandler(this.ShortcutKeys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.TextBox txtKeys;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private LMS.Controls.ctrlLineHorizontal ctrlLineHorizontal1;
    }
}