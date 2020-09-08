using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace LMS
{
    public partial class frmDoctor : Form
    {
        public frmDoctor(){InitializeComponent();}

        //FORM VARIABLES
        public static frmDoctor publicDoctor;

        //CLASS VARIABLES
        clsFunctions sFunctions = new clsFunctions();

        //DATASET VARIABLES
        DataSet dsDoctor = new DataSet();

        //BOOLEAN VARIABLES
        public static bool boolSTATUS;

        //STRING VARIABLES
        public static string sWHERE;
        string sSQL_FULL = "SELECT CodeDoctor, Name, Family, Proficiency FROM tblDoctor ORDER BY CodeDoctor ASC";

        private void frmEmployees_Load(object sender, EventArgs e)
        {
            setImages();
            sFunctions.setNavigation(1, sSQL_FULL, lvEmployees, lblRecordCount, "tblDoctor", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsDoctor, 100, 4, 4, "MMMM dd, yyyy");

            boolSTATUS = true;
            publicDoctor = this;
        }

        private void frmEmployees_Resize(object sender, EventArgs e) { ControlBox = false; }

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
            cmsItemDeductions.Image = MainMenu.publicMDIParent.i16x16.Images[21];
            cmsItemDelete.Image = MainMenu.publicMDIParent.i16x16.Images[7];
            cmsItemSearch.Image = MainMenu.publicMDIParent.i16x16.Images[8];
            cmsItemReload.Image = MainMenu.publicMDIParent.i16x16.Images[9];
            cmsItemPreview.Image = MainMenu.publicMDIParent.i16x16.Images[10];
            cmsItemClose.Image = MainMenu.publicMDIParent.i16x16.Images[11];

            lvEmployees.SmallImageList = MainMenu.publicMDIParent.i24x24;
        }

        private void setLoadModify(string sSearch, bool boolSTATUS)
        {
            LMS.Forms.frmDoctor_Modify.boolSTATUS = boolSTATUS;
            LMS.Forms.frmDoctor_Modify.sSearch = sSearch;
            LMS.Forms.frmDoctor_Modify sForm = new LMS.Forms.frmDoctor_Modify();
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
                if (lvEmployees.Items.Count > 0 || lvEmployees.FocusedItem.Index < 1) { setLoadModify(lvEmployees.Items[lvEmployees.FocusedItem.Index].SubItems[0].Text, false); }
                else { MessageBox.Show("No record to modify.", "Unable to Modify", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch (Exception ex) { sFunctions.setCreateError(ex.Message, AppDomain.CurrentDomain.BaseDirectory + "\\Errors\\", Convert.ToDateTime(DateTime.Now.ToString()).ToString("MMM dd, yy - hh-mm-ss ttttt")); }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lvEmployees.Items.Count > 0 || lvEmployees.FocusedItem.Index < 1)
                {
                    sFunctions.setRemoveListviewItem(lvEmployees, "DELETE FROM tblDoctor WHERE CodeDoctor like '" + lvEmployees.Items[lvEmployees.FocusedItem.Index].SubItems[0].Text + "' ", "tblDoctor", "frmDoctor");
                }
                else { MessageBox.Show("No record to delete.", "Unable to Delete", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            catch (Exception ex) { MessageBox.Show("Select a record to delete. Pls. try again.", "Error Found", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tsbSearch_Click(object sender, EventArgs e) { sFunctions.setSearchFilter(lblSelected, "Doctor Records"); }

        public void LoadSearch(){sFunctions.setFillRecord(lvEmployees, lblRecordCount, 1, sWHERE, "tblDoctor", 100, 4, bttnFirst, bttnPrevious, bttnNext, bttnLast, dsDoctor, 4, "MMMM dd, yyyy");}

        private void tsbReload_Click(object sender, EventArgs e) { setReload(); }

        public void setReload()
        {
            sFunctions.setNavigation(5, sSQL_FULL, lvEmployees, lblRecordCount, "tblDoctor", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsDoctor, 100, 4, 4, "MMMM dd, yyyy");
            lblSelected.Text = "Selected Record: NONE";
            boolSTATUS = true;
        }

        private void tsbCrystal_Selected_Click(object sender, EventArgs e)
        {
            sFunctions.setReportViewer(false, "CRPT Doctor Records", "SELECT tblDoctor.EmployeeID, tblDoctor.CourtesyTitle, [LastName]+', '+[FirstName]+' '+[MiddleName] AS Fullname, tblDoctor.Gender, tblDoctor.StreetAddress, tblPostalCodes.Municipality, tblPostalCodes.StateProvince, tblPostalCodes.PostalCode, tblDoctor.TelephoneNumber, tblDoctor.MobileNumber, tblDoctor.EmailAddress, tblDoctor.MonthlySalary, tblDoctor.AdvanceLimit, tblDoctor.Department, tblDoctor.JobPosition, tblDoctor.BirthDate, tblDoctor.HireDate, tblDoctor.TerminationDate, tblDoctor.Status, tblDoctor.Remarks, tblDoctor.InsertedBy, tblDoctor.DateInserted, tblDoctor.UpdatedBy, tblDoctor.DateUpdated FROM tblPostalCodes INNER JOIN tblDoctor ON tblPostalCodes.PostalCode = tblDoctor.PostalCode WHERE tblDoctor.EmployeeID LIKE '" + lvEmployees.Items[lvEmployees.FocusedItem.Index].SubItems[0].Text + "' ORDER BY tblDoctor.EmployeeID ASC", "tblDoctor");
        }

        private void tsbCrystal_All_Click(object sender, EventArgs e)
        {
            sFunctions.setReportViewer(false, "CRPT Doctor Records", "SELECT tblDoctor.EmployeeID, tblDoctor.CourtesyTitle, [LastName]+', '+[FirstName]+' '+[MiddleName] AS Fullname, tblDoctor.Gender, tblDoctor.StreetAddress, tblPostalCodes.Municipality, tblPostalCodes.StateProvince, tblPostalCodes.PostalCode, tblDoctor.TelephoneNumber, tblDoctor.MobileNumber, tblDoctor.EmailAddress, tblDoctor.MonthlySalary, tblDoctor.AdvanceLimit, tblDoctor.Department, tblDoctor.JobPosition, tblDoctor.BirthDate, tblDoctor.HireDate, tblDoctor.TerminationDate, tblDoctor.Status, tblDoctor.Remarks, tblDoctor.InsertedBy, tblDoctor.DateInserted, tblDoctor.UpdatedBy, tblDoctor.DateUpdated FROM tblPostalCodes INNER JOIN tblDoctor ON tblPostalCodes.PostalCode = tblDoctor.PostalCode ORDER BY tblDoctor.EmployeeID ASC", "tblDoctor");
        }

        private void tsbRDLC_Selected_Click(object sender, EventArgs e)
        {
 
        }

        private void tsbRDLC_All_Click(object sender, EventArgs e)
        {

        }

        private void tsbClose_Click(object sender, EventArgs e){Close();}

        private void cmsItemNew_Click(object sender, EventArgs e) { tsbNew_Click(sender, e); }

        private void cmsItemModify_Click(object sender, EventArgs e) { tsbModify_Click(sender, e); }

        private void cmsItemDelete_Click(object sender, EventArgs e) { tsbDelete_Click(sender, e); }

        private void cmsItemSearch_Click(object sender, EventArgs e) { tsbSearch_Click(sender, e); }

        private void cmsItemReload_Click(object sender, EventArgs e) { tsbReload_Click(sender, e); }

        private void cmsCrystal_Selected_Click(object sender, EventArgs e) { tsbCrystal_Selected_Click(sender, e); }

        private void cmsCrystal_All_Click(object sender, EventArgs e) { tsbCrystal_All_Click(sender, e); }

        private void cmsRDLC_Selected_Click(object sender, EventArgs e) { tsbRDLC_Selected_Click(sender, e); }

        private void cmsRDLC_All_Click(object sender, EventArgs e) { tsbRDLC_All_Click(sender, e); }

        private void cmsItemClose_Click(object sender, EventArgs e) { tsbClose_Click(sender, e); }

        private void lvEmployees_Click(object sender, EventArgs e) { sFunctions.setSelectedItem(lblSelected, lvEmployees); }

        private void lvEmployees_ColumnClick(object sender, ColumnClickEventArgs e) {  }

        private void lvEmployees_DoubleClick(object sender, EventArgs e) { tsbModify_Click(sender, e); }

        private void lvEmployees_Leave(object sender, EventArgs e) { lblSelected.Text = "Selected Record: NONE"; }

        private void bttnFirst_Click(object sender, EventArgs e)
        {
            if (boolSTATUS == true) { sFunctions.setNavigation(1, sSQL_FULL, lvEmployees, lblRecordCount, "tblDoctor", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsDoctor, 100, 4, 4, "MMMM dd, yyyy"); }
            else { sFunctions.setNavigation(1, sWHERE, lvEmployees, lblRecordCount, "tblDoctor", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsDoctor, 100, 4, 4, "MMMM dd, yyyy"); }
        }

        private void bttnPrevious_Click(object sender, EventArgs e)
        {
            if (boolSTATUS == true) { sFunctions.setNavigation(3, sSQL_FULL, lvEmployees, lblRecordCount, "tblDoctor", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsDoctor, 100, 4, 4, "MMMM dd, yyyy"); }
            else { sFunctions.setNavigation(3, sWHERE, lvEmployees, lblRecordCount, "tblDoctor", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsDoctor, 100, 4, 4, "MMMM dd, yyyy"); }
        }

        private void bttnNext_Click(object sender, EventArgs e)
        {
            if (boolSTATUS == true) { sFunctions.setNavigation(2, sSQL_FULL, lvEmployees, lblRecordCount, "tblDoctor", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsDoctor, 100, 4, 4, "MMMM dd, yyyy"); }
            else { sFunctions.setNavigation(2, sWHERE, lvEmployees, lblRecordCount, "tblDoctor", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsDoctor, 100, 4, 4, "MMMM dd, yyyy"); }
        }

        private void bttnLast_Click(object sender, EventArgs e)
        {
         //   sFunctions.setComlumnSorter(lvEmployees);
            if (boolSTATUS == true) { sFunctions.setNavigation(4, sSQL_FULL, lvEmployees, lblRecordCount, "tblDoctor", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsDoctor, 100, 4, 4, "MMMM dd, yyyy"); }
            else { sFunctions.setNavigation(4, sWHERE, lvEmployees, lblRecordCount, "tblDoctor", bttnFirst, bttnPrevious, bttnNext, bttnLast, dsDoctor, 100, 4, 4, "MMMM dd, yyyy"); }
        }

        private void lvEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblRecordCount_Click(object sender, EventArgs e)
        {

        }

    }
}