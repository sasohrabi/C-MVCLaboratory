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
            //sFunctions.setBusinessProfile();
            //  sFunctions.setTodaysTip(lblTips);

            publicMDIParent = this;

            SplashScreen sSplashScreen = new SplashScreen();
            sSplashScreen.ShowDialog();
        }

        public void setTitlebar()
        {
            //sFunctions.setBusinessProfile();
            Text +=  " " + "مدیریت آزمایشگاه";
        }

        public void setWebTotals()
        {
            wbInformation.Navigate("");
            sFunctions.setWebInfo_Remove();
            sFunctions.setWebInfo_Create();
            wbInformation.Navigate(Path.GetTempPath().ToString() + @"laboratoryinfo.htm");
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("برنامه در حال بسته شدن است. آیا می خواهید برنامه بسته شود؟", clsVariables.sMessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) { e.Cancel = true; }
            else
            {
                try
                {
                    clsVariables.sUserLogout = DateTime.Now.ToLongTimeString();

                    sFunctions.setRecordLogout(clsVariables.sUserLogout, clsVariables.sUsername);
                    sFunctions.setMessageBox(clsVariables.sUserFullname + " با موفقیت از برنامه خارج شدید.\n\nزمان خروج: " + Convert.ToDateTime(clsVariables.sUserLogout).ToString("MMM dd, yyyy  [ hh:mm:ss ttttt ]"), 1);
                    sFunctions.setMessageBox("روز خوبی داشته باشید و همواره از خدا تشکر کنید", 1);
                    System.Diagnostics.Process.Start("http://magiclaboratory.blogfa.com/");
                  //  sFunctions.setWebInfo_Remove();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void wbInformation_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }
    }
}