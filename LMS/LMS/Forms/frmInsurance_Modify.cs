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
    public partial class frmInsurance_Modify : Form
    {
        public frmInsurance_Modify() { InitializeComponent(); }

        //FORM VARIABLES
        public static frmInsurance_Modify publicInsurance_Modify;

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
        string sSQL_FULL = "SELECT CodeInsurance, Name, PercentDiscount FROM tblInsurance ORDER BY CodeInsurance ASC";

        private void frmInsurance_Modify_Activated(object sender, EventArgs e) { txtCodeInsurance.Focus(); }

        private void frmInsurance_Modify_Load(object sender, EventArgs e)
        {
            bttnCancel.Image = MainMenu.publicMDIParent.i32x32.Images[9];
            bttnUpdate.Image = MainMenu.publicMDIParent.i32x32.Images[17];

            if (boolSTATUS == true) { this.Text = "New Insurance Code Entry"; }
            else
            {
                Text = "Update Existing Insurance Code";
                txtCodeInsurance.ReadOnly = true;
                FillFields("SELECT CodeInsurance, Name, PercentDiscount FROM tblInsurance WHERE CodeInsurance LIKE '" + sSearch + "' ");
            }

            publicInsurance_Modify = this;
        }

        public void FillFields(string sSQL)
        {
            sCommands.setOledbCommand(sVariables.sDataSet, sVariables.sOleDbDataAdapter, sSQL, "tblInsurance");
            DataRow sDataRow = sVariables.sDataSet.Tables["tblInsurance"].Rows[0];

            txtCodeInsurance.Text = sDataRow["CodeInsurance"].ToString();
            txtName.Text = sDataRow["Name"].ToString();
            txtPercentDiscount.Text = sDataRow["PercentDiscount"].ToString();
        }

        private void bttnCancel_Click(object sender, EventArgs e) { Close(); }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCodeInsurance.Text == "")
            {
                sFunctions.setEmptyField("CodeInsurance");
                txtCodeInsurance.Focus();
            }
            else if (txtName.Text == "")
            {
                sFunctions.setEmptyField("Name");
                txtName.Focus();
            }
            else if (txtPercentDiscount.Text == "")
            {
                sFunctions.setEmptyField("PercentDiscount");
                txtPercentDiscount.Focus();
            }
            else
            {
                try
                {
                    sCommands.getOleDbRecordCount(sVariables.sDataSet, "SELECT * FROM tblInsurance WHERE Name LIKE '" + txtName.Text + "' ", "tblInsurance");
                    if (sVariables.sDataSet.Tables["tblInsurance"].Rows.Count >= 1) { sFunctions.setMessageBox("The following name is already exist in the list. Pls try another one.", 2); }
                    else
                    {
                        sFunctions.setOledbConnCommand_Open(sOleDbCommand);

                        if (boolSTATUS == true) { 
                           sOleDbCommand.CommandText = "INSERT INTO tblInsurance(CodeInsurance, Name,PercentDiscount) values (@CodeInsurance, @Name,@PercentDiscount)";

                            sOleDbCommand.Parameters.Add("@CodeInsurance", SqlDbType.Int, 4);
                            sOleDbCommand.Parameters.Add("@Name", SqlDbType.NText, 16);
                            sOleDbCommand.Parameters.Add("@PercentDiscount", SqlDbType.Float, 8);

                            sOleDbCommand.Parameters["@CodeInsurance"].Value = txtCodeInsurance.Text;
                            sOleDbCommand.Parameters["@Name"].Value = txtName.Text;
                            sOleDbCommand.Parameters["@PercentDiscount"].Value = txtPercentDiscount.Text;
                         }
                        else {
                            sOleDbCommand.CommandText = "UPDATE tblInsurance SET Name = @Name, PercentDiscount = @PercentDiscount WHERE CodeInsurance LIKE '" + sSearch + "' ";

                            sOleDbCommand.Parameters.Add("@Name", SqlDbType.NText, 16);
                            sOleDbCommand.Parameters.Add("@PercentDiscount", SqlDbType.Float, 8);

                            sOleDbCommand.Parameters["@Name"].Value = txtName.Text;
                            sOleDbCommand.Parameters["@PercentDiscount"].Value = txtPercentDiscount.Text;
                         }

                         sFunctions.setOledbConnCommand_Close(sOleDbCommand);
                         sFunctions.setUpdateDelay();
                         frmInsurance.publicInsurance.setReload();
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
                                txtCodeInsurance.Clear();
                                txtName.Clear();
                                txtPercentDiscount.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex) { sFunctions.setCreateError(ex.Message, AppDomain.CurrentDomain.BaseDirectory + "\\Errors\\", Convert.ToDateTime(DateTime.Now.ToString()).ToString("MMM dd, yy - hh-mm-ss ttttt")); }
            }
        }

        private void txtCodeInsurance_KeyDown(object sender, KeyEventArgs e) { sFunctions.setKeyDown(sender, e); }

        private void txtCodeInsurance_KeyPress(object sender, KeyPressEventArgs e) { if (clsVariables.nonNumberEntered == true) { e.Handled = true; } }

    }
}