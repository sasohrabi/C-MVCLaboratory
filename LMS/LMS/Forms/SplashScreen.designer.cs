namespace LMS
{
    partial class SplashScreen
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)){components.Dispose();}
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picSplash = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picSplash)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picSplash
            // 
            this.picSplash.BackColor = System.Drawing.Color.White;
            this.picSplash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSplash.Image = global::LMS.Properties.Resources.splash3;
            this.picSplash.Location = new System.Drawing.Point(0, 0);
            this.picSplash.Name = "picSplash";
            this.picSplash.Size = new System.Drawing.Size(481, 301);
            this.picSplash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSplash.TabIndex = 0;
            this.picSplash.TabStop = false;
            this.picSplash.Click += new System.EventHandler(this.picSplash_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(266, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 173);
            this.panel1.TabIndex = 1;
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(481, 301);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picSplash);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSplash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picSplash;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
    }
}