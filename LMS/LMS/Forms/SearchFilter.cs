using System;
using System.Windows.Forms;
using LMS;
using LMS.Forms;

namespace LMS
{
    public partial class SearchFilter : Form
    {
        public SearchFilter(){InitializeComponent();}

        //CLASS VARIABLES
        clsFunctions sFunctions = new clsFunctions();

        //STRING VARIABLES
        public static string sSelect;
        public static string sEmpCode;
        public static string sMonthYear;

        //OBJECT VARIABLES
        Object[] objDoctor = new Object[4] { "tblDoctor.CodeDoctor", "tblDoctor.Name", "tblDoctor.Family", "tblDoctor.Proficiency" };
        Object[] objPatient = new Object[6] { "CodePatient", "Name", "Family", "Age", "Type", "Part" };
        Object[] objTest = new Object[5] { "CodeTest", "Name", "Symbol", "Payment", "NumberLevel" };
        Object[] objInsurance = new Object[3] { "CodeInsurance", "Name", "PercentDiscount" };
        Object[] objUsers = new Object[7] { "Username", "AdminType", "CompleteName", "StreetAddress", "TelephoneNumber", "MobileNumber", "EmailAddress" };

        private void SearchFilter_Load(object sender, EventArgs e)
        {
            setComboBox(cbCondition1);
            setComboBox(cbCondition2);
            setImages();

            if (sSelect == "Doctor Records") { cbFields.Items.AddRange(objDoctor); }
            else if (sSelect == "Patient Records") { cbFields.Items.AddRange(objPatient); }
            else if (sSelect == "Test Records" || sSelect == "Test Records Viewer") { cbFields.Items.AddRange(objTest); }
            else if (sSelect == "Insurance Records" || sSelect == "Insurance Periods Viewer") { cbFields.Items.AddRange(objInsurance); }
            else if (sSelect == "User Records") { cbFields.Items.AddRange(objUsers); }
        }

        private void setImages()
        {
            picArrow1.Image = MainMenu.publicMDIParent.i24x24.Images[5];
            picArrow2.Image = MainMenu.publicMDIParent.i24x24.Images[5];
        }

        private void setComboBox(ComboBox sComboBox)
        {
            sComboBox.Items.Add("contains");
            sComboBox.Items.Add("is equal to");
            sComboBox.Items.Add("not euqal to");
            sComboBox.Items.Add("is greater than");
            sComboBox.Items.Add("is greater than or equal to");
            sComboBox.Items.Add("is less than");
            sComboBox.Items.Add("is less than or equal");
            sComboBox.Items.Add("between");
        }

        private void cbFields_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = true; }

        private void cbCondition1_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = true; }

        private void cbCondition2_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = true; }

        private void cbCondition1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCondition1.Text == "between") { txtFilter1.Visible = false; }
            else { txtFilter1.Visible = true; }
        }

        private void cbCondition2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCondition2.Text == "between") { txtFilter2.Visible = false; }
            else { txtFilter2.Visible = true; }
        }

        private void bttnCancel_Click(object sender, EventArgs e) { Close(); }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string strFilter = cbFields.Text;

                switch (cbCondition1.Text)
                {
                    case "contains":
                        strFilter = strFilter + " LIKE '%" + txtFilter1.Text + "%'"; break;
                    case "is equal to":
                        strFilter = strFilter + " = '" + txtFilter1.Text + "'"; break;
                    case "not euqal to":
                        strFilter = strFilter + " <> '" + txtFilter1.Text + "'"; break;
                    case "is greater than":
                        strFilter = strFilter + " > '" + txtFilter1.Text + "'"; break;
                    case "is greater than or equal to":
                        strFilter = strFilter + " >= '" + txtFilter1.Text + "'"; break;
                    case "is less than":
                        strFilter = strFilter + " < '" + txtFilter1.Text + "'"; break;
                    case "is less than or equal":
                        strFilter = strFilter + " <= '" + txtFilter1.Text + "'"; break;
                    case "between":
                        strFilter = strFilter + " BETWEEN #" + dtNow1.Value + "# AND #" + dtNow2.Value + "#"; break;
                }

                if (cbCondition2.Text != "")
                {
                    if (optionAND.Checked == true) { strFilter = strFilter + " AND "; }
                    else { strFilter = strFilter + " OR "; }

                    switch (cbCondition2.Text)
                    {
                        case "contains":
                            strFilter = strFilter + " LIKE '%" + txtFilter2.Text + "%'"; break;
                        case "is equal to":
                            strFilter = strFilter + " = '" + txtFilter2.Text + "'"; break;
                        case "not euqal to":
                            strFilter = strFilter + " <> '" + txtFilter2.Text + "'"; break;
                        case "is greater than":
                            strFilter = strFilter + " > '" + txtFilter2.Text + "'"; break;
                        case "is greater than or equal to":
                            strFilter = strFilter + " >= '" + txtFilter2.Text + "'"; break;
                        case "is less than":
                            strFilter = strFilter + " < '" + txtFilter2.Text + "'"; break;
                        case "is less than or equal":
                            strFilter = strFilter + " <= '" + txtFilter2.Text + "'"; break;
                        case "between":
                            strFilter = strFilter + " BETWEEN #" + dtNow3.Value + "# AND #" + dtNow4.Value + "#"; break;
                    }
                }

                if (cbFields.Text == "") { }
                else if (cbCondition1.Text == "") { if (txtFilter1.Text == "") { txtFilter1.Focus(); } }
                else if (txtFilter1.Text == "") { txtFilter1.Focus(); }
                else
                {
                    if (sSelect == "Doctor Records")
                    {
                        frmDoctor.boolSTATUS = false;
                        frmDoctor.sWHERE = "SELECT * FROM tblDoctor WHERE " + strFilter + " ORDER BY CodeDoctor ASC";
                        frmDoctor.publicDoctor.LoadSearch ();
                    }
                    else if (sSelect == "Patients Records")
                    {
                        frmPatient.boolSTATUS = false;
                        frmPatient.sWHERE = "SELECT * FROM tblPatient WHERE " + strFilter + " ORDER BY CodePatient ASC";
                      /// frmPatient.publicPatient.l .LoadSearch();
                    }
                    else if (sSelect == "Test Records")
                    {
                        frmTest.boolSTATUS = false;
                        frmTest.sWHERE = "SELECT * FROM tblTest WHERE " + strFilter + " ORDER BY CodeTest ASC";
                        frmTest.publicTest.LoadSearch();
                    }
                    else if (sSelect == "Insurance Records")
                    {
                        frmInsurance.boolSTATUS = false;
                        frmInsurance.sWHERE = "SELECT * FROM tblInsurance WHERE " + strFilter + " ORDER BY CodeInsurance ASC";
                        frmInsurance.publicInsurance.LoadSearch();
                    }
                    else if (sSelect == "User Records")
                    {
                        frmUsers.boolSTATUS = false;
                        frmUsers.sWHERE = "SELECT * FROM tblUsers WHERE " + strFilter + "";
                        frmUsers.publicUsers.LoadSearch();
                    }

                    Close();
                }
            }
            catch (Exception ex) { sFunctions.setCreateError(ex.Message, AppDomain.CurrentDomain.BaseDirectory + "\\Errors\\", Convert.ToDateTime(DateTime.Now.ToString()).ToString("MMM dd, yy - hh-mm-ss ttttt")); }
        }

    }
}