using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LMS.Forms
{
    public partial class frmUsers : Form
    {
        public frmUsers() { InitializeComponent(); }

        //FORM VARIABLES
        public static frmUsers publicUsers;

        //CLASS VARIABLES
        clsFunctions sFunctions = new clsFunctions();

        //DATASET VARIABLES
        DataSet dstblUsers = new DataSet();

        //BOOLEAN VARIABLES
        public static bool boolSTATUS;

        //STRING VARIABLES
        public static string sWHERE;
        string sSQL_FULL = "SELECT Username, AdminType, UPassword, CompleteName, StreetAddress, TelephoneNumber, MobileNumber, EmailAddress FROM tblUsers";

        private void frmUsers_Load(object sender, EventArgs e)
        {
            setImages();
            sFunctions.setNavigation(1, sSQL_FULL, lvPostalCodes, lblRecordCount, "tblUsers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblUsers, 100, 4, 8, "");
  //          sFunctions.setComlumnSorter(lvPostalCodes);

            boolSTATUS = true;
            publicUsers = this;
        }

        private void frmUsers_Resize(object sender, EventArgs e) { ControlBox = false; }

        private void setImages()
        {
            tsbNew.Image = MainMenu.publicMDIParent.i32x32.Images[13];
            tsbModify.Image = MainMenu.publicMDIParent.i32x32.Images[1];
            tsbSearch.Image = MainMenu.publicMDIParent.i32x32.Images[2];
            tsbDelete.Image = MainMenu.publicMDIParent.i32x32.Images[3];
            tsbReload.Image = MainMenu.publicMDIParent.i32x32.Images[4];
            tsbPreview.Image = MainMenu.publicMDIParent.i32x32.Images[5];
            tsbClose.Image = MainMenu.publicMDIParent.i32x32.Images[6];

            bttnFirst.Image = MainMenu.publicMDIParent.i24x24.Images[0];
            bttnPrevious.Image = MainMenu.publicMDIParent.i24x24.Images[1];
            bttnNext.Image = MainMenu.publicMDIParent.i24x24.Images[2];
            bttnLast.Image = MainMenu.publicMDIParent.i24x24.Images[3];

            cmsItemNew.Image = MainMenu.publicMDIParent.i16x16.Images[5];
            cmsItemModify.Image = MainMenu.publicMDIParent.i16x16.Images[6];
            cmsItemDelete.Image = MainMenu.publicMDIParent.i16x16.Images[7];
            cmsItemSearch.Image = MainMenu.publicMDIParent.i16x16.Images[8];
            cmsItemReload.Image = MainMenu.publicMDIParent.i16x16.Images[9];
            cmsItemClose.Image = MainMenu.publicMDIParent.i16x16.Images[11];

            lvPostalCodes.SmallImageList = MainMenu.publicMDIParent.i24x24;
        }

        private void setLoadModify(string sSearch, bool boolSTATUS)
        {
            frmUsers_Modify.boolSTATUS = boolSTATUS;
            frmUsers_Modify.sSearch = sSearch;
            frmUsers_Modify sForm = new frmUsers_Modify();
            sForm.ShowDialog();
        }

        private void tsbNew_Click(object sender, EventArgs e)
        {
            lblSelected.Text = "Selected Record: NONE";
            setLoadModify("", true);
        }

        private void tsbModify_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvPostalCodes.Items.Count > 0 || lvPostalCodes.FocusedItem.Index < 1) { setLoadModify(lvPostalCodes.Items[lvPostalCodes.FocusedItem.Index].SubItems[0].Text, false); }
                else { MessageBox.Show("No record to modify.", "Unable to Modify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch (Exception ex) { sFunctions.setCreateError(ex.Message, AppDomain.CurrentDomain.BaseDirectory + "\\Errors\\", Convert.ToDateTime(DateTime.Now.ToString()).ToString("MMM dd, yy - hh:mm:ss ttttt")); }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvPostalCodes.Items.Count > 0 || lvPostalCodes.FocusedItem.Index < 1)
                {
                    sFunctions.setRemoveListviewItem(lvPostalCodes, "DELETE FROM tblUsers WHERE Username LIKE '" + lvPostalCodes.Items[lvPostalCodes.FocusedItem.Index].SubItems[0].Text + "' ", "tblUsers", "frmUsers");
                }
                else { MessageBox.Show("No record to delete.", "Unable to Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch (Exception ex) { MessageBox.Show("Select a record to delete. Pls. try again.", "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tsbSearch_Click(object sender, EventArgs e) { sFunctions.setSearchFilter(lblSelected, "User Records"); }

        public void LoadSearch() { sFunctions.setFillRecord(lvPostalCodes, lblRecordCount, 1, sWHERE, "tblUsers", 100, 4, bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblUsers, 4, ""); }

        private void tsbReload_Click(object sender, EventArgs e) { setReload(); }

        public void setReload()
        {
     //       sFunctions.setComlumnSorter(lvPostalCodes);
            sFunctions.setNavigation(5, sSQL_FULL, lvPostalCodes, lblRecordCount, "tblUsers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblUsers, 100, 4, 8, "");
            lblSelected.Text = "Selected Record: NONE";
            boolSTATUS = true;
        }

        private void tsbClose_Click(object sender, EventArgs e) { Close(); }

        private void cmsItemNew_Click(object sender, EventArgs e) { tsbNew_Click(sender, e); }

        private void cmsItemModify_Click(object sender, EventArgs e) { tsbModify_Click(sender, e); }

        private void cmsItemDelete_Click(object sender, EventArgs e) { tsbDelete_Click(sender, e); }

        private void cmsItemSearch_Click(object sender, EventArgs e) { tsbSearch_Click(sender, e); }

        private void cmsItemReload_Click(object sender, EventArgs e) { tsbReload_Click(sender, e); }

        private void cmsItemClose_Click(object sender, EventArgs e) { tsbClose_Click(sender, e); }

        private void lvPostalCodes_Click(object sender, EventArgs e) { sFunctions.setSelectedItem(lblSelected, lvPostalCodes); }

        private void lvPostalCodes_ColumnClick(object sender, ColumnClickEventArgs e) {  }

        private void lvPostalCodes_DoubleClick(object sender, EventArgs e) { tsbModify_Click(sender, e); }

        private void lvPostalCodes_Leave(object sender, EventArgs e) { lblSelected.Text = "Selected Record: NONE"; }

        private void bttnFirst_Click(object sender, EventArgs e)
        {
   //         sFunctions.setComlumnSorter(lvPostalCodes);
            if (boolSTATUS == true) { sFunctions.setNavigation(1, sSQL_FULL, lvPostalCodes, lblRecordCount, "tblUsers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblUsers, 100, 8, 4, ""); }
            else { sFunctions.setNavigation(1, sWHERE, lvPostalCodes, lblRecordCount, "tblUsers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblUsers, 100, 8, 4, ""); }
        }

        private void bttnPrevious_Click(object sender, EventArgs e)
        {
  //          sFunctions.setComlumnSorter(lvPostalCodes);
            if (boolSTATUS == true) { sFunctions.setNavigation(3, sSQL_FULL, lvPostalCodes, lblRecordCount, "tblUsers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblUsers, 100, 8, 4, ""); }
            else { sFunctions.setNavigation(3, sWHERE, lvPostalCodes, lblRecordCount, "tblUsers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblUsers, 100, 8, 4, ""); }
        }

        private void bttnNext_Click(object sender, EventArgs e)
        {
   //         sFunctions.setComlumnSorter(lvPostalCodes);
            if (boolSTATUS == true) { sFunctions.setNavigation(2, sSQL_FULL, lvPostalCodes, lblRecordCount, "tblUsers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblUsers, 100, 8, 4, ""); }
            else { sFunctions.setNavigation(2, sWHERE, lvPostalCodes, lblRecordCount, "tblUsers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblUsers, 100, 8, 4, ""); }
        }

        private void bttnLast_Click(object sender, EventArgs e)
        {
    //        sFunctions.setComlumnSorter(lvPostalCodes);
            if (boolSTATUS == true) { sFunctions.setNavigation(4, sSQL_FULL, lvPostalCodes, lblRecordCount, "tblUsers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblUsers, 100, 8, 4, ""); }
            else { sFunctions.setNavigation(4, sWHERE, lvPostalCodes, lblRecordCount, "tblUsers", bttnFirst, bttnPrevious, bttnNext, bttnLast, dstblUsers, 100, 8, 4, ""); }
        }

        private void tsbPreview_Click(object sender, EventArgs e)
        {

        }

        private void tsbCrystal_Selected_Click(object sender, EventArgs e)
        {
            //  sFunctions.setReportViewer(false, "CRPT Employees Records", "SELECT tblEmployees.EmployeeID, tblEmployees.CourtesyTitle, [LastName]+', '+[FirstName]+' '+[MiddleName] AS Fullname, tblEmployees.Gender, tblEmployees.StreetAddress, tblUsers.Municipality, tblUsers.StateProvince, tblUsers.PostalCode, tblEmployees.TelephoneNumber, tblEmployees.MobileNumber, tblEmployees.EmailAddress, tblEmployees.MonthlySalary, tblEmployees.AdvanceLimit, tblEmployees.Department, tblEmployees.JobPosition, tblEmployees.BirthDate, tblEmployees.HireDate, tblEmployees.TerminationDate, tblEmployees.Status, tblEmployees.Remarks, tblEmployees.InsertedBy, tblEmployees.DateInserted, tblEmployees.UpdatedBy, tblEmployees.DateUpdated FROM tblUsers INNER JOIN tblEmployees ON tblUsers.PostalCode = tblEmployees.PostalCode WHERE tblEmployees.EmployeeID LIKE '" + lvEmployees.Items[lvEmployees.FocusedItem.Index].SubItems[0].Text + "' ORDER BY tblEmployees.EmployeeID ASC", "tblEmployees");
        }

        private void tsbCrystal_All_Click(object sender, EventArgs e)
        {
            sFunctions.setReportViewer(false, "CRPT Test Records", "SELECT * from tblUsers", "tblUsers");
        }



    }
}