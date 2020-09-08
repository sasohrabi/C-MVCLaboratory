using System;
using System.Data;
using System.Data.SqlClient ;

namespace LMS
{
    class clsCommands : clsVariables //Get the Static Variables in the Class clsVariables
    {
        public void setOledbCommand(DataSet dsFill, SqlDataAdapter  daFill, string sSQL, string sTable)
        {
            clsConnections.setOleDbConnectionState();
            daFill.SelectCommand = new SqlCommand(sSQL, sOleDbConnection);
            dsFill.Clear();
            daFill.Fill(dsFill, sTable);
        }

        public void setOledbCommandReader(string sSQL)
        {
            clsConnections.setOleDbConnectionState();
            sOleDbConnection.Open();
            sOleDbCommand.Connection = sOleDbConnection;
            sOleDbCommand.CommandText = sSQL;
            sOleDbDataReader = sOleDbCommand.ExecuteReader();
        }

        //Get the Record Count of every Table.
        public void getOleDbRecordCount(DataSet dsFill, string sSQL, string sTable)
        {
            clsConnections.setOleDbConnectionState();
            sOleDbDataAdapter.SelectCommand = new SqlCommand(sSQL, sOleDbConnection);
            dsFill.Clear();
            sOleDbDataAdapter.Fill(dsFill, sTable);
        }

        public void getOleDbCommand(string sSQL)
        {
            //Set Connection
            clsConnections.setOleDbConnectionState();
            sOleDbConnection.Open();
            sOleDbCommand.Connection = sOleDbConnection;
            sOleDbCommand.CommandText = sSQL;
            sOleDbCommand.ExecuteNonQuery();
            sOleDbConnection.Close();
        }
    }
}
