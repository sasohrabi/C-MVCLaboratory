using System;
using System.Data;

namespace LMS
{
    class clsConnections : clsVariables //Get the Static Variables in the Class clsVariables
    {
        public static string setConnectionString()
        {
            return @"Data Source=localhost;Initial Catalog=LABORATORY_DB;Integrated Security=True";
        }

        public static void setOleDbConnectionState()//For Oledb Connection
        {
            if (sOleDbConnection.State == ConnectionState.Open) sOleDbConnection.Close();
            sOleDbConnection.ConnectionString = setConnectionString();
        }
    }
}
