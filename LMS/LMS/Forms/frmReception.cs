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
    public partial class frmReception : Form
    {
        public frmReception() { InitializeComponent(); }

        //FORM VARIABLES
        public static frmReception publicfrmReception;

        //CLASS VARIABLES
        clsFunctions sFunctions = new clsFunctions();
        clsCommands sCommands = new clsCommands();
        clsVariables sVariables = new clsVariables();

        //OLEDB VARIABLES
        SqlCommand sOleDbCommand = new SqlCommand();

        //DATASET VARIABLES
        DataSet dstblReception = new DataSet();

        //STRING VARIABLES
        public static string sSearch;
        public static string sWHERE;
        string sSQL_FULL = "SELECT NumberReceipt, CodeDoctor, CodePatient, CodeInsurance, CodeTest, Percent_Payment, DateReception, Statement FROM tblReception ORDER BY NumberReceipt ASC";
        string sSQL_cbo1 = "SELECT CodeDoctor FROM tblDoctor ORDER BY CodeDoctor ASC";
        string sSQL_cbo2 = "SELECT CodePatient FROM tblPatient ORDER BY CodePatient ASC";
        string sSQL_cbo3 = "SELECT CodeInsurance,PercentDiscount FROM tblInsurance ORDER BY CodeInsurance ASC";
        string sSQL_cbo4 = "SELECT CodeTest,Payment FROM tblTest ORDER BY CodeTest ASC";

        //DOUBlE VARIABLES
        double  dPercentDiscount= 0.0 ;
        double dPayment = 0.0;

        //BOOLEAN VARIABLES
        public static bool boolSTATUS;

        private void frmReception_Load(object sender, EventArgs e)
        {
            setImages();
            sFunctions.setNavigation(1, sSQL_FULL, lvPostalCodes, lblRecordCount, "tblReception", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblReception, 100,4, 8, "");
        //    sFunctions.setComlumnSorter(lvPostalCodes);

            bttnCancel.Image = MainMenu.publicMDIParent.i32x32.Images[9];
            bttnUpdate.Image = MainMenu.publicMDIParent.i32x32.Images[17];
            bttnPrint.Image = MainMenu.publicMDIParent.i32x32.Images[5];

             this.Text = "";

             sFunctions.setComboList(cboCodeDoctor, sSQL_cbo1, "tblDoctor", "CodeDoctor");
             sFunctions.setComboList(cboCodePatient, sSQL_cbo2, "tblPatient", "CodePatient");
             sFunctions.setComboList2(cboCodeInsurance, sSQL_cbo3, "tblInsurance", "CodeInsurance", "PercentDiscount");
             sFunctions.setComboList2(cboCodeTest, sSQL_cbo4, "tblTest", "CodeTest", "Payment");

             boolSTATUS = true;
             publicfrmReception = this;
        }

        private void frmReception_Activated(object sender, EventArgs e) { this.txtNumberReceipt.Focus(); }

        public void setReload(string sSQL_FULL)
        {
    //        sFunctions.setComlumnSorter(lvPostalCodes);
            sFunctions.setNavigation(5, sSQL_FULL, lvPostalCodes, lblRecordCount, "tblReception", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblReception, 100, 4, 8, "");
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


        private void cboCodeTest_SelectedIndexChanged(object sender, EventArgs e)
        {
            dPercentDiscount = Convert.ToDouble(cboCodeInsurance.SelectedValue);
            txtCompletPayment.Text = Convert.ToString(cboCodeTest.SelectedValue);
            txtPercent_Payment.Text = Convert.ToString(dPayment-dPercentDiscount * dPayment);
        }

        private void cboCodeInsurance_SelectedIndexChanged(object sender, EventArgs e)
        {

            dPayment = Convert.ToDouble(cboCodeTest.SelectedValue);
            
        }

        private void bttnCancel_Click(object sender, EventArgs e) { Close(); }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            string sSQL_FULL2 = "SELECT * FROM tblReception WHERE NumberReceipt LIKE '" + txtNumberReceipt.Text + "' " ;

            if (txtNumberReceipt.Text == "")
            {
                sFunctions.setEmptyField("Number Receipt");
                txtNumberReceipt.Focus();
            }
            else if (cboCodeDoctor.Text == "")
            {
                sFunctions.setEmptyField("CodeDoctor");
                cboCodeDoctor.Focus();
            }
            else if (cboCodePatient.Text == "")
            {
                sFunctions.setEmptyField("CodePatient");
                cboCodePatient.Focus();
            }
            else if (cboCodeInsurance.Text == "")
            {
                sFunctions.setEmptyField("CodeInsurance");
                cboCodeInsurance.Focus();
            }
            else
            {
                try
                {
                    sCommands.getOleDbRecordCount(sVariables.sDataSet, "SELECT * FROM tblReception WHERE NumberReceipt LIKE '" + txtNumberReceipt.Text + "'" + " AND CodeTest  LIKE '" + txtNumberReceipt.Text + "' ", "tblReception");
                    if (sVariables.sDataSet.Tables["tblReception"].Rows.Count >= 1) { sFunctions.setMessageBox("The following name is already exist in the list. Pls try another one.", 2); }
                    else
                    {
                        sFunctions.setOledbConnCommand_Open(sOleDbCommand);

                        sOleDbCommand.CommandText = "INSERT INTO tblReception(NumberReceipt,CodeDoctor,CodePatient,CodeInsurance,CodeTest,Percent_Payment,DateReception,Statement) values (@NumberReceipt, @CodeDoctor,@CodePatient,@CodeInsurance,  @CodeTest,@Percent_Payment,@DateReception, @Statement)"; 

                        sOleDbCommand.Parameters.Add("@NumberReceipt", SqlDbType.Int, 4);
                        sOleDbCommand.Parameters.Add("@CodeDoctor", SqlDbType.Int, 4);
                        sOleDbCommand.Parameters.Add("@CodePatient", SqlDbType.Int, 4);
                        sOleDbCommand.Parameters.Add("@CodeInsurance", SqlDbType.Int, 4);
                        sOleDbCommand.Parameters.Add("@CodeTest", SqlDbType.Int, 4);
                        sOleDbCommand.Parameters.Add("@Percent_Payment", SqlDbType.Float , 8);
                        sOleDbCommand.Parameters.Add("@DateReception", SqlDbType.Char , 10);
                        sOleDbCommand.Parameters.Add("@Statement", SqlDbType.NText, 16);

                        sOleDbCommand.Parameters["@NumberReceipt"].Value = txtNumberReceipt.Text;
                        sOleDbCommand.Parameters["@CodeDoctor"].Value = cboCodeDoctor.Text;
                        sOleDbCommand.Parameters["@CodePatient"].Value = cboCodePatient.Text;
                        sOleDbCommand.Parameters["@CodeInsurance"].Value = cboCodeInsurance.Text;
                        sOleDbCommand.Parameters["@CodeTest"].Value = cboCodeTest.Text;
                        sOleDbCommand.Parameters["@Percent_Payment"].Value = txtPercent_Payment.Text;
                        sOleDbCommand.Parameters["@DateReception"].Value = mskDateReception.Text;
                        sOleDbCommand.Parameters["@Statement"].Value = txtStatement.Text;

                        sFunctions.setOledbConnCommand_Close(sOleDbCommand);
                        sFunctions.setUpdateDelay();
                        MainMenu.publicMDIParent.setWebTotals();
                        this.setReload(sSQL_FULL2);

                        sFunctions.setMessageBox("Record has been successfully added.", 1);

                            if (MessageBox.Show("Do you want to add another record?", clsVariables.sMessageBox, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) { this.Close(); }
                            else
                            {
                                cboCodeTest.Text = "";
                                mskDateReception.Clear();
                                txtStatement.Clear();
                                cboCodeTest.Focus();
                            }
                        }
                    }
                catch (Exception ex) { sFunctions.setCreateError(ex.Message, AppDomain.CurrentDomain.BaseDirectory + "\\Errors\\", Convert.ToDateTime(DateTime.Now.ToString()).ToString("MMM dd, yy - hh-mm-ss ttttt")); }
            }
        }

        private void bttnFirst_Click(object sender, EventArgs e)
        {
     //       sFunctions.setComlumnSorter(lvPostalCodes);
            if (boolSTATUS == true) { sFunctions.setNavigation(1, sSQL_FULL, lvPostalCodes, lblRecordCount, "tblReception", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblReception, 100, 8, 4, ""); }
            else { sFunctions.setNavigation(1, sWHERE, lvPostalCodes, lblRecordCount, "tblReception", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblReception, 100, 8, 4, ""); }
        }

        private void bttnPrevious_Click(object sender, EventArgs e)
        {
    //        sFunctions.setComlumnSorter(lvPostalCodes);
            if (boolSTATUS == true) { sFunctions.setNavigation(3, sSQL_FULL, lvPostalCodes, lblRecordCount, "tblReception", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblReception, 100, 8, 4, ""); }
            else { sFunctions.setNavigation(3, sWHERE, lvPostalCodes, lblRecordCount, "tblReception", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblReception, 100, 8, 4, ""); }
        }

        private void bttnNext_Click(object sender, EventArgs e)
        {
      //      sFunctions.setComlumnSorter(lvPostalCodes);
            if (boolSTATUS == true) { sFunctions.setNavigation(2, sSQL_FULL, lvPostalCodes, lblRecordCount, "tblReception", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblReception, 100, 8, 4, ""); }
            else { sFunctions.setNavigation(2, sWHERE, lvPostalCodes, lblRecordCount, "tblReception", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblReception, 100, 8, 4, ""); }
        }

        private void bttnLast_Click(object sender, EventArgs e)
        {
       //     sFunctions.setComlumnSorter(lvPostalCodes);
            if (boolSTATUS == true) { sFunctions.setNavigation(4, sSQL_FULL, lvPostalCodes, lblRecordCount, "tblReception", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblReception, 100, 8, 4, ""); }
            else { sFunctions.setNavigation(4, sWHERE, lvPostalCodes, lblRecordCount, "tblReception", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblReception, 100, 8, 4, ""); }
        }

        private void lvPostalCodes_Click(object sender, EventArgs e) { sFunctions.setSelectedItem(lblSelected, lvPostalCodes); }

        private void lvPostalCodes_ColumnClick(object sender, ColumnClickEventArgs e) { }

        private void lvPostalCodes_Leave(object sender, EventArgs e) { lblSelected.Text = "Selected Record: NONE"; }

        private void bttnPrint_Click(object sender, EventArgs e) { sFunctions.setReportViewer(false, "CRPT Reception Records", "SELECT * FROM tblReception WHERE tblReception.NumberReceipt LIKE '" + this.txtNumberReceipt.Text + "' ORDER BY tblReception.NumberReceipt ASC", "tblReception"); }

        private void lvPostalCodes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
