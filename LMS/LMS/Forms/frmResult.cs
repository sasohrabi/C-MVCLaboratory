using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient ;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMS.Forms
{
    public partial class frmResult : Form
    {
        public frmResult() { InitializeComponent(); }

        //FORM VARIABLES
        public static frmResult publicResult;

        //CLASS VARIABLES
        clsFunctions sFunctions = new clsFunctions();
        clsCommands sCommands = new clsCommands();
        clsVariables sVariables = new clsVariables();

        //OLEDB VARIABLES
        SqlCommand sOleDbCommand = new SqlCommand();

        //DATASET VARIABLES
        DataSet dstblResult = new DataSet();

        //STRING VARIABLES
        public static string sSearch;
        public static string sWHERE;
        string sSQL_FULL = "SELECT NumberReceipt, CodeTest, Answer FROM tblResult ORDER BY NumberReceipt ASC";
        string sSQL_cbo1 = "SELECT DISTINCT NumberReceipt FROM tblReception ORDER BY NumberReceipt ASC";


        //DOUBlE VARIABLES
        double dPercentDiscount = 0.0;
        double dPayment = 0.0;

        //BOOLEAN VARIABLES
        public static bool boolSTATUS;

        private void frmResult_Load(object sender, EventArgs e)
        {
            setImages();
            sFunctions.setNavigation(1, sSQL_FULL, lvPostalCodes, lblRecordCount, "tblResult", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblResult, 100, 4, 3, "");
    //        sFunctions.setComlumnSorter(lvPostalCodes);

            bttnCancel.Image = MainMenu.publicMDIParent.i32x32.Images[9];
            bttnUpdate.Image = MainMenu.publicMDIParent.i32x32.Images[17];
            bttnPrint.Image  = MainMenu.publicMDIParent.i32x32.Images[5];

            this.Text = "";

            sFunctions.setComboList(cboNumberReceipt, sSQL_cbo1, "tblReception", "NumberReceipt");

            boolSTATUS = true;
            publicResult = this;
        }

        private void frmResult_Activated(object sender, EventArgs e) { this.cboNumberReceipt.Focus(); }


        public void setReload(string sSQL_FULL)
        {
  //          sFunctions.setComlumnSorter(lvPostalCodes);
            sFunctions.setNavigation(5, sSQL_FULL, lvPostalCodes, lblRecordCount, "tblResult", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblResult, 100, 4, 3, "");
            lblSelected.Text = "Selected Record: NONE";
            boolSTATUS = true;
        }

        private void setImages()
        {
            bttnFirst.Image = MainMenu.publicMDIParent.i24x24.Images[0];
            bttnPrevious.Image = MainMenu.publicMDIParent.i24x24.Images[1];
            bttnNext.Image = MainMenu.publicMDIParent.i24x24.Images[2];
            bttnLast.Image = MainMenu.publicMDIParent.i24x24.Images[3];

            lvPostalCodes.SmallImageList = MainMenu.publicMDIParent.i24x24;
        }

        private void bttnCancel_Click(object sender, EventArgs e) { Close(); }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            string sSQL_FULL2 = "SELECT * FROM tblResult WHERE NumberReceipt LIKE '" + cboNumberReceipt.Text + "' ";

            if (cboNumberReceipt.Text == "")
            {
                sFunctions.setEmptyField("Number Receipt");
                cboNumberReceipt.Focus();
            }
            else if (cboCodeTest.Text == "")
            {
                sFunctions.setEmptyField("CodeTest");
                cboCodeTest.Focus();
            }
            else if (txtAnswer.Text == "")
            {
                sFunctions.setEmptyField("Answer");
                txtAnswer.Focus();
            }
            else
            {
                try
                {
                    sCommands.getOleDbRecordCount(sVariables.sDataSet, "SELECT * FROM tblResult WHERE NumberReceipt LIKE '" + cboNumberReceipt.Text + "'" + " AND CodeTest  LIKE '" + cboCodeTest.Text + "' ", "tblResult");
                    if (sVariables.sDataSet.Tables["tblResult"].Rows.Count >= 1) { sFunctions.setMessageBox("The following name is already exist in the list. Pls try another one.", 2); }
                    else
                    {
                        sFunctions.setOledbConnCommand_Open(sOleDbCommand);

                        sOleDbCommand.CommandText = "INSERT INTO tblResult(NumberReceipt,CodeTest,Answer) values (@NumberReceipt, @CodeTest,@Answer)";

                        sOleDbCommand.Parameters.Add("@NumberReceipt", SqlDbType.Int, 4);
                        sOleDbCommand.Parameters.Add("@CodeTest", SqlDbType.Int, 4);
                        sOleDbCommand.Parameters.Add("@Answer", SqlDbType.NText , 16);

                        sOleDbCommand.Parameters["@NumberReceipt"].Value = cboNumberReceipt.Text;
                        sOleDbCommand.Parameters["@CodeTest"].Value = cboCodeTest.Text;
                        sOleDbCommand.Parameters["@Answer"].Value = txtAnswer.Text;

                        sFunctions.setOledbConnCommand_Close(sOleDbCommand);
                        sFunctions.setUpdateDelay();
                        MainMenu.publicMDIParent.setWebTotals();
                        this.setReload(sSQL_FULL2);

                        sFunctions.setMessageBox("Record has been successfully added.", 1);

                        if (MessageBox.Show("Do you want to add another record?", clsVariables.sMessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) { this.Close(); }
                        else
                        {
                            txtAnswer.Clear();
                            cboCodeTest.Focus();
                        }
                    }
                }
                catch (Exception ex) { sFunctions.setCreateError(ex.Message, AppDomain.CurrentDomain.BaseDirectory + "\\Errors\\", Convert.ToDateTime(DateTime.Now.ToString()).ToString("MMM dd, yy - hh-mm-ss ttttt")); }
            }




        }

        private void bttnFirst_Click(object sender, EventArgs e)
        {
    //        sFunctions.setComlumnSorter(lvPostalCodes);
            if (boolSTATUS == true) { sFunctions.setNavigation(1, sSQL_FULL, lvPostalCodes, lblRecordCount, "tblResult", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblResult, 100, 3, 4, ""); }
            else { sFunctions.setNavigation(1, sWHERE, lvPostalCodes, lblRecordCount, "tblResult", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblResult, 100, 3, 4, ""); }
        }

        private void bttnPrevious_Click(object sender, EventArgs e)
        {
   //         sFunctions.setComlumnSorter(lvPostalCodes);
            if (boolSTATUS == true) { sFunctions.setNavigation(3, sSQL_FULL, lvPostalCodes, lblRecordCount, "tblResult", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblResult, 100, 3, 4, ""); }
            else { sFunctions.setNavigation(3, sWHERE, lvPostalCodes, lblRecordCount, "tblResult", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblResult, 100, 3, 4, ""); }
        }

        private void bttnNext_Click(object sender, EventArgs e)
        {
    //        sFunctions.setComlumnSorter(lvPostalCodes);
            if (boolSTATUS == true) { sFunctions.setNavigation(2, sSQL_FULL, lvPostalCodes, lblRecordCount, "tblResult", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblResult, 100, 3, 4, ""); }
            else { sFunctions.setNavigation(2, sWHERE, lvPostalCodes, lblRecordCount, "tblResult", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblResult, 100, 3, 4, ""); }
        }

        private void bttnLast_Click(object sender, EventArgs e)
        {
    //        sFunctions.setComlumnSorter(lvPostalCodes);
            if (boolSTATUS == true) { sFunctions.setNavigation(4, sSQL_FULL, lvPostalCodes, lblRecordCount, "tblResult", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblResult, 100, 3, 4, ""); }
            else { sFunctions.setNavigation(4, sWHERE, lvPostalCodes, lblRecordCount, "tblResult", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblResult, 100, 3, 4, ""); }
        }

        private void lvPostalCodes_Click(object sender, EventArgs e) { sFunctions.setSelectedItem(lblSelected, lvPostalCodes); }

        private void lvPostalCodes_ColumnClick(object sender, ColumnClickEventArgs e) { }

        private void lvPostalCodes_Leave(object sender, EventArgs e) { lblSelected.Text = "Selected Record: NONE"; }

        private void cboNumberReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sSQL_cbo2 = "SELECT CodeTest FROM tblReception where NumberReceipt = ";

            try
            {
                sSQL_cbo2 += Convert.ToString(cboNumberReceipt.Text);
                sFunctions.setComboList(cboCodeTest, sSQL_cbo2, "tblReception", "CodeTest");
            }
            catch (Exception ex) { }
        
        }

        private void bttnPrint_Click(object sender, EventArgs e) { sFunctions.setReportViewer(false, "CRPT Result Records", "SELECT * FROM tblResult WHERE tblResult.NumberReceipt LIKE '" + this.cboNumberReceipt.Text + "' ORDER BY tblResult.NumberReceipt ASC", "tblResult"); }
    }
}