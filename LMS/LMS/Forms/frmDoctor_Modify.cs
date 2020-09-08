using System;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMS.Forms
{
    public partial class frmDoctor_Modify : Form
    {
        public frmDoctor_Modify(){InitializeComponent();}

        //FORM VARIABLES
        public static frmDoctor_Modify publicDoctor_Modify;

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
        string sSQL_FULL = "SELECT CodeDoctor, Name, Family, Proficiency FROM  tblDoctor ORDER BY CodeDoctor ASC";
      
        private void frmDoctor_Modify_Activated(object sender, EventArgs e) {txtCodeDoctor.Focus();}

        private void frmDoctor_Modify_Load(object sender, EventArgs e)
        {
            bttnCancel.Image = MainMenu.publicMDIParent.i32x32.Images[9];
            bttnUpdate.Image = MainMenu.publicMDIParent.i32x32.Images[17];

            if (boolSTATUS == true) { this.Text = "New Doctor Code Entry"; }
            else
            {
                Text = "Update Existing Doctor Code";
                txtCodeDoctor.ReadOnly = true;
                FillFields("SELECT CodeDoctor, Name, Family, Proficiency FROM tblDoctor WHERE CodeDoctor =" + sSearch);
            }

            publicDoctor_Modify = this;
        }

        public void FillFields(string sSQL)
        {
            sCommands.setOledbCommand(sVariables.sDataSet, sVariables.sOleDbDataAdapter, sSQL, "tblDoctor");
            DataRow sDataRow = sVariables.sDataSet.Tables["tblDoctor"].Rows[0];

            txtCodeDoctor.Text = sDataRow["CodeDoctor"].ToString();
            txtName.Text = sDataRow["Name"].ToString();
            txtFamily.Text = sDataRow["Family"].ToString();
            txtProficiency.Text = sDataRow["Proficiency"].ToString();
        }

        private void bttnCancel_Click(object sender, EventArgs e) { Close(); }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCodeDoctor.Text == "")
            {
                sFunctions.setEmptyField("CodeDoctor");
                txtCodeDoctor.Focus();
            }
            else if (txtName.Text == "")
            {
                sFunctions.setEmptyField("Name");
                txtName.Focus();
            }
            else if (txtFamily.Text == "")
            {
                sFunctions.setEmptyField("Family");
                txtFamily.Focus();
            }
            else
            {
                try
                {
                    sCommands.getOleDbRecordCount(sVariables.sDataSet, "SELECT * FROM tblDoctor WHERE Name LIKE '" + txtName.Text + "'" + " AND Family LIKE '" + txtFamily.Text + "' "
                       , "tblDoctor");
                    if (sVariables.sDataSet.Tables["tblDoctor"].Rows.Count >= 1) { sFunctions.setMessageBox("The following name is already exist in the list. Pls try another one.", 2); }
                    else
                    {
                        sFunctions.setOledbConnCommand_Open(sOleDbCommand);

                        if (boolSTATUS == true) { sOleDbCommand.CommandText = "INSERT INTO tblDoctor(CodeDoctor,Name,Family,Proficiency) values (@CodeDoctor, @Name,  @Family,@Proficiency)"; }
                        else { sOleDbCommand.CommandText = "UPDATE tblDoctor SET CodeDoctor = @CodeDoctor,Name = @Name, Family = @Family,Proficiency = @Proficiency WHERE CodeDoctor = " + sSearch; }

                        sOleDbCommand.Parameters.Add("@CodeDoctor", SqlDbType.Int, 4);
                        sOleDbCommand.Parameters.Add("@Name", SqlDbType.NText, 16);
                        sOleDbCommand.Parameters.Add("@Family", SqlDbType.NText, 16);
                        sOleDbCommand.Parameters.Add("@Proficiency", SqlDbType.NText , 16);

                        sOleDbCommand.Parameters["@CodeDoctor"].Value = txtCodeDoctor.Text;
                        sOleDbCommand.Parameters["@Name"].Value = txtName.Text;
                        sOleDbCommand.Parameters["@Family"].Value = txtFamily.Text;
                        sOleDbCommand.Parameters["@Proficiency"].Value = txtProficiency.Text;


                        sFunctions.setOledbConnCommand_Close(sOleDbCommand);
                        sFunctions.setUpdateDelay();
                        frmDoctor.publicDoctor.setReload();
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
                                txtCodeDoctor.Clear();
                                txtName.Clear();
                                txtFamily.Clear();
                                txtProficiency.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex) { sFunctions.setCreateError(ex.Message, AppDomain.CurrentDomain.BaseDirectory + "\\Errors\\", Convert.ToDateTime(DateTime.Now.ToString()).ToString("MMM dd, yy - hh-mm-ss ttttt")); }
            }
        }

        private void txtCodeDoctor_KeyDown(object sender, KeyEventArgs e) { sFunctions.setKeyDown(sender, e); }

        private void txtCodeDoctor_KeyPress(object sender, KeyPressEventArgs e) { if (clsVariables.nonNumberEntered == true) { e.Handled = true; } }
    }
}