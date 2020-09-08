using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LMS.Forms
{
    public partial class frmPatient_Modify : Form
    {
        public frmPatient_Modify() { InitializeComponent(); }
        public static frmPatient_Modify publicfrmPatient_Modify;

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
        string sSQL_FULL = "SELECT CodePatient, Name, Family, Age, Type, Part FROM tblPatient ORDER BY CodePatient ASCC";

        private void frmPatient_Modify_Load(object sender, EventArgs e)
        {
            bttnCancel.Image = MainMenu.publicMDIParent.i32x32.Images[9];
            bttnUpdate.Image = MainMenu.publicMDIParent.i32x32.Images[17];

            if (boolSTATUS == true) { this.Text = "New Test Code Entry"; }
            else
            {
                Text = "Update Existing Test Code";
                txtCodePatient.ReadOnly = true;
                FillFields("SELECT CodePatient, Name, Family, Age, Type, Part FROM tblPatient WHERE CodePatient LIKE '" + sSearch + "' ");
            }

            publicfrmPatient_Modify = this;
        }

        public void FillFields(string sSQL)
        {
            sCommands.setOledbCommand(sVariables.sDataSet, sVariables.sOleDbDataAdapter, sSQL, "tblPatient");
            DataRow sDataRow = sVariables.sDataSet.Tables["tblPatient"].Rows[0];

            txtCodePatient.Text = sDataRow["CodePatient"].ToString();
            txtName.Text = sDataRow["Name"].ToString();
            txtFamily.Text = sDataRow["Family"].ToString();
            txtAge.Text = sDataRow["Age"].ToString();
            cboType.Text = sDataRow["Type"].ToString();
            txtPart.Text = sDataRow["Part"].ToString();

        }

        private void bttnCancel_Click(object sender, EventArgs e) { Close(); }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCodePatient.Text == "")
            {
                sFunctions.setEmptyField("CodePatient");
                txtCodePatient.Focus();
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
                    sCommands.getOleDbRecordCount(sVariables.sDataSet, "SELECT * FROM tblPatient WHERE Name LIKE '" + txtName.Text + "' AND Family LIKE '" + txtFamily.Text + "' ", "tblPatient");
                    if (sVariables.sDataSet.Tables["tblPatient"].Rows.Count >= 1) { sFunctions.setMessageBox("The following name is already exist in the list. Pls try another one.", 2); }
                    else
                    {
                        sFunctions.setOledbConnCommand_Open(sOleDbCommand);

                        if (boolSTATUS == true) { sOleDbCommand.CommandText = "INSERT INTO tblPatient(CodePatient, Name, Family, Age,Type,Part) values (@CodePatient, @Name,@Family,@Age,@Type,@Part)"; }
                        else { sOleDbCommand.CommandText = "UPDATE tblPatient SET CodePatient = @CodePatient, Name = @Name, Family = @Family, Age = @Age,Type=@Type ,Part=@Part WHERE CodePatient LIKE '" + sSearch + "' "; }

                        sOleDbCommand.Parameters.Add("@CodePatient", SqlDbType.Int, 20);
                        sOleDbCommand.Parameters.Add("@Name", SqlDbType.VarChar, 50);
                        sOleDbCommand.Parameters.Add("@Family", SqlDbType.VarChar, 50);
                        sOleDbCommand.Parameters.Add("@Age", SqlDbType.Int, 10);
                        sOleDbCommand.Parameters.Add("@Type", SqlDbType.VarChar, 10);
                        sOleDbCommand.Parameters.Add("@Part", SqlDbType.Int, 10); 

                        sOleDbCommand.Parameters["@CodePatient"].Value = txtCodePatient.Text;
                        sOleDbCommand.Parameters["@Name"].Value = txtName.Text;
                        sOleDbCommand.Parameters["@Family"].Value = txtFamily.Text;
                        sOleDbCommand.Parameters["@Age"].Value = txtAge.Text;
                        sOleDbCommand.Parameters["@Type"].Value = cboType.Text;
                        sOleDbCommand.Parameters["@Part"].Value = txtPart.Text;

                        sFunctions.setOledbConnCommand_Close(sOleDbCommand);
                        sFunctions.setUpdateDelay();
                        frmPatient.publicPatient.setReload();
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
                                txtCodePatient.Clear();
                                txtName.Clear();
                                txtFamily.Clear();
                                txtAge.Clear();
                                txtPart.Clear();

                                cboType.Text= "";

                            }
                        }
                    }
                }
                catch (Exception ex) { sFunctions.setCreateError(ex.Message, AppDomain.CurrentDomain.BaseDirectory + "\\Errors\\", Convert.ToDateTime(DateTime.Now.ToString()).ToString("MMM dd, yy - hh-mm-ss ttttt")); }
            }
        }

        private void txtPostalCodes_KeyDown(object sender, KeyEventArgs e)
        {
            sFunctions.setKeyDown(sender, e); 
        }

        private void txtPostalCodes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (clsVariables.nonNumberEntered == true) { e.Handled = true; } 
        }

    }
}