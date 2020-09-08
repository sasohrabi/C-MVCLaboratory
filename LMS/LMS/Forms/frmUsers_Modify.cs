using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMS.Forms
{
    public partial class frmUsers_Modify : Form
    {
        public frmUsers_Modify(){ InitializeComponent(); }

        //FORM VARIABLES
        public static frmUsers_Modify publicUsers_Modify;

        //CLASS VARIABLES
        clsFunctions sFunctions = new clsFunctions();
        clsCommands sCommands = new clsCommands();
        clsVariables sVariables = new clsVariables();

        //OLEDB VARIABLES
        SqlCommand sOleDbCommand = new SqlCommand();

        //BOOLEAN VARIABLES
        public static bool boolSTATUS;

        //STRING VARIABLES
        public static string sSearch;
        string sSQL_FULL = "SELECT  Username, AdminType, UPassword, CompleteName, StreetAddress, TelephoneNumber, MobileNumber, EmailAddress FROM  tblUsers";

        private void frmUsers_Modify_Activated(object sender, EventArgs e) { txtUsername.Focus(); }

        private void frmUsers_Modify_Load(object sender, EventArgs e)
        {
            bttnCancel.Image = MainMenu.publicMDIParent.i32x32.Images[9];
            bttnUpdate.Image = MainMenu.publicMDIParent.i32x32.Images[17];

            if (boolSTATUS == true) { this.Text = "New Test Code Entry"; }
            else
            {
                Text = "Update Existing User Code";
                txtUsername.ReadOnly = true;
                FillFields("SELECT  Username, AdminType, UPassword, CompleteName, StreetAddress, TelephoneNumber, MobileNumber, EmailAddress FROM  tblUsers WHERE Username LIKE '" + sSearch + "' ");
            }

            publicUsers_Modify = this;
        }

        public void FillFields(string sSQL)
        {
            sCommands.setOledbCommand(sVariables.sDataSet, sVariables.sOleDbDataAdapter, sSQL, "tblUsers");
            DataRow sDataRow = sVariables.sDataSet.Tables["tblUsers"].Rows[0];

            txtUsername.Text = sDataRow["Username"].ToString();
            txtAdminType.Text = sDataRow["AdminType"].ToString();
            txtUPassword.Text = sDataRow["UPassword"].ToString();
            txtCompleteName.Text = sDataRow["CompleteName"].ToString();
            txtStreetAddress.Text = sDataRow["StreetAddress"].ToString();
            txtTelephoneNumber.Text = sDataRow["TelephoneNumber"].ToString();
            txtMobileNumber.Text = sDataRow["MobileNumber"].ToString();
            txtEmailAddress.Text = sDataRow["EmailAddress"].ToString();

        }

        private void bttnCancel_Click(object sender, EventArgs e) { Close(); }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                sFunctions.setEmptyField("Code User");
                txtUsername.Focus();
            }
            else if (txtAdminType.Text == "")
            {
                sFunctions.setEmptyField("AdminType");
                txtAdminType.Focus();
            }
            else if (txtUPassword.Text == "")
            {
                sFunctions.setEmptyField("UPassword");
                txtUPassword.Focus();
            }
            else
            {
                try
                {
                    sCommands.getOleDbRecordCount(sVariables.sDataSet, "SELECT * FROM tblUsers WHERE Username LIKE '" + txtAdminType.Text + "' ", "tblUsers");
                    if (sVariables.sDataSet.Tables["tblUsers"].Rows.Count >= 1) { sFunctions.setMessageBox("The following name is already exist in the list. Pls try another one.", 2); }
                    else
                    {
                        sFunctions.setOledbConnCommand_Open(sOleDbCommand);

                        if (boolSTATUS == true) { sOleDbCommand.CommandText = "INSERT INTO tblUsers(Username,AdminType,UPassword,CompleteName,StreetAddress,TelephoneNumber,MobileNumber,EmailAddress) values (@Username,@AdminType,@UPassword,@CompleteName, @StreetAddress,@TelephoneNumber,@MobileNumber,@EmailAddress)"; }
                        else { sOleDbCommand.CommandText = "UPDATE tblUsers SET Username = @Username, AdminType = @AdminType, UPassword= @UPassword,CompleteName = @CompleteName,StreetAddress=@StreetAddress,TelephoneNumber=@TelephoneNumber,MobileNumber=@MobileNumber,EmailAddress=@EmailAddress WHERE Username LIKE '" + sSearch + "' "; }

                        sOleDbCommand.Parameters.Add("@Username", SqlDbType.NText , 16);
                        sOleDbCommand.Parameters.Add("@AdminType", SqlDbType.NText, 16);
                        sOleDbCommand.Parameters.Add("@UPassword", SqlDbType.Int , 4);
                        sOleDbCommand.Parameters.Add("@CompleteName", SqlDbType.NText , 16);
                        sOleDbCommand.Parameters.Add("@StreetAddress", SqlDbType.NText , 16);
                        sOleDbCommand.Parameters.Add("@TelephoneNumber", SqlDbType.Int , 4);
                        sOleDbCommand.Parameters.Add("@MobileNumber", SqlDbType.Int , 4);
                        sOleDbCommand.Parameters.Add("@EmailAddress", SqlDbType.NText ,16);

                        sOleDbCommand.Parameters["@Username"].Value = txtUsername.Text;
                        sOleDbCommand.Parameters["@AdminType"].Value = txtAdminType.Text;
                        sOleDbCommand.Parameters["@UPassword"].Value = txtUPassword.Text;
                        sOleDbCommand.Parameters["@CompleteName"].Value = txtCompleteName.Text;
                        sOleDbCommand.Parameters["@StreetAddress"].Value = txtStreetAddress.Text;
                        sOleDbCommand.Parameters["@TelephoneNumber"].Value = txtTelephoneNumber.Text;
                        sOleDbCommand.Parameters["@MobileNumber"].Value = txtMobileNumber.Text;
                        sOleDbCommand.Parameters["@EmailAddress"].Value = txtEmailAddress.Text;

                        sFunctions.setOledbConnCommand_Close(sOleDbCommand);
                        sFunctions.setUpdateDelay();
                        frmUsers.publicUsers.setReload();
                        MainMenu.publicMDIParent.setWebTotals();

                        if (boolSTATUS == false)
                        {
                            sFunctions.setMessageBox("Changes in record has been successfully saved.", 1);
                            Close();
                        }
                        else
                        {
                            sFunctions.setMessageBox("Record has been successfully added.", 1);

                            if (MessageBox.Show("Do you want to add another record?", clsVariables.sMessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) { this.Close(); }
                            else
                            {
                                txtUsername.Clear();
                                txtAdminType.Clear();
                                txtUPassword.Clear();
                                txtCompleteName.Clear();
                                txtStreetAddress.Clear();
                                txtTelephoneNumber.Clear();
                                txtMobileNumber.Clear();
                                txtEmailAddress.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex) { sFunctions.setCreateError(ex.Message, AppDomain.CurrentDomain.BaseDirectory + "\\Errors\\", Convert.ToDateTime(DateTime.Now.ToString()).ToString("MMM dd, yy - hh-mm-ss ttttt")); }
            }
        }

        private void txtCodeTest_KeyDown(object sender, KeyEventArgs e) { sFunctions.setKeyDown(sender, e); }

        private void txtCodeTest_KeyPress(object sender, KeyPressEventArgs e) { if (clsVariables.nonNumberEntered == true) { e.Handled = true; } }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}