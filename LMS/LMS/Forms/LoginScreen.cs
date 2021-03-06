using System;
using System.Data;
using System.Windows.Forms;
using System.Globalization;

namespace LMS
{
    public partial class LoginScreen : Form
    {
        public LoginScreen() { InitializeComponent(); }

        //CLASS VARIABLES
        clsCommands sCommands = new clsCommands();
        clsFunctions sFunctions = new clsFunctions();
        clsVariables sVariables = new clsVariables();

        //INTEGER VARIABLES
        int iTips;
        int iAttempt;

        //DateTime VARIABLES
         PersianCalendar jc = new PersianCalendar();
         DateTime thisDate = DateTime.Now;

        private void LoginScreen_Activated(object sender, EventArgs e) { txtUsername.Focus(); }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            //Buttons
            bttnCancel.Image = i32x32.Images[1];
            bttnLogin.Image = i32x32.Images[7];
         }

        private void bttnCancel_Click(object sender, EventArgs e) { Close(); }

        private void bttnLogin_Click(object sender, EventArgs e)
        {
            sCommands.getOleDbRecordCount(sVariables.sDataSet, "SELECT * FROM tblusers WHERE Username LIKE '" + txtUsername.Text + "' And UPassword LIKE '" + txtPassword.Text + "'", "tblusers");
            iTips = sVariables.sDataSet.Tables["tblUsers"].Rows.Count;
            if (iTips >= 1)
            {
                string sSQL = "SELECT * FROM tblusers WHERE Username LIKE '" + txtUsername.Text + "' ";

                sCommands.setOledbCommand(sVariables.sDataSet, sVariables.sOleDbDataAdapter, sSQL, "tblUsers");
                DataRow sDataRow = sVariables.sDataSet.Tables["tblUsers"].Rows[0];
                clsVariables.sUserFullname = sDataRow["CompleteName"].ToString();
                clsVariables.sUsername = txtUsername.Text;
                clsVariables.sUserType = sDataRow["AdminType"].ToString();
                clsVariables.sUserLogin = Convert.ToDateTime(DateTime.Now.ToString()).ToString(" yy,MM,dd - hh:mm:ss ttttt");
                clsVariables.boolConnected = true; 
                sFunctions.setRecordLogin(DateTime.Now.ToLongTimeString(), txtUsername.Text);
                Close();
            }
            else
            {
                if (lblAttempt.Text == "1")
                {
                    sFunctions.setMessageBox("شما تمام تلاشتان را کردید.\nبنابراین نرم افزار بسته می شود.", 3);
                    Close();
                }
                else
                {
                    iAttempt = Convert.ToInt32(lblAttempt.Text) - 1;
                    lblAttempt.Text = iAttempt.ToString();
                    sFunctions.setMessageBox("نام کاربری/پسورد معتبر نمی باشد. لطفا دوباره سعی کنید.\n\nهشدار: شما فقط " + lblAttempt.Text + " تلاش دیگر دارید.", 3);
                }
            }
        }

        private void chkUnmask_CheckedChanged(object sender, EventArgs e)
        {
            if (chkUnmask.Checked == true) { this.txtPassword.PasswordChar = Convert.ToChar(0); }
            else { this.txtPassword.PasswordChar = '*'; }
        }
    }
}