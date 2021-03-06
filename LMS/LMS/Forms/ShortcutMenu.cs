using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using LMS;
using LMS.Forms;

namespace LMS
{
    public partial class ShortcutMenu : Form
    {
        public ShortcutMenu(){InitializeComponent();}

        //CLASS VARIABLES
        clsCommands sCommands = new clsCommands();
        clsFunctions sFunctions = new clsFunctions();
        clsVariables sVariables = new clsVariables();

        //DATASET VARIABLES
        DataSet sDataSet = new DataSet();

        ////SQLDMO VARIABLES
        //SQLDMO.SQLServer server;
        //SQLDMO.Database database;
        //SQLDMO.Backup backup;
 
        private void frmShortcuts_Load(object sender, EventArgs e)
        {
            clsSettings.setListview(lvShortcuts, "اطلاعات پزشکان", 28, i64x64);
            clsSettings.setListview(lvShortcuts, "اطلاعات بیماران", 34, i64x64);
            clsSettings.setListview(lvShortcuts, "اطلاعات آزمایشات", 23, i64x64);
            clsSettings.setListview(lvShortcuts, "اطلاعات بیمه",24 , i64x64);
            clsSettings.setListview(lvShortcuts, "پذیرش", 16, i64x64);
            clsSettings.setListview(lvShortcuts, "صندوق", 17, i64x64);
            clsSettings.setListview(lvShortcuts, "نتیجه آزمایش", 18, i64x64);
            clsSettings.setListview(lvShortcuts, "اطلاعات کاربران", 31, i64x64);
            clsSettings.setListview(lvShortcuts, "جزئیات وقایع", 37, i64x64);
            clsSettings.setListview(lvShortcuts, "راهنما", 20, i64x64);
            clsSettings.setListview(lvShortcuts, "ماشین حساب", 5, i64x64);
            clsSettings.setListview(lvShortcuts, "یادداشت برداری", 7, i64x64);
            clsSettings.setListview(lvShortcuts, "نوشتن نامه", 8, i64x64);
            clsSettings.setListview(lvShortcuts, "نرم افزار نقاشی", 6, i64x64);
            clsSettings.setListview(lvShortcuts, "پشتیبان گیری", 3, i64x64);
            clsSettings.setListview(lvShortcuts, "بازگردانی پشتیبان", 3, i64x64);
            clsSettings.setListview(lvShortcuts, "کلیدهای سریع", 4, i64x64);
            clsSettings.setListview(lvShortcuts, "درباره نرم افزار", 1, i64x64);


            clsSettings.setCreateDirectory("Errors", AppDomain.CurrentDomain.BaseDirectory);
        }

        private void frmShortcuts_Resize(object sender, EventArgs e) { ControlBox = false; }

        private void lvShortcuts_DoubleClick(object sender, EventArgs e)
        {
            switch (lvShortcuts.Items[lvShortcuts.FocusedItem.Index].SubItems[0].Text)
            {
                case "اطلاعات پزشکان":
                    cmsF3_Click(sender, e);
                    break;
                case "اطلاعات بیماران":
                    cmsF2_Click(sender, e);
                    break;
                case "اطلاعات آزمایشات":
                    cmsF1_Click(sender, e);
                    break;
                case "اطلاعات بیمه":
                    cmsF9_Click(sender, e);
                    break;
                case "پذیرش":
                    cmsF5_Click(sender, e);
                    break;
                case "صندوق":
                    cmsF6_Click(sender, e);
                    break;
                case "نتیجه آزمایش":
                    cmsF7_Click(sender, e);
                    break;
                case "اطلاعات کاربران":
                    cmsF8_Click(sender, e);
                    break;           
                case "جزئیات وقایع":
                    cmsF4_Click(sender, e);
                    break;
                case "راهنما":
                    cmsF10_Click(sender, e);
                    break;
                case "پشتیبان گیری":
                    cmsCtrlF1_Click(sender, e);
                    break;
                case "بازگردانی پشتیبان":
                    cmsCtrlF8_Click(sender, e);
                    break;
                case "کلیدهای سریع":
                    cmsCtrlF2_Click(sender, e);
                    break;
                case "درباره نرم افزار":
                    cmsCtrlF3_Click(sender, e);
                    break;
                case "ماشین حساب":
                    cmsCtrlF4_Click(sender, e);
                    break;
                case "یادداشت برداری":
                    cmsCtrlF5_Click(sender, e);
                    break;
                case "نوشتن نامه":
                    cmsCtrlF6_Click(sender, e);
                    break;
                case "نرم افزار نقاشی":
                    cmsCtrlF7_Click(sender, e);
                    break;
            }
        }

     private void cmsF1_Click(object sender, EventArgs e){clsSettings.setMDIChild(frmTest.Instance(), MainMenu.publicMDIParent);}

        private void cmsF2_Click(object sender, EventArgs e)
        {
            if (clsVariables.sUserType == "Admin")
            {
                clsSettings.setMDIChild(frmPatient.Instance(), MainMenu.publicMDIParent);
            }
            else { MessageBox.Show("This function is for administrator only.\nPlease log-in as administrator to gain access.", clsVariables.sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cmsF3_Click(object sender, EventArgs e)
        {
            if (clsVariables.sUserType == "Admin") { clsSettings.setMDIChild(frmDoctor.Instance(), MainMenu.publicMDIParent); }
            else { MessageBox.Show("This function is for administrator only.\nPlease log-in as administrator to gain access.", clsVariables.sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cmsF4_Click(object sender, EventArgs e)
        {
            if (clsVariables.sUserType == "Admin")
            {
                LogDetails sLogDetails = new LogDetails();
                sLogDetails.ShowDialog();
            }
            else { MessageBox.Show("This function is for administrator only.\nPlease log-in as administrator to gain access.", clsVariables.sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

      private void cmsF5_Click(object sender, EventArgs e)
      {
            frmReception sfrmReception = new frmReception();
            sfrmReception.ShowDialog();
      }

        private void cmsF6_Click(object sender, EventArgs e)
        {
            frmBank sBank = new frmBank();
            sBank.ShowDialog();
        }

        private void cmsF7_Click(object sender, EventArgs e)
        {
            frmResult sResult = new frmResult();
            sResult.ShowDialog();

        }

        private void cmsF8_Click(object sender, EventArgs e)
        {
            if (clsVariables.sUserType == "Admin") { clsSettings.setMDIChild(frmUsers.Instance(), MainMenu.publicMDIParent); }
            else { MessageBox.Show("This function is for administrator only.\nPlease log-in as administrator to gain access.", clsVariables.sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cmsF9_Click(object sender, EventArgs e)
        {
            
            if (clsVariables.sUserType == "Admin") { clsSettings.setMDIChild(frmInsurance.Instance(), MainMenu.publicMDIParent); }
            else { MessageBox.Show("This function is for administrator only.\nPlease log-in as administrator to gain access.", clsVariables.sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cmsF10_Click(object sender, EventArgs e)
        {
            clsSettings.setComponent("Vision Report.htm", "Help Document");
        }

        private void cmsCtrlF1_Click(object sender, EventArgs e)
        {
            if (clsVariables.sUserType == "Admin")
            {
                SQLDMO.SQLServerClass server = new SQLDMO.SQLServerClass();
                SQLDMO.BackupClass backup = new SQLDMO.BackupClass();

                server.LoginSecure = true;
                server.Connect("(local)", "sa", "");

                backup.Database = "LABORATORY_DB";           //database.Name;
                backup.Files = "d:\\Bak_L_M_s.bak";
                backup.SQLBackup(server);

                server.DisConnect();

                MessageBox.Show("Database backup complete", "backup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("This function is for administrator only.\nPlease log-in as administrator to gain access.", clsVariables.sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cmsCtrlF2_Click(object sender, EventArgs e)
        {
            ShortcutKeys sShortcutKeys = new ShortcutKeys();
            sShortcutKeys.ShowDialog();
        }

        private void cmsCtrlF3_Click(object sender, EventArgs e)
        {
            AboutSystem sAboutSystem = new AboutSystem();
            sAboutSystem.ShowDialog();
        }

        private void cmsCtrlF4_Click(object sender, EventArgs e){clsSettings.setComponent("Calc.exe", "Windows Calculator");}

        private void cmsCtrlF5_Click(object sender, EventArgs e){clsSettings.setComponent("Notepad.exe", "Windows Notepad");}

        private void cmsCtrlF6_Click(object sender, EventArgs e){clsSettings.setComponent("Write.exe", "Windows Wordpad");}

        private void cmsCtrlF7_Click(object sender, EventArgs e){clsSettings.setComponent("MSPaint.exe", "Microsoft Paint");}

        private void lvShortcuts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmsF1_Click_1(object sender, EventArgs e)
        {

        }

        private void cmsCtrlF8_Click(object sender, EventArgs e) 
        {
            if (clsVariables.sUserType == "Admin")
            {

                sCommands.getOleDbCommand("RESTORE FILELISTONLY FROM DISK = 'd:\\Bak_L_M_s.bak'");

                MessageBox.Show("Database restore complete", "restore Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { MessageBox.Show("This function is for administrator only.\nPlease log-in as administrator to gain access.", clsVariables.sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

    }
}