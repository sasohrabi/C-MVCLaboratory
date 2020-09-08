using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace LMS
{
    public partial class ReportViewer : Form
    {
       public ReportViewer(){InitializeComponent();}

       //CLASS VARIABLES
       clsCommands sCommands = new clsCommands();
       clsFunctions sFunctions = new clsFunctions();
       clsVariables sVariables = new clsVariables();

       //STRING VARIABLES
       public static string sSelect;
       public static string sSQL;
       public static string sTable;
       public static string sDataSource;
       public static string sReport;
       //public static string sPayrollPeriod;
       //public static string sFullname;
       string sSQLPeriods;

       //BOOLEAN VARIABLES
       public static bool boolSTATUS;
       public static bool boolREPORT;

           private void ReportViewer_Load(object sender, EventArgs e)
           {

               if (boolSTATUS == true)//LOAD RDLC REPORT
               {
                   rdlcviewer.Dock = DockStyle.Fill;
                   rdlcviewer.Visible = true;
                   Text = "RDLC Report Viewer";
               }
               else//LOAD CRYSTAL REPORT
               {
                   crystalviewer.Dock = DockStyle.Fill;
                   crystalviewer.Visible = true;
                   if (sSelect == "CRPT Test Records") { setReportTest();  }
                   else if (sSelect == "CRPT Reception Records") { setReportReception(); }
                   else if (sSelect == "CRPT Result Records") { setReportResult(); }
                   else if (sSelect == "CRPT Log Details") { setLogDetails(); }

                   Text = "CRYSTAL Report Viewer";
               }
           }



           private void setReportTest()
           {
               LABORATORY_DBDataSet dsReport = new LABORATORY_DBDataSet();

               DataSet ds = sFunctions.setReport(dsReport, sSQL, sTable);
               crptTest rptViewer = new crptTest();

               rptViewer.SetDataSource(ds);
               crystalviewer.ReportSource = rptViewer;
             
  
           }

        private void setReportReception()
        {

            LABORATORY_DBDataSet dsReport = new LABORATORY_DBDataSet();

            DataSet ds = sFunctions.setReport(dsReport, sSQL, sTable);
            rptReception rptViewer = new rptReception();

            rptViewer.SetDataSource(ds);
            crystalviewer.ReportSource = rptViewer;

        }

        private void setReportResult()
        {

            LABORATORY_DBDataSet dsReport = new LABORATORY_DBDataSet();

            DataSet ds = sFunctions.setReport(dsReport, sSQL, sTable);
            crptResult rptViewer = new crptResult();

            rptViewer.SetDataSource(ds);
            crystalviewer.ReportSource = rptViewer;

        }

        private void setLogDetails()
        {

            LABORATORY_DBDataSet dsReport = new LABORATORY_DBDataSet();

            DataSet ds = sFunctions.setReport(dsReport, sSQL, sTable);
            crptLogDetails rptViewer = new crptLogDetails();

            rptViewer.SetDataSource(ds);
            crystalviewer.ReportSource = rptViewer;

        }
    }
}