namespace LMS
{
    partial class ShortcutMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShortcutMenu));
            this.panelTOP = new System.Windows.Forms.Panel();
            this.lvShortcuts = new System.Windows.Forms.ListView();
            this.cmenustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsF1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsF2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsF3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsF4 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsF5 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsF6 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsF7 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsF8 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsF9 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsF10 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCtrlF1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCtrlF2 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCtrlF3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCtrlF4 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCtrlF5 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCtrlF6 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsCtrlF7 = new System.Windows.Forms.ToolStripMenuItem();
            this.i64x64 = new System.Windows.Forms.ImageList(this.components);
            this.cmsCtrlF8 = new System.Windows.Forms.ToolStripMenuItem();
            this.cmenustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTOP
            // 
            this.panelTOP.BackColor = System.Drawing.Color.White;
            this.panelTOP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTOP.Location = new System.Drawing.Point(0, 0);
            this.panelTOP.Name = "panelTOP";
            this.panelTOP.Size = new System.Drawing.Size(292, 15);
            this.panelTOP.TabIndex = 2;
            // 
            // lvShortcuts
            // 
            this.lvShortcuts.BackColor = System.Drawing.Color.White;
            this.lvShortcuts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvShortcuts.ContextMenuStrip = this.cmenustrip;
            this.lvShortcuts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvShortcuts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvShortcuts.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvShortcuts.ForeColor = System.Drawing.Color.Black;
            this.lvShortcuts.FullRowSelect = true;
            this.lvShortcuts.LargeImageList = this.i64x64;
            this.lvShortcuts.Location = new System.Drawing.Point(0, 15);
            this.lvShortcuts.Name = "lvShortcuts";
            this.lvShortcuts.RightToLeftLayout = true;
            this.lvShortcuts.Size = new System.Drawing.Size(292, 277);
            this.lvShortcuts.TabIndex = 3;
            this.lvShortcuts.TileSize = new System.Drawing.Size(10, 100);
            this.lvShortcuts.UseCompatibleStateImageBehavior = false;
            this.lvShortcuts.DoubleClick += new System.EventHandler(this.lvShortcuts_DoubleClick);
            this.lvShortcuts.SelectedIndexChanged += new System.EventHandler(this.lvShortcuts_SelectedIndexChanged);
            // 
            // cmenustrip
            // 
            this.cmenustrip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsF1,
            this.cmsF2,
            this.cmsF3,
            this.cmsF4,
            this.cmsF5,
            this.cmsF6,
            this.cmsF7,
            this.cmsF8,
            this.cmsF9,
            this.cmsF10,
            this.cmsCtrlF1,
            this.cmsCtrlF2,
            this.cmsCtrlF3,
            this.cmsCtrlF4,
            this.cmsCtrlF5,
            this.cmsCtrlF6,
            this.cmsCtrlF7,
            this.cmsCtrlF8});
            this.cmenustrip.Name = "cmenustrip";
            this.cmenustrip.Size = new System.Drawing.Size(153, 422);
            // 
            // cmsF1
            // 
            this.cmsF1.Name = "cmsF1";
            this.cmsF1.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.cmsF1.Size = new System.Drawing.Size(152, 22);
            this.cmsF1.Text = "F1";
            this.cmsF1.Visible = false;
            this.cmsF1.Click += new System.EventHandler(this.cmsF1_Click_1);
            // 
            // cmsF2
            // 
            this.cmsF2.Name = "cmsF2";
            this.cmsF2.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.cmsF2.Size = new System.Drawing.Size(152, 22);
            this.cmsF2.Text = "F2";
            this.cmsF2.Visible = false;
            this.cmsF2.Click += new System.EventHandler(this.cmsF2_Click);
            // 
            // cmsF3
            // 
            this.cmsF3.Name = "cmsF3";
            this.cmsF3.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.cmsF3.Size = new System.Drawing.Size(152, 22);
            this.cmsF3.Text = "F3";
            this.cmsF3.Visible = false;
            this.cmsF3.Click += new System.EventHandler(this.cmsF3_Click);
            // 
            // cmsF4
            // 
            this.cmsF4.Name = "cmsF4";
            this.cmsF4.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.cmsF4.Size = new System.Drawing.Size(152, 22);
            this.cmsF4.Text = "F4";
            this.cmsF4.Visible = false;
            this.cmsF4.Click += new System.EventHandler(this.cmsF4_Click);
            // 
            // cmsF5
            // 
            this.cmsF5.Name = "cmsF5";
            this.cmsF5.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.cmsF5.Size = new System.Drawing.Size(152, 22);
            this.cmsF5.Text = "F5";
            this.cmsF5.Visible = false;
            // 
            // cmsF6
            // 
            this.cmsF6.Name = "cmsF6";
            this.cmsF6.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.cmsF6.Size = new System.Drawing.Size(152, 22);
            this.cmsF6.Text = "F6";
            this.cmsF6.Visible = false;
            this.cmsF6.Click += new System.EventHandler(this.cmsF6_Click);
            // 
            // cmsF7
            // 
            this.cmsF7.Name = "cmsF7";
            this.cmsF7.ShortcutKeyDisplayString = "";
            this.cmsF7.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.cmsF7.Size = new System.Drawing.Size(152, 22);
            this.cmsF7.Text = "F7";
            this.cmsF7.Visible = false;
            this.cmsF7.Click += new System.EventHandler(this.cmsF7_Click);
            // 
            // cmsF8
            // 
            this.cmsF8.Name = "cmsF8";
            this.cmsF8.ShortcutKeyDisplayString = "";
            this.cmsF8.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.cmsF8.Size = new System.Drawing.Size(152, 22);
            this.cmsF8.Text = "F8";
            this.cmsF8.Visible = false;
            this.cmsF8.Click += new System.EventHandler(this.cmsF8_Click);
            // 
            // cmsF9
            // 
            this.cmsF9.Name = "cmsF9";
            this.cmsF9.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.cmsF9.Size = new System.Drawing.Size(152, 22);
            this.cmsF9.Text = "F9";
            this.cmsF9.Visible = false;
            this.cmsF9.Click += new System.EventHandler(this.cmsF9_Click);
            // 
            // cmsF10
            // 
            this.cmsF10.Name = "cmsF10";
            this.cmsF10.ShortcutKeys = System.Windows.Forms.Keys.F10;
            this.cmsF10.Size = new System.Drawing.Size(152, 22);
            this.cmsF10.Text = "F10";
            this.cmsF10.Visible = false;
            this.cmsF10.Click += new System.EventHandler(this.cmsF10_Click);
            // 
            // cmsCtrlF1
            // 
            this.cmsCtrlF1.Name = "cmsCtrlF1";
            this.cmsCtrlF1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.cmsCtrlF1.Size = new System.Drawing.Size(152, 22);
            this.cmsCtrlF1.Text = "CtrlF1";
            this.cmsCtrlF1.Visible = false;
            this.cmsCtrlF1.Click += new System.EventHandler(this.cmsCtrlF1_Click);
            // 
            // cmsCtrlF2
            // 
            this.cmsCtrlF2.Name = "cmsCtrlF2";
            this.cmsCtrlF2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
            this.cmsCtrlF2.Size = new System.Drawing.Size(152, 22);
            this.cmsCtrlF2.Text = "CtrlF2";
            this.cmsCtrlF2.Visible = false;
            this.cmsCtrlF2.Click += new System.EventHandler(this.cmsCtrlF2_Click);
            // 
            // cmsCtrlF3
            // 
            this.cmsCtrlF3.Name = "cmsCtrlF3";
            this.cmsCtrlF3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F3)));
            this.cmsCtrlF3.Size = new System.Drawing.Size(152, 22);
            this.cmsCtrlF3.Text = "CtrlF3";
            this.cmsCtrlF3.Visible = false;
            this.cmsCtrlF3.Click += new System.EventHandler(this.cmsCtrlF3_Click);
            // 
            // cmsCtrlF4
            // 
            this.cmsCtrlF4.Name = "cmsCtrlF4";
            this.cmsCtrlF4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.cmsCtrlF4.Size = new System.Drawing.Size(152, 22);
            this.cmsCtrlF4.Text = "CtrlF4";
            this.cmsCtrlF4.Visible = false;
            this.cmsCtrlF4.Click += new System.EventHandler(this.cmsCtrlF4_Click);
            // 
            // cmsCtrlF5
            // 
            this.cmsCtrlF5.Name = "cmsCtrlF5";
            this.cmsCtrlF5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F5)));
            this.cmsCtrlF5.Size = new System.Drawing.Size(152, 22);
            this.cmsCtrlF5.Text = "CtrlF5";
            this.cmsCtrlF5.Visible = false;
            this.cmsCtrlF5.Click += new System.EventHandler(this.cmsCtrlF5_Click);
            // 
            // cmsCtrlF6
            // 
            this.cmsCtrlF6.Name = "cmsCtrlF6";
            this.cmsCtrlF6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F6)));
            this.cmsCtrlF6.Size = new System.Drawing.Size(152, 22);
            this.cmsCtrlF6.Text = "CtrlF6";
            this.cmsCtrlF6.Visible = false;
            this.cmsCtrlF6.Click += new System.EventHandler(this.cmsCtrlF6_Click);
            // 
            // cmsCtrlF7
            // 
            this.cmsCtrlF7.Name = "cmsCtrlF7";
            this.cmsCtrlF7.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F7)));
            this.cmsCtrlF7.Size = new System.Drawing.Size(152, 22);
            this.cmsCtrlF7.Text = "CtrlF7";
            this.cmsCtrlF7.Visible = false;
            this.cmsCtrlF7.Click += new System.EventHandler(this.cmsCtrlF7_Click);
            // 
            // i64x64
            // 
            this.i64x64.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("i64x64.ImageStream")));
            this.i64x64.TransparentColor = System.Drawing.Color.Transparent;
            this.i64x64.Images.SetKeyName(0, "");
            this.i64x64.Images.SetKeyName(1, "");
            this.i64x64.Images.SetKeyName(2, "");
            this.i64x64.Images.SetKeyName(3, "");
            this.i64x64.Images.SetKeyName(4, "");
            this.i64x64.Images.SetKeyName(5, "CALCULATOR.png");
            this.i64x64.Images.SetKeyName(6, "MSPAINT.png");
            this.i64x64.Images.SetKeyName(7, "NOTEPAD.png");
            this.i64x64.Images.SetKeyName(8, "WORDPAD.png");
            this.i64x64.Images.SetKeyName(9, "CALENDAR.png");
            this.i64x64.Images.SetKeyName(10, "ADD-NEW.png");
            this.i64x64.Images.SetKeyName(11, "leaves.png");
            this.i64x64.Images.SetKeyName(12, "TAXES.png");
            this.i64x64.Images.SetKeyName(13, "accruals.png");
            this.i64x64.Images.SetKeyName(14, "deducts.png");
            this.i64x64.Images.SetKeyName(15, "PERIODS.png");
            this.i64x64.Images.SetKeyName(16, "User List.png");
            this.i64x64.Images.SetKeyName(17, "Contact 2.png");
            this.i64x64.Images.SetKeyName(18, "Group 5.png");
            this.i64x64.Images.SetKeyName(19, "Group List.png");
            this.i64x64.Images.SetKeyName(20, "Help File.png");
            this.i64x64.Images.SetKeyName(21, "Help.png");
            this.i64x64.Images.SetKeyName(22, "Report Add.png");
            this.i64x64.Images.SetKeyName(23, "Report Edit.png");
            this.i64x64.Images.SetKeyName(24, "Report.png");
            this.i64x64.Images.SetKeyName(25, "Security 2.png");
            this.i64x64.Images.SetKeyName(26, "Security Add.png");
            this.i64x64.Images.SetKeyName(27, "Tech.png");
            this.i64x64.Images.SetKeyName(28, "Tutorial 2.png");
            this.i64x64.Images.SetKeyName(29, "Tutorial.png");
            this.i64x64.Images.SetKeyName(30, "User 2 Security.png");
            this.i64x64.Images.SetKeyName(31, "User 3 Security.png");
            this.i64x64.Images.SetKeyName(32, "User 3.png");
            this.i64x64.Images.SetKeyName(33, "User 7 Security.png");
            this.i64x64.Images.SetKeyName(34, "User 7.png");
            this.i64x64.Images.SetKeyName(35, "User 8.png");
            this.i64x64.Images.SetKeyName(36, "User 9.png");
            this.i64x64.Images.SetKeyName(37, "Calender Time.png");
            this.i64x64.Images.SetKeyName(38, "Calender.png");
            this.i64x64.Images.SetKeyName(39, "Calendar.png");
            // 
            // cmsCtrlF8
            // 
            this.cmsCtrlF8.Name = "cmsCtrlF8";
            this.cmsCtrlF8.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F8)));
            this.cmsCtrlF8.Size = new System.Drawing.Size(152, 22);
            this.cmsCtrlF8.Text = "CtrlF8";
            this.cmsCtrlF8.Click += new System.EventHandler(this.cmsCtrlF8_Click);
            // 
            // ShortcutMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(292, 292);
            this.ControlBox = false;
            this.Controls.Add(this.lvShortcuts);
            this.Controls.Add(this.panelTOP);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ShortcutMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.frmShortcuts_Resize);
            this.Load += new System.EventHandler(this.frmShortcuts_Load);
            this.cmenustrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTOP;
        private System.Windows.Forms.ListView lvShortcuts;
        public System.Windows.Forms.ImageList i64x64;
        private System.Windows.Forms.ContextMenuStrip cmenustrip;
        private System.Windows.Forms.ToolStripMenuItem cmsF1;
        private System.Windows.Forms.ToolStripMenuItem cmsF2;
        private System.Windows.Forms.ToolStripMenuItem cmsF3;
        private System.Windows.Forms.ToolStripMenuItem cmsF4;
        private System.Windows.Forms.ToolStripMenuItem cmsF5;
        private System.Windows.Forms.ToolStripMenuItem cmsF6;
        private System.Windows.Forms.ToolStripMenuItem cmsF7;
        private System.Windows.Forms.ToolStripMenuItem cmsF8;
        private System.Windows.Forms.ToolStripMenuItem cmsF9;
        private System.Windows.Forms.ToolStripMenuItem cmsF10;
        private System.Windows.Forms.ToolStripMenuItem cmsCtrlF1;
        private System.Windows.Forms.ToolStripMenuItem cmsCtrlF2;
        private System.Windows.Forms.ToolStripMenuItem cmsCtrlF3;
        private System.Windows.Forms.ToolStripMenuItem cmsCtrlF4;
        private System.Windows.Forms.ToolStripMenuItem cmsCtrlF5;
        private System.Windows.Forms.ToolStripMenuItem cmsCtrlF6;
        private System.Windows.Forms.ToolStripMenuItem cmsCtrlF7;
        private System.Windows.Forms.ToolStripMenuItem cmsCtrlF8;

    }
}