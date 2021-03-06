using System;
using System.Windows.Forms;

namespace LMS
{
    public partial class LogDetails : Form
    {
        public LogDetails(){InitializeComponent();}

        //CLASS VARIABLES
        clsCommands sCommands = new clsCommands();
        clsFunctions sFunctions = new clsFunctions();
        clsVariables sVariables = new clsVariables();

        private void LogDetails_Load(object sender, EventArgs e)
        {
            //Buttons
            bttnOK.Image = MainMenu.publicMDIParent.i32x32.Images[18];
            bttnCancel.Image = MainMenu.publicMDIParent.i32x32.Images[6];

            txtYear.Text = DateTime.Now.Year.ToString();

            cbMonth.Items.Add("January");
            cbMonth.Items.Add("February");
            cbMonth.Items.Add("March");
            cbMonth.Items.Add("April");
            cbMonth.Items.Add("May");
            cbMonth.Items.Add("June");
            cbMonth.Items.Add("July");
            cbMonth.Items.Add("August");
            cbMonth.Items.Add("September");
            cbMonth.Items.Add("October");
            cbMonth.Items.Add("November");
            cbMonth.Items.Add("December");
        }

        private void cbMonth_KeyPress(object sender, KeyPressEventArgs e) { e.Handled = true; }

        private void txtYear_KeyDown(object sender, KeyEventArgs e) { sFunctions.setKeyDown(sender, e); }

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e) { if (clsVariables.nonNumberEntered == true) { e.Handled = true; } }

        private void bttnCancel_Click(object sender, EventArgs e){Close();}

        private void bttnOK_Click(object sender, EventArgs e)
        {
            if (txtYear.Text.Length != 4){sFunctions.setMessageBox("سال واردشده نامعتبر است. لطفا سال را دوباره وارد کنید.", 3);}
            else if (month_value(cbMonth.Text) == 0) { sFunctions.setMessageBox("مورد انتخابی نا معتبر است. لطفا دوباره ماه را وارد کنید.", 3); }
            else
            {
                if (optionClear.Checked == true)
                {
                    if (MessageBox.Show("رکورد انتخابی برای همیشه حذف میشود. آیا میخواهید ادامه دهید?", "حذف رکورد", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                    {
                        sCommands.setOledbCommand(sVariables.sDataSet, sVariables.sOleDbDataAdapter, "DELETE FROM tblLogDetails WHERE (((Format([tblLogDetails.Login],'mmmm'))='" + cbMonth.Text + "') AND ((Format([tblLogDetails.Login],'yyyy'))=" + txtYear.Text + "))", "tblLogDetails");
                        sFunctions.setUpdateDelay();
                        sFunctions.setMessageBox("رکورد با موفقیت حذف شد.", 1);
                    }
                }
                else
                {
                    if (MessageBox.Show("PRINTING OPTION: Press the following \n\n----------------------------------------------------------------\n\n YES to load Crystal Report Viewer\n NO to load RDLC Report Viewer\n\n----------------------------------------------------------------\n ", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        sFunctions.setReportViewer(false, "CRPT Log Details", "SELECT * FROM tblLogDetails", "tblLogDetails");
                    }
                    else
                    {
 
                    }
                }
            }
        }

        public static int month_value(string sMonth)
        {
            int month_value = 0;
            switch (sMonth)
            {
                case "January": month_value = 1; break;
                case "February": month_value = 2; break;
                case "March": month_value = 3; break;
                case "April": month_value = 4; break;
                case "May": month_value = 5; break;
                case "June": month_value = 6; break;
                case "July": month_value = 7; break;
                case "August": month_value = 8; break;
                case "September": month_value = 9; break;
                case "October": month_value = 10; break;
                case "November": month_value = 11; break;
                case "December": month_value = 12; break;
            }
            return month_value;
        }
    }
}