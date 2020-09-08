using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using LMS;

namespace LMS
{
    public partial class MainMenu : Form
    {
        public MainMenu(){InitializeComponent();}

        //CLASS VARIABLES
        clsConnections sConnections = new clsConnections();
        clsFunctions sFunctions = new clsFunctions();

        //FORM VARIABLES
        public static MainMenu publicMDIParent;

        private void MainMenu_Load(object sender, EventArgs e)
        {
            ShortcutMenu sForm = new ShortcutMenu();
            sForm.MdiParent = this;
            sForm.Show();

            setWebTotals();

            lblUsername.Text = clsVariables.sUserFullname;
            lblTimeLogin.Text = clsVariables.sUserLogin;

            setTitlebar();
            sFunctions.setBusinessProfile();
          //  sFunctions.setTodaysTip(lblTips);

            publicMDIParent = this;

            SplashScreen sSplashScreen = new SplashScreen();
            sSplashScreen.ShowDialog();
        }

        public void setTitlebar()
        {
            sFunctions.setBusinessProfile();
            Text = clsVariables.sCompanyName + " - [ MAGIC PAYROLL ver. 1.5 ]";
        }

        public void setWebTotals()
        {
        //    wbInformation.Navigate("");
            //sFunctions.setWebInfo_Remove();
            sFunctions.setWebInfo_Create();
        //    wbInformation.Navigate(Path.GetTempPath().ToString() + @"payrollinfo.htm");
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("This will close the application. Do you want to continue?", clsVariables.sMessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) { e.Cancel = true; }
            else
            {
                try
                {
                    clsVariables.sUserLogout = DateTime.Now.ToLongTimeString();

                    sFunctions.setRecordLogout(clsVariables.sUserLogout, clsVariables.sUsername);
                    sFunctions.setMessageBox(clsVariables.sUserFullname + " has been successfully log-out.\n\nLog-out Time: " + Convert.ToDateTime(clsVariables.sUserLogout).ToString("MMM dd, yyyy  [ hh:mm:ss ttttt ]"), 1);
                    sFunctions.setMessageBox("PLS. DON’T FORGET TO VOTE:\n\nHave a nice day and GOD Bless always", 1);
                    System.Diagnostics.Process.Start("http://votemagicpayroll.cjb.net/");
                   // sFunctions.setWebInfo_Remove();
                }
                catch (Exception ex) { }
            }
        }

        private void panelLEFT_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picTOP_LEFT_02_Click(object sender, EventArgs e)
        {

        }
    }
}