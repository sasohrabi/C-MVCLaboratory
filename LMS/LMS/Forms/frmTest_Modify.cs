using System;
using System.Data;
using System.Data.SqlClient ;
using System.Windows.Forms;

namespace LMS
{
    public partial class frmTest_Modify : Form
    {
        public frmTest_Modify(){InitializeComponent();}

        //FORM VARIABLES
        public static frmTest_Modify publicTest_Modify;

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
        string sSQL_FULL = "SELECT CodeTest, Name, Symbol, Payment, NumberLevel FROM tblTest ORDER BY CodeTest ASC";

        private void frmPostalCodes_Modify_Activated(object sender, EventArgs e) { txtCodeTest.Focus(); }

        private void frmPostalCodes_Modify_Load(object sender, EventArgs e)
        {
            bttnCancel.Image = MainMenu.publicMDIParent.i32x32.Images[9];
            bttnUpdate.Image = MainMenu.publicMDIParent.i32x32.Images[17];

            if (boolSTATUS == true) { this.Text = "New Test Code Entry"; }
            else
            {
                Text = "Update Existing Test Code";
                txtCodeTest.ReadOnly = true;
                FillFields("SELECT CodeTest, Name, Symbol, Payment, NumberLevel FROM tblTest WHERE CodeTest LIKE '" + sSearch + "' ");
            }

            publicTest_Modify = this;
        }

        public void FillFields(string sSQL)
        {
            sCommands.setOledbCommand(sVariables.sDataSet, sVariables.sOleDbDataAdapter, sSQL, "tblTest");
            DataRow sDataRow = sVariables.sDataSet.Tables["tblTest"].Rows[0];

            txtCodeTest.Text = sDataRow["CodeTest"].ToString();
            txtName.Text = sDataRow["Name"].ToString();
            txtSymbol.Text = sDataRow["Symbol"].ToString();
            txtPayment.Text = sDataRow["Payment"].ToString();
            txtNumberLevel.Text = sDataRow["NumberLevel"].ToString();

        }

        private void bttnCancel_Click(object sender, EventArgs e) { Close(); }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCodeTest.Text == "")
            {
                sFunctions.setEmptyField("Code Test");
                txtCodeTest.Focus();
            }
            else if (txtName.Text == "")
            {
                sFunctions.setEmptyField("Name");
                txtName.Focus();
            }
            else if (txtSymbol.Text == "")
            {
                sFunctions.setEmptyField("Symbol");
                txtSymbol.Focus();
            }
            else
            {
                try
                {
                    sCommands.getOleDbRecordCount(sVariables.sDataSet, "SELECT * FROM tblTest WHERE Name LIKE '" + txtName.Text + "' ", "tblTest");
                    if (sVariables.sDataSet.Tables["tblTest"].Rows.Count >= 1) { sFunctions.setMessageBox("The following name is already exist in the list. Pls try another one.", 2); }
                    else
                    {
                        sFunctions.setOledbConnCommand_Open(sOleDbCommand);

                        if (boolSTATUS == true) { sOleDbCommand.CommandText = "INSERT INTO tblTest(CodeTest, Name, Symbol,Payment,NumberLevel) values (@CodeTest, @Name,  @Symbol,@Payment, @NumberLevel)"; }
                        else { sOleDbCommand.CommandText = "UPDATE tblTest SET CodeTest = @CodeTest, Name = @Name, Symbol = @Symbol,Payment = @Payment,NumberLevel=@NumberLevel WHERE CodeTest LIKE '" + sSearch + "' "; }

                        sOleDbCommand.Parameters.Add("@CodeTest", SqlDbType.Int ,4);
                        sOleDbCommand.Parameters.Add("@Name", SqlDbType.NText , 16);
                        sOleDbCommand.Parameters.Add("@Symbol", SqlDbType.NText, 16);
                        sOleDbCommand.Parameters.Add("@Payment", SqlDbType.Real , 4);
                        sOleDbCommand.Parameters.Add("@NumberLevel", SqlDbType.Int , 4);

                        sOleDbCommand.Parameters["@CodeTest"].Value = txtCodeTest.Text;
                        sOleDbCommand.Parameters["@Name"].Value = txtName.Text;
                        sOleDbCommand.Parameters["@Symbol"].Value = txtSymbol.Text;
                        sOleDbCommand.Parameters["@Payment"].Value = txtPayment.Text ;
                        sOleDbCommand.Parameters["@NumberLevel"].Value = txtNumberLevel.Text ;

                        sFunctions.setOledbConnCommand_Close(sOleDbCommand);
                        sFunctions.setUpdateDelay();
                        frmTest.publicTest.setReload();
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
                                txtCodeTest.Clear();
                                txtName.Clear();
                                txtSymbol.Clear();
                                txtPayment.Clear();
                                txtNumberLevel.Clear();
                            }
                        }
                    }
                }
                catch (Exception ex) { sFunctions.setCreateError(ex.Message, AppDomain.CurrentDomain.BaseDirectory + "\\Errors\\", Convert.ToDateTime(DateTime.Now.ToString()).ToString("MMM dd, yy - hh-mm-ss ttttt")); }
            }
        }

        private void txtPostalCodes_KeyDown(object sender, KeyEventArgs e) { sFunctions.setKeyDown(sender, e); }

        private void txtPostalCodes_KeyPress(object sender, KeyPressEventArgs e) { if (clsVariables.nonNumberEntered == true) { e.Handled = true; } }
    }
}