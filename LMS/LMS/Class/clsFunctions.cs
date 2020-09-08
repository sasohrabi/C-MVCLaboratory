using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient ;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using LMS.Forms;


namespace LMS
{
    class clsFunctions
    {
        //CLASS VARIABLES
        clsCommands sCommands = new clsCommands();
        clsVariables sVariables = new clsVariables();

        public clsFunctions()
        {
        }

        public DataSet setReport(DataSet ds, string sSQL, string sTable)
        {
            sCommands.setOledbCommand(ds, sVariables.sOleDbDataAdapter, sSQL, sTable);
            return ds;
        }

        public void setEmptyField(string sField)
        {
            MessageBox.Show(sField + " is empty.Please check it!", clsVariables.sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void setKeyDown(object sender, KeyEventArgs e)
        {
            clsVariables.nonNumberEntered = false;
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back) { clsVariables.nonNumberEntered = true; }
                    if (e.KeyCode == Keys.OemPeriod) { clsVariables.nonNumberEntered = false; }
                    if (e.KeyCode == Keys.Decimal) { clsVariables.nonNumberEntered = false; }
                }
            }
        }

        public void setOledbConnCommand_Open(SqlCommand sCommand)
        {
            clsConnections.setOleDbConnectionState();
            clsVariables.sOleDbConnection.Open();
            sCommand.Connection = clsVariables.sOleDbConnection;
        }

        public void setOledbConnCommand_Close(SqlCommand sCommand)
        {
            sCommand.ExecuteNonQuery();
            sCommand.Parameters.Clear();
            sCommand.Connection.Close();
            clsVariables.sOleDbConnection.Close();
        }

        public void setRecordLogin(string sLogin, string sUserID)
        {
            try
            {
                setOledbConnCommand_Open(sVariables.sOleDbCommand);

                sVariables.sOleDbCommand.CommandText = "INSERT INTO tblLogDetails(Username, Login) VALUES(@Username, @Login)";
                sVariables.sOleDbCommand.Parameters.Add("@Username", SqlDbType.VarChar, 50);
                sVariables.sOleDbCommand.Parameters.Add("@Login", SqlDbType.SmallDateTime);
                sVariables.sOleDbCommand.Parameters["@Username"].Value = sUserID;
                sVariables.sOleDbCommand.Parameters["@Login"].Value = sLogin;

                setOledbConnCommand_Close(sVariables.sOleDbCommand);
            }
            catch (Exception ex) { }
        }

        public void setRecordLogout(string sLogout, string sUserID)
        {

            try
            {
                setOledbConnCommand_Open(sVariables.sOleDbCommand);

                sVariables.sOleDbCommand.CommandText = "UPDATE tblLogDetails SET Logout = @Logout WHERE Username LIKE '" + sUserID + "' AND Logout Is Null";
                sVariables.sOleDbCommand.Parameters.Add("@Logout", SqlDbType.SmallDateTime);
                sVariables.sOleDbCommand.Parameters["@Logout"].Value = sLogout;

                setOledbConnCommand_Close(sVariables.sOleDbCommand);
            }
            catch (Exception ex) { }
        }

        public void setMessageBox(string sMessage, int iWhich)
        {
            switch (iWhich)
            {
                case 1:
                    MessageBox.Show(sMessage, clsVariables.sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show(sMessage, clsVariables.sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case 3:
                    MessageBox.Show(sMessage, clsVariables.sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        public void setWebInfo_Create()
        {
            //DATASET VARIABLES
            DataSet dsDoctor = new DataSet();
            DataSet dsPatient = new DataSet();
            DataSet dsTest = new DataSet();
            DataSet dsInsurance = new DataSet();
            DataSet dsUsers = new DataSet();
            DataSet dsReception = new DataSet();
            DataSet dsResult = new DataSet();

            sCommands.getOleDbRecordCount(dsDoctor, "SELECT * FROM tblDoctor", "tblDoctor");
            sCommands.getOleDbRecordCount(dsPatient, "SELECT * FROM tblPatient", "tblPatient");
            sCommands.getOleDbRecordCount(dsTest, "SELECT * FROM tblTest", "tblTest");
            sCommands.getOleDbRecordCount(dsInsurance, "SELECT * FROM tblInsurance", "tblInsurance");
            sCommands.getOleDbRecordCount(dsUsers, "SELECT * FROM tblUsers", "tblUsers");
            sCommands.getOleDbRecordCount(dsReception, "SELECT * FROM tblReception", "tblReception");
            sCommands.getOleDbRecordCount(dsResult, "SELECT * FROM tblResult", "tblResult");

            FileStream sFileStream = new FileStream(Path.GetTempPath().ToString() + @"laboratoryinfo.htm", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sStreamWriter = new StreamWriter(sFileStream);

            // Write to the file using StreamWriter class 
            sStreamWriter.BaseStream.Seek(0, SeekOrigin.End);
            sStreamWriter.WriteLine("<html>");
            sStreamWriter.WriteLine("<body bgcolor = '#f4f4f4' leftmargin='0' topmargin='10' text='#000000'>");
            sStreamWriter.WriteLine("<marquee behavior='scroll' direction='up' style='font-family:Arial, Helvetica, sans-serif; font-size:10px' scrolldelay='200'>");
            sStreamWriter.WriteLine("<strong>Total Doctors: " + dsDoctor.Tables["tblDoctor"].Rows.Count + " </strong><br><br>");
            sStreamWriter.WriteLine("<strong>Total Patients: " + dsPatient.Tables["tblPatient"].Rows.Count + " </strong><br><br>");
            sStreamWriter.WriteLine("<strong>Total Tests: " + dsTest.Tables["tblTest"].Rows.Count + " </strong><br><br>");
            sStreamWriter.WriteLine("<strong>Total Insurances: " + dsInsurance.Tables["tblInsurance"].Rows.Count + " </strong><br><br>");
            sStreamWriter.WriteLine("<strong>Total Users: " + dsUsers.Tables["tblUsers"].Rows.Count + " </strong><br><br>");
            sStreamWriter.WriteLine("<strong>Total Receptions: " + dsReception.Tables["tblReception"].Rows.Count + " </strong><br><br>");
            sStreamWriter.WriteLine("<strong>Total Results: " + dsResult.Tables["tblResult"].Rows.Count + " </strong><br><br>");
            sStreamWriter.WriteLine("</marquee>");
            sStreamWriter.WriteLine("</body>");
            sStreamWriter.WriteLine("</html>");
            sStreamWriter.Flush();
        }

        public void setWebInfo_Remove() { File.Delete(Path.GetTempPath().ToString() + @"laboratoryinfo.htm"); }

        public void setCreateError(string sErrorMessage, string sLocation, string sFileName)
        {
            try
            {
                MessageBox.Show(sErrorMessage, clsVariables.sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Error);

                FileStream sFileStream = new FileStream(sLocation + sFileName + ".err", FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter sStreamWriter = new StreamWriter(sFileStream);

                // Write to the file using StreamWriter class 
                sStreamWriter.BaseStream.Seek(0, SeekOrigin.End);
                sStreamWriter.WriteLine(sErrorMessage);
                sStreamWriter.Flush();
            }
            catch (Exception ex) { }
        }

        public void setPicImages(PictureBox sPictureBox, int iImage) { sPictureBox.Image = MainMenu.publicMDIParent.i24x24.Images[iImage]; }

        public void setUpdateDelay()
        {
            UpdateDelay sForm = new UpdateDelay();
            sForm.ShowDialog();
        }

        public void setReportViewer(bool boolSTATUS, string sSelect, string sSQL, string sTable)
        {
            ReportViewer.boolSTATUS = boolSTATUS;
            ReportViewer.sSelect = sSelect;
            ReportViewer.sSQL = sSQL;
            ReportViewer.sTable = sTable;

            ReportViewer sForm = new ReportViewer();
            sForm.ShowDialog();
        }

        public void setSearchFilter(Label sLabel, string sSelect)
        {
            sLabel.Text = "Selected Record: NONE";
            SearchFilter.sSelect = sSelect;
            SearchFilter sForm = new SearchFilter();
            sForm.ShowDialog();
        }

        public void setComboList(ComboBox sComboBox, string sSQL, string sTable, string sFieldName)
        {
            DataSet sDataSet = new DataSet();
            SqlDataAdapter sOleDbDataAdapter = new SqlDataAdapter();
            sCommands.setOledbCommand(sDataSet, sOleDbDataAdapter, sSQL, sTable);

            sComboBox.DataSource = sDataSet.Tables[0].DefaultView;
            sComboBox.DisplayMember = sFieldName;
            sComboBox.ValueMember = sFieldName;
        }
        public void setComboList2(ComboBox sComboBox, string sSQL, string sTable, string sFieldName, string sFieldName2)
        {
            DataSet sDataSet = new DataSet();
            SqlDataAdapter sOleDbDataAdapter = new SqlDataAdapter();
            sCommands.setOledbCommand(sDataSet, sOleDbDataAdapter, sSQL, sTable);

            sComboBox.DataSource = sDataSet.Tables[0].DefaultView;
            sComboBox.ValueMember = sFieldName2;
            sComboBox.DisplayMember = sFieldName;
        }



        public void setSelectedItem(Label sLabel, ListView sListView)
        {
            try { sLabel.Text = "Selected Record: " + (sListView.FocusedItem.Index + 1); }
            catch (Exception ex) { }
        }

        public void setRemoveListviewItem(ListView sListView, string sSQL, string sTable, string sSelectedForm)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to delete the selected record?\n\n" + "WARNING: You cannot undo this operation.", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    sCommands.setOledbCommand(sVariables.sDataSet, sVariables.sOleDbDataAdapter, sSQL, sTable);
                    setFocusListviewItems(sListView);
                    setUpdateDelay();
                    if (sSelectedForm == "frmPatient") { frmPatient.publicPatient.setReload(); }
                    else if (sSelectedForm == "frmDoctor") { frmDoctor.publicDoctor.setReload(); }
                    else if (sSelectedForm == "frmInsurance") { frmInsurance.publicInsurance.setReload(); }
                    else if (sSelectedForm == "frmTest") { frmTest.publicTest.setReload(); }
                    MainMenu.publicMDIParent.setWebTotals();
                }
            }
            catch (Exception ex) { setCreateError(ex.Message, AppDomain.CurrentDomain.BaseDirectory + "\\Errors\\", DateTime.Now.ToString()); }
        }

        public void setFocusListviewItems(ListView sListView)
        {
            int lvPosition;
            lvPosition = sListView.FocusedItem.Index;

            if (sListView.Items.Count != 0 && sListView.Items.Count - 1 >= lvPosition)
            {
                sListView.Items[lvPosition].Focused = true;
                sListView.Items[lvPosition].Selected = true;
                sListView.Items[lvPosition].EnsureVisible();
            }
            lvPosition = 0;
        }

        public void setNavigation(int iWhich, string sSQL, ListView sListView, Label sLabel, string sTable, Button bttnFirst, Button bttnPrevious, Button bttnNext, Button bttnLast, DataSet sDataSet, int SubRecord, int iConNum, int iNumField, string sDateFormat)
        {
            switch (iWhich)
            {
                case 1:
                    if (sVariables.iPageCurrent != 1) { setFillRecord(sListView, sLabel, 1, sSQL, sTable, SubRecord, iConNum, bttnFirst, bttnPrevious, bttnNext, bttnLast, sDataSet, iNumField, sDateFormat); }
                    break;
                case 2:
                    if (sVariables.iPageCurrent != sVariables.iPageTotal) { setFillRecord(sListView, sLabel, sVariables.iPageNext, sSQL, sTable, SubRecord, iConNum, bttnFirst, bttnPrevious, bttnNext, bttnLast, sDataSet, iNumField, sDateFormat); }
                    break;
                case 3:
                    if (sVariables.iPageCurrent != 1) { setFillRecord(sListView, sLabel, sVariables.iPagePrevious, sSQL, sTable, SubRecord, iConNum, bttnFirst, bttnPrevious, bttnNext, bttnLast, sDataSet, iNumField, sDateFormat); }
                    break;
                case 4:
                    if (sVariables.iPageCurrent != sVariables.iPageTotal) { setFillRecord(sListView, sLabel, sVariables.iPageTotal, sSQL, sTable, SubRecord, iConNum, bttnFirst, bttnPrevious, bttnNext, bttnLast, sDataSet, iNumField, sDateFormat); }
                    break;
                case 5:
                    setFillRecord(sListView, sLabel, 1, sSQL, sTable, SubRecord, iConNum, bttnFirst, bttnPrevious, bttnNext, bttnLast, sDataSet, iNumField, sDateFormat);
                    break;
            }
        }

        public void setFillRecord(ListView sListView, Label sLabel, int sPage, string sSQL, string sTable, int sSubRecord, int iIcon, Button sButton1, Button sButton2, Button sButton3, Button sButton4, DataSet dsSource, int iNumField, string sDateFormat)
        {
            sCommands.setOledbCommand(sVariables.sDataSet, sVariables.sOleDbDataAdapter, sSQL, sTable);

            int pos_start;
            int pos_end;
            sVariables.iPageCurrent = 1;
            sVariables.iPageNext = 1;
            sVariables.iPagePrevious = 1;
            sVariables.iPageTotal = 1;
            sVariables.iPageCurrent = sPage;

            try
            {
                int sTotal;
                decimal sDecimal = decimal.Divide(sVariables.sDataSet.Tables[sTable].Rows.Count, sSubRecord);
                string sString = sDecimal.ToString();
                string sSubTotal;

                for (int i = 1; i <= sString.Length; i++)
                {
                    try
                    {
                        if (setMiddleStr(sString, i, sString.Length - 1).Equals("."))
                        {
                            sSubTotal = (setLeftStr(sString, i));
                            sTotal = (int.Parse(sSubTotal) + 1);
                            sVariables.iPageTotal = sTotal;
                        }
                        else
                        {
                            sTotal = int.Parse(sDecimal.ToString());
                            sVariables.iPageTotal = sTotal;
                        }
                    }
                    catch (Exception ex)
                    {
                        sSubTotal = (setLeftStr(sString, i));
                        sTotal = (int.Parse(sSubTotal) + 1);
                        sVariables.iPageTotal = sTotal;
                        // MessageBox.Show(ex.message);
                    }

                }
            }
            catch (Exception ex) { }

            if (sVariables.iPageTotal > sVariables.iPageCurrent) { sVariables.iPageNext = sVariables.iPageCurrent + 1; }
            else if (sVariables.iPageCurrent > 1) { sVariables.iPagePrevious = sVariables.iPageCurrent - 1; }

            if (sVariables.iPageTotal <= 1)
            {
                pos_start = 1;
                pos_end = sVariables.sDataSet.Tables[sTable].Rows.Count;
                sButton1.Enabled = false;
                sButton2.Enabled = false;
                sButton3.Enabled = false;
                sButton4.Enabled = false;
            }
            else if (sVariables.iPageCurrent == 1)
            {
                pos_start = 1;
                pos_end = sSubRecord;
                sButton1.Enabled = false;
                sButton2.Enabled = false;
                sButton3.Enabled = true;
                sButton4.Enabled = true;
            }
            else if (sVariables.iPageCurrent == sVariables.iPageTotal && sVariables.iPageCurrent > 1)
            {
                pos_start = ((sVariables.iPageCurrent - 1) * sSubRecord) + 1;
                pos_end = sVariables.sDataSet.Tables[sTable].Rows.Count;
                sButton1.Enabled = true;
                sButton2.Enabled = true;
                sButton3.Enabled = false;
                sButton4.Enabled = false;
            }
            else
            {
                pos_start = ((sVariables.iPageCurrent - 1) * sSubRecord) + 1;
                pos_end = (sVariables.iPageNext - 1) * sSubRecord;
                sButton1.Enabled = true;
                sButton2.Enabled = true;
                sButton3.Enabled = true;
                sButton4.Enabled = true;
            }

            setListview(sListView, sSQL, sTable, pos_start, pos_end, iIcon, dsSource, iNumField, sDateFormat);
            setTrackList(sListView, sLabel, sSubRecord, sVariables.sDataSet.Tables[sTable].Rows.Count);
            pos_start = 0;
            pos_end = 0;
        }

        public void setListview(ListView sListView, string sSQL, string sTable, int iStart, int iEnd, int iIcon, DataSet dsSource, int iNumField, string sDateFormat)
        {

            int totalRow = 1;

            dsSource.Clear();
            sVariables.sOleDbDataAdapter.Dispose();
            sCommands.setOledbCommand(dsSource, sVariables.sOleDbDataAdapter, sSQL, sTable);

            totalRow = dsSource.Tables[sTable].Rows.Count;
            sListView.Items.Clear();

            iStart = iStart - 1;



            for (int x = iStart; x <= iEnd - 1; x++)
            {
                sListView.Items.Add(new ListViewItem("" + dsSource.Tables[sTable].Rows[x].ItemArray.GetValue(0).ToString(), iIcon));
                if (iNumField != 0)
                {
                    try
                    {

                        for (int a = 1; a <= iNumField; a++)
                        {

                            int n = iStart;

                            sListView.Items[x - n].SubItems.Add("" + dsSource.Tables[sTable].Rows[x].ItemArray.GetValue(a).ToString());

                        }
                    }
                    catch (Exception ex) { }//Index was outside the bounds of the array.
                }

            }
        }

        private void setTrackList(ListView sListView, Label sLabel, int iEnd, long TotalRecords)
        {
            if (sVariables.iPageTotal == 1) { sLabel.Text = "Results: " + (sListView.SelectedItems.Count + 1) + " - " + sListView.Items.Count.ToString() + " of about " + TotalRecords; }
            else if (sVariables.iPageCurrent == 1) { sLabel.Text = "Results: " + (sListView.SelectedItems.Count + 1) + " - " + sListView.Items.Count.ToString() + " of about " + TotalRecords; }
            else if (sVariables.iPageCurrent == sVariables.iPageTotal && sVariables.iPageCurrent > 1) { sLabel.Text = "Results: " + (((sVariables.iPageCurrent - 1) * iEnd) + (sListView.SelectedItems.Count + 1)) + " - " + TotalRecords + " of about " + TotalRecords; }
            else { sLabel.Text = "Results: " + (((sVariables.iPageCurrent - 1) * iEnd) + (sListView.SelectedItems.Count + 1)) + " - " + (((sVariables.iPageCurrent - 1) * iEnd) + iEnd) + " of about " + TotalRecords; }
        }

        private string setLeftStr(string source, int pos)
        {
            int i;
            string temp = "";
            for (i = 0; i < pos; i++) { temp += source[i]; }
            return temp;
        }

        private string setMiddleStr(string source, int start, int stop)
        {
            int i;
            string temp = "";
            for (i = start; i < stop; i++) { temp += source[i]; }
            return temp;
        }
    }
}
