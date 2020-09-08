using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMS.Forms
{
    public partial class frmBank : Form
    {
        public frmBank(){ InitializeComponent(); }

        //FORM VARIABLES
        public static frmBank  publicbank;

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
        string sSQL_cbo1 = "SELECT DISTINCT NumberReceipt FROM tblReception ORDER BY NumberReceipt ASC";

        private void frmBank_Activated(object sender, EventArgs e) {cboNumberReceipt.Focus() ; }

        private void frmBank_Load(object sender, EventArgs e)
        {
            bttnCancel.Image = MainMenu.publicMDIParent.i32x32.Images[9];
            bttnUpdate.Image = MainMenu.publicMDIParent.i32x32.Images[17];

            sFunctions.setComboList(cboNumberReceipt, sSQL_cbo1, "tblReception", "NumberReceipt");

            publicbank = this;
        }

        private void bttnCancel_Click(object sender, EventArgs e) { Close(); }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (cboNumberReceipt.Text == "")
            {
                sFunctions.setEmptyField("NumberReceipt");
                cboNumberReceipt.Focus();
            }
            else if (txtPayment.Text == "")
            {
                sFunctions.setEmptyField("Payment");
                txtPayment.Focus();
            }
            else
            {
                try
                {
                    sCommands.getOleDbRecordCount(sVariables.sDataSet, "SELECT * FROM tblBank WHERE NumberReceipt LIKE '" + cboNumberReceipt.Text + "' ", "tblBank");
                    if (sVariables.sDataSet.Tables["tblBank"].Rows.Count >= 1) { sFunctions.setMessageBox("The following name is already exist in the list. Pls try another one.", 2); }
                    else
                    {
                        sFunctions.setOledbConnCommand_Open(sOleDbCommand);

                        sOleDbCommand.CommandText = "INSERT INTO tblBank(NumberReceipt,Payment) values (@NumberReceipt, @Payment)";

                        sOleDbCommand.Parameters.Add("@NumberReceipt", SqlDbType.Int, 4);
                        sOleDbCommand.Parameters.Add("@Payment", SqlDbType.Real , 4);

                        sOleDbCommand.Parameters["@NumberReceipt"].Value = cboNumberReceipt.Text;
                        sOleDbCommand.Parameters["@Payment"].Value = txtPayment.Text;

                        sFunctions.setOledbConnCommand_Close(sOleDbCommand);
                        sFunctions.setUpdateDelay();
                        MainMenu.publicMDIParent.setWebTotals();

                        sFunctions.setMessageBox("Record has been successfully added.", 1);

                        if (MessageBox.Show("Do you want to add another record?", clsVariables.sMessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) { this.Close(); }
                        else
                        {
                            txtPayment.Text = "";
                            txtPayment.Focus();
                        }
                    }
                }
                catch (Exception ex) { sFunctions.setCreateError(ex.Message, AppDomain.CurrentDomain.BaseDirectory + "\\Errors\\", Convert.ToDateTime(DateTime.Now.ToString()).ToString("MMM dd, yy - hh-mm-ss ttttt")); }
            }
        }

        private void cboNumberReceipt_KeyDown(object sender, KeyEventArgs e) { sFunctions.setKeyDown(sender, e); }

        private void cboNumberReceipt_KeyPress(object sender, KeyPressEventArgs e) { if (clsVariables.nonNumberEntered == true) { e.Handled = true; } }

    }
}