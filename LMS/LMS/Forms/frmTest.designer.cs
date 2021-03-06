namespace LMS
{
    partial class frmTest
    {
        private System.ComponentModel.IContainer components = null;

        private static frmTest sForm = null;
        public static frmTest Instance()
        {
            if (sForm == null) { sForm = new frmTest(); }
            return sForm;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) { components.Dispose(); }
            base.Dispose(disposing);
            sForm = null;
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTest));
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmenustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsItemModify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsItemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsItemReload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.panelBOTTOM = new System.Windows.Forms.Panel();
            this.panelBOTTOM_RIGHT = new System.Windows.Forms.Panel();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.panelBOTTOM_RIGHT_RIGHT = new System.Windows.Forms.Panel();
            this.bttnLast = new System.Windows.Forms.Button();
            this.bttnNext = new System.Windows.Forms.Button();
            this.bttnPrevious = new System.Windows.Forms.Button();
            this.bttnFirst = new System.Windows.Forms.Button();
            this.lblSelected = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbModify = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbSearch = new System.Windows.Forms.ToolStripButton();
            this.tsbReload = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPreview = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsbCrystalReport = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCrystal_Selected = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbCrystal_All = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.lvPostalCodes = new System.Windows.Forms.ListView();
            this.chCodeTest = new System.Windows.Forms.ColumnHeader();
            this.chName = new System.Windows.Forms.ColumnHeader();
            this.chSymbol = new System.Windows.Forms.ColumnHeader();
            this.chPayment = new System.Windows.Forms.ColumnHeader();
            this.chNumberLevel = new System.Windows.Forms.ColumnHeader();
            this.cmenustrip.SuspendLayout();
            this.panelBOTTOM.SuspendLayout();
            this.panelBOTTOM_RIGHT.SuspendLayout();
            this.panelBOTTOM_RIGHT_RIGHT.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // cmenustrip
            // 
            this.cmenustrip.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmenustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmsItemNew,
            this.toolStripSeparator8,
            this.cmsItemModify,
            this.toolStripSeparator9,
            this.cmsItemDelete,
            this.toolStripSeparator10,
            this.cmsItemSearch,
            this.toolStripSeparator11,
            this.cmsItemReload,
            this.toolStripSeparator12,
            this.cmsItemClose});
            this.cmenustrip.Name = "cmenustrip";
            this.cmenustrip.Size = new System.Drawing.Size(137, 166);
            // 
            // cmsItemNew
            // 
            this.cmsItemNew.Name = "cmsItemNew";
            this.cmsItemNew.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.cmsItemNew.Size = new System.Drawing.Size(136, 22);
            this.cmsItemNew.Text = "&Add New";
            this.cmsItemNew.Click += new System.EventHandler(this.cmsItemNew_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(133, 6);
            // 
            // cmsItemModify
            // 
            this.cmsItemModify.Name = "cmsItemModify";
            this.cmsItemModify.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.cmsItemModify.Size = new System.Drawing.Size(136, 22);
            this.cmsItemModify.Text = "&Modify";
            this.cmsItemModify.Click += new System.EventHandler(this.cmsItemModify_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(133, 6);
            // 
            // cmsItemDelete
            // 
            this.cmsItemDelete.Name = "cmsItemDelete";
            this.cmsItemDelete.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.cmsItemDelete.Size = new System.Drawing.Size(136, 22);
            this.cmsItemDelete.Text = "&Delete";
            this.cmsItemDelete.Click += new System.EventHandler(this.cmsItemDelete_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(133, 6);
            // 
            // cmsItemSearch
            // 
            this.cmsItemSearch.Name = "cmsItemSearch";
            this.cmsItemSearch.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.cmsItemSearch.Size = new System.Drawing.Size(136, 22);
            this.cmsItemSearch.Text = "&Search";
            this.cmsItemSearch.Click += new System.EventHandler(this.cmsItemSearch_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(133, 6);
            // 
            // cmsItemReload
            // 
            this.cmsItemReload.Name = "cmsItemReload";
            this.cmsItemReload.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.cmsItemReload.Size = new System.Drawing.Size(136, 22);
            this.cmsItemReload.Text = "&Reload";
            this.cmsItemReload.Click += new System.EventHandler(this.cmsItemReload_Click);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(133, 6);
            // 
            // cmsItemClose
            // 
            this.cmsItemClose.Name = "cmsItemClose";
            this.cmsItemClose.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.cmsItemClose.Size = new System.Drawing.Size(136, 22);
            this.cmsItemClose.Text = "&Close";
            this.cmsItemClose.Click += new System.EventHandler(this.cmsItemClose_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 39);
            // 
            // panelBOTTOM
            // 
            this.panelBOTTOM.BackColor = System.Drawing.Color.White;
            this.panelBOTTOM.Controls.Add(this.panelBOTTOM_RIGHT);
            this.panelBOTTOM.Controls.Add(this.lblSelected);
            this.panelBOTTOM.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBOTTOM.Location = new System.Drawing.Point(0, 424);
            this.panelBOTTOM.Name = "panelBOTTOM";
            this.panelBOTTOM.Size = new System.Drawing.Size(507, 34);
            this.panelBOTTOM.TabIndex = 21;
            // 
            // panelBOTTOM_RIGHT
            // 
            this.panelBOTTOM_RIGHT.BackColor = System.Drawing.Color.Transparent;
            this.panelBOTTOM_RIGHT.Controls.Add(this.lblRecordCount);
            this.panelBOTTOM_RIGHT.Controls.Add(this.panelBOTTOM_RIGHT_RIGHT);
            this.panelBOTTOM_RIGHT.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBOTTOM_RIGHT.Location = new System.Drawing.Point(50, 0);
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
            this.lblRecordCount.Click += new System.EventHandler(this.lblRecordCount_Click);
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
            // toolStrip
            // 
            this.toolStrip.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.toolStripSeparator1,
            this.tsbModify,
            this.toolStripSeparator2,
            this.tsbDelete,
            this.toolStripSeparator3,
            this.tsbSearch,
            this.toolStripSeparator4,
            this.tsbReload,
            this.toolStripSeparator6,
            this.toolStripSeparator5,
            this.tsbPreview,
            this.tsbClose,
            this.toolStripSeparator7});
            this.toolStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(507, 39);
            this.toolStrip.TabIndex = 22;
            this.toolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip_ItemClicked);
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(23, 36);
            this.tsbNew.ToolTipText = "ADD NEW";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbModify
            // 
            this.tsbModify.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbModify.Image = ((System.Drawing.Image)(resources.GetObject("tsbModify.Image")));
            this.tsbModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbModify.Name = "tsbModify";
            this.tsbModify.Size = new System.Drawing.Size(36, 36);
            this.tsbModify.ToolTipText = "MODIFY";
            this.tsbModify.Click += new System.EventHandler(this.tsbModify_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(36, 36);
            this.tsbDelete.ToolTipText = "DELETE";
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsbSearch
            // 
            this.tsbSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSearch.Image = ((System.Drawing.Image)(resources.GetObject("tsbSearch.Image")));
            this.tsbSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSearch.Name = "tsbSearch";
            this.tsbSearch.Size = new System.Drawing.Size(36, 36);
            this.tsbSearch.ToolTipText = "SEARCH";
            this.tsbSearch.Click += new System.EventHandler(this.tsbSearch_Click);
            // 
            // tsbReload
            // 
            this.tsbReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbReload.Image = ((System.Drawing.Image)(resources.GetObject("tsbReload.Image")));
            this.tsbReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbReload.Name = "tsbReload";
            this.tsbReload.Size = new System.Drawing.Size(36, 36);
            this.tsbReload.ToolTipText = "RELOAD";
            this.tsbReload.Click += new System.EventHandler(this.tsbReload_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 39);
            // 
            // tsbPreview
            // 
            this.tsbPreview.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPreview.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCrystalReport});
            this.tsbPreview.Image = ((System.Drawing.Image)(resources.GetObject("tsbPreview.Image")));
            this.tsbPreview.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPreview.Name = "tsbPreview";
            this.tsbPreview.Size = new System.Drawing.Size(45, 36);
            this.tsbPreview.Text = "toolStripDropDownButton1";
            // 
            // tsbCrystalReport
            // 
            this.tsbCrystalReport.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbCrystal_Selected,
            this.tsbCrystal_All});
            this.tsbCrystalReport.Name = "tsbCrystalReport";
            this.tsbCrystalReport.Size = new System.Drawing.Size(152, 22);
            this.tsbCrystalReport.Text = "&Crystal Report";
            // 
            // tsbCrystal_Selected
            // 
            this.tsbCrystal_Selected.Name = "tsbCrystal_Selected";
            this.tsbCrystal_Selected.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.tsbCrystal_Selected.Size = new System.Drawing.Size(171, 22);
            this.tsbCrystal_Selected.Text = "&Print Selected";
            this.tsbCrystal_Selected.Click += new System.EventHandler(this.tsbCrystal_Selected_Click);
            // 
            // tsbCrystal_All
            // 
            this.tsbCrystal_All.Name = "tsbCrystal_All";
            this.tsbCrystal_All.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.tsbCrystal_All.Size = new System.Drawing.Size(171, 22);
            this.tsbCrystal_All.Text = "&Print All";
            this.tsbCrystal_All.Click += new System.EventHandler(this.tsbCrystal_All_Click);
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(36, 36);
            this.tsbClose.ToolTipText = "CLOSE";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // lvPostalCodes
            // 
            this.lvPostalCodes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvPostalCodes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chCodeTest,
            this.chName,
            this.chSymbol,
            this.chPayment,
            this.chNumberLevel});
            this.lvPostalCodes.ContextMenuStrip = this.cmenustrip;
            this.lvPostalCodes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lvPostalCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPostalCodes.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvPostalCodes.ForeColor = System.Drawing.Color.Black;
            this.lvPostalCodes.FullRowSelect = true;
            this.lvPostalCodes.GridLines = true;
            this.lvPostalCodes.Location = new System.Drawing.Point(0, 39);
            this.lvPostalCodes.Name = "lvPostalCodes";
            this.lvPostalCodes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lvPostalCodes.RightToLeftLayout = true;
            this.lvPostalCodes.Size = new System.Drawing.Size(507, 385);
            this.lvPostalCodes.TabIndex = 1;
            this.lvPostalCodes.UseCompatibleStateImageBehavior = false;
            this.lvPostalCodes.View = System.Windows.Forms.View.Details;
            this.lvPostalCodes.SelectedIndexChanged += new System.EventHandler(this.lvPostalCodes_SelectedIndexChanged);
            this.lvPostalCodes.DoubleClick += new System.EventHandler(this.lvPostalCodes_DoubleClick);
            this.lvPostalCodes.Leave += new System.EventHandler(this.lvPostalCodes_Leave);
            this.lvPostalCodes.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvPostalCodes_ColumnClick);
            this.lvPostalCodes.Click += new System.EventHandler(this.lvPostalCodes_Click);
            // 
            // chCodeTest
            // 
            this.chCodeTest.Text = "Test Code";
            this.chCodeTest.Width = 200;
            // 
            // chName
            // 
            this.chName.Text = "Test Name";
            this.chName.Width = 250;
            // 
            // chSymbol
            // 
            this.chSymbol.Text = "Test Symbol";
            this.chSymbol.Width = 250;
            // 
            // chPayment
            // 
            this.chPayment.Text = "Test Cost";
            this.chPayment.Width = 200;
            // 
            // chNumberLevel
            // 
            this.chNumberLevel.Text = "Number Of Test";
            this.chNumberLevel.Width = 200;
            // 
            // frmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(507, 458);
            this.ControlBox = false;
            this.Controls.Add(this.lvPostalCodes);
            this.Controls.Add(this.panelBOTTOM);
            this.Controls.Add(this.toolStrip);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTest";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPostalCodes_Load);
            this.Resize += new System.EventHandler(this.frmPostalCodes_Resize);
            this.cmenustrip.ResumeLayout(false);
            this.panelBOTTOM.ResumeLayout(false);
            this.panelBOTTOM.PerformLayout();
            this.panelBOTTOM_RIGHT.ResumeLayout(false);
            this.panelBOTTOM_RIGHT_RIGHT.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton tsbReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbSearch;
        private System.Windows.Forms.ToolStripButton tsbModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ColumnHeader chCodeTest;
        private System.Windows.Forms.ListView lvPostalCodes;
        private System.Windows.Forms.ColumnHeader chSymbol;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chPayment;
        private System.Windows.Forms.ContextMenuStrip cmenustrip;
        private System.Windows.Forms.ToolStripMenuItem cmsItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem cmsItemModify;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem cmsItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem cmsItemSearch;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem cmsItemReload;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator12;
        private System.Windows.Forms.ToolStripMenuItem cmsItemClose;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.Panel panelBOTTOM;
        private System.Windows.Forms.Panel panelBOTTOM_RIGHT;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Panel panelBOTTOM_RIGHT_RIGHT;
        private System.Windows.Forms.Button bttnLast;
        private System.Windows.Forms.Button bttnNext;
        private System.Windows.Forms.Button bttnPrevious;
        private System.Windows.Forms.Button bttnFirst;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripDropDownButton tsbPreview;
        private System.Windows.Forms.ToolStripMenuItem tsbCrystalReport;
        private System.Windows.Forms.ToolStripMenuItem tsbCrystal_Selected;
        private System.Windows.Forms.ToolStripMenuItem tsbCrystal_All;
        private System.Windows.Forms.ColumnHeader chNumberLevel;
    }
}