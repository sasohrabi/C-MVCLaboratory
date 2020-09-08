using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using LMS;

namespace LMS
{
    public partial class InputBox : Form
    {
        public InputBox(){InitializeComponent();}

        private void InputBox_Load(object sender, EventArgs e)
        {

        }

        private void bttnCancel_Click(object sender, EventArgs e)
        {

        }

        ////CLASS VARIABLES
        //clsCommands sCommands = new clsCommands();
        //clsFunctions sFunctions = new clsFunctions();
        //clsVariables sVariables = new clsVariables();

        ////OLEDB VARIABLES
        //OleDbCommand sOleDbCommand = new OleDbCommand();

        ////BOOLEAN VARIABLES
        //public static bool boolVERIFY;

        ////STRING VARIABLES
        //public static string sSelect;
        //public static string sEntryTable;

        //private void InputBox_Load(object sender, EventArgs e)
        //{
        //    if (sSelect == "frmEmployees")
        //    {
        //        if (sEntryTable == "tblCourtesyTitle") { setTitle("Courtesy Title"); }
        //        else if (sEntryTable == "tblJobPositions") { setTitle("Job Position"); }
        //        else if (sEntryTable == "tblDepartments") { setTitle("Department"); }
        //    }
        //    else if (sSelect == "frmEmpDeductions_Modify"){if (sEntryTable == "tblDeductions") { setTitle("Deductions"); }}
        //}

        //private void InputBox_Activated(object sender, EventArgs e) { txtEntry.Focus(); }

        //private void setMessageBox(string sName){sFunctions.setMessageBox(sName + " was already exist. Please check it and change it!", 3);}

        //private void setTitle(string sTitle)
        //{
        //    this.Text = "Enter new " + sTitle;
        //    lblEntry.Text = "New " + sTitle;
        //}

        //private void setSuccessfull()
        //{
        //    sFunctions.setMessageBox("Record has been successfully added.", 1);
        //    Close();
        //}

        //private void bttnCancel_Click(object sender, EventArgs e){Close();}

        //private void bttnUpdate_Click(object sender, EventArgs e)
        //{
        //    if (txtEntry.Text == "")
        //    {
        //        sFunctions.setEmptyField("Data Entry Field");
        //        txtEntry.Focus();
        //    }
        //    else
        //    {
        //        try
        //        {
        //            if (sSelect == "frmEmployees")
        //            {
        //                if (sEntryTable == "tblCourtesyTitle")
        //                {
        //                    sCommands.getOleDbRecordCount(sVariables.sDataSet, "SELECT CourtesyTitle FROM tblCourtesyTitle WHERE CourtesyTitle LIKE '" + txtEntry.Text + "' ", "tblCourtesyTitle");

        //                    if (sVariables.sDataSet.Tables["tblCourtesyTitle"].Rows.Count >= 1) { setMessageBox("Courtesy Title"); }
        //                    else
        //                    {
        //                        sFunctions.setOledbConnCommand_Open(sOleDbCommand);
        //                        sOleDbCommand.CommandText = "INSERT INTO tblCourtesyTitle(CourtesyTitle) VALUES (@CourtesyTitle)";
        //                        sOleDbCommand.Parameters.Add("@CourtesyTitle", OleDbType.VarChar, 50);
        //                        sOleDbCommand.Parameters["@CourtesyTitle"].Value = txtEntry.Text;
        //                        sFunctions.setOledbConnCommand_Close(sOleDbCommand);
        //                        setSuccessfull();
        //                   //     frmEmployees_Modify.publicEmplsModify.setDBComboBox();
        //                    }
        //                }
        //                else if (sEntryTable == "tblJobPositions")
        //                {
        //                    sCommands.getOleDbRecordCount(sVariables.sDataSet, "SELECT JobPosition FROM tblJobPositions WHERE JobPosition LIKE '" + txtEntry.Text + "' ", "tblJobPositions");
        //                    if (sVariables.sDataSet.Tables["tblJobPositions"].Rows.Count >= 1) { setMessageBox("Job Position"); }
        //                    else
        //                    {
        //                        sFunctions.setOledbConnCommand_Open(sOleDbCommand);
        //                        sOleDbCommand.CommandText = "INSERT INTO tblJobPositions(JobPosition) VALUES (@JobPosition)";
        //                        sOleDbCommand.Parameters.Add("@JobPosition", OleDbType.VarChar, 50);
        //                        sOleDbCommand.Parameters["@JobPosition"].Value = txtEntry.Text;
        //                        sFunctions.setOledbConnCommand_Close(sOleDbCommand);
        //                        MainMenu.publicMDIParent.setWebTotals();
        //                        setSuccessfull();
        //                        if (boolVERIFY == false) { frmEmployees_Modify.publicEmplsModify.setDBComboBox(); }
        //                        else { frmJobPosition.publicJobPositions.setReload(); }
        //                    }
        //                }
        //                else if (sEntryTable == "tblDepartments")
        //                {
        //                    sCommands.getOleDbRecordCount(sVariables.sDataSet, "SELECT Department FROM tblDepartments WHERE Department LIKE '" + txtEntry.Text + "' ", "tblDepartments");
        //                    if (sVariables.sDataSet.Tables["tblDepartments"].Rows.Count >= 1) { setMessageBox("Department"); }
        //                    else
        //                    {
        //                        sFunctions.setOledbConnCommand_Open(sOleDbCommand);
        //                        sOleDbCommand.CommandText = "INSERT INTO tblDepartments(Department) VALUES (@Department)";
        //                        sOleDbCommand.Parameters.Add("@Department", OleDbType.VarChar, 50);
        //                        sOleDbCommand.Parameters["@Department"].Value = txtEntry.Text;
        //                        sFunctions.setOledbConnCommand_Close(sOleDbCommand);
        //                        setSuccessfull();
        //                        frmEmployees_Modify.publicEmplsModify.setDBComboBox();
        //                    }
        //                }
        //                else if (sEntryTable == "tblTaxPayers")
        //                {
        //                    sCommands.getOleDbRecordCount(sVariables.sDataSet, "SELECT TaxPayers FROM tblTaxPayers WHERE TaxPayers LIKE '" + txtEntry.Text + "' ", "tblTaxPayers");
        //                    if (sVariables.sDataSet.Tables["tblTaxPayers"].Rows.Count >= 1) { setMessageBox("Tax Payers"); }
        //                    else
        //                    {
        //                        sFunctions.setOledbConnCommand_Open(sOleDbCommand);
        //                        sOleDbCommand.CommandText = "INSERT INTO tblTaxPayers(TaxPayers) VALUES (@TaxPayers)";
        //                        sOleDbCommand.Parameters.Add("@TaxPayers", OleDbType.VarChar, 50);
        //                        sOleDbCommand.Parameters["@TaxPayers"].Value = txtEntry.Text;
        //                        sFunctions.setOledbConnCommand_Close(sOleDbCommand);
        //                        setSuccessfull();
        //                        frmEmployees_Modify.publicEmplsModify.setDBComboBox();
        //                    }
        //                }
        //            }
        //            else if (sSelect == "frmEmpDeductions_Modify")
        //            {
        //                if (sEntryTable == "tblDeductions")
        //                {
        //                    sCommands.getOleDbRecordCount(sVariables.sDataSet, "SELECT DeductionName FROM tblDeductions WHERE DeductionName LIKE '" + txtEntry.Text + "' ", "tblDeductions");
        //                    if (sVariables.sDataSet.Tables["tblDeductions"].Rows.Count >= 1) { setMessageBox("Deductions"); }
        //                    else
        //                    {
        //                        sFunctions.setOledbConnCommand_Open(sOleDbCommand);
        //                        sOleDbCommand.CommandText = "INSERT INTO tblDeductions(DeductionName) VALUES (@DeductionName)";
        //                        sOleDbCommand.Parameters.Add("@DeductionName", OleDbType.VarChar, 50);
        //                        sOleDbCommand.Parameters["@DeductionName"].Value = txtEntry.Text;
        //                        sFunctions.setOledbConnCommand_Close(sOleDbCommand);
        //                        setSuccessfull();
        //                        frmEmpDeductions_Modify.publicEmplsModify.setDBComboBox();
        //                    }
        //                }
        //            }
        //            txtEntry.Focus();
        //        }
        //        catch (Exception ex) { sFunctions.setCreateError(ex.Message, AppDomain.CurrentDomain.BaseDirectory + "\\Errors\\", Convert.ToDateTime(DateTime.Now.ToString()).ToString("MMM dd, yy - hh-mm-ss ttttt")); }
        //    }
        //}

    }
}