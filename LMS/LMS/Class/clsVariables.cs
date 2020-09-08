using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LMS
{
    class clsVariables
    {
        //OLEDB VARIABLES
        public static SqlConnection sOleDbConnection = new SqlConnection();
        public SqlDataAdapter sOleDbDataAdapter = new SqlDataAdapter();
        public SqlCommand sOleDbCommand = new SqlCommand();
        public static SqlDataReader sOleDbDataReader;

        //DATASET VARIABLES
        public DataSet sDataSet = new DataSet();


        //INTEGER VARIABLES
        public int iPageCurrent;
        public int iPageNext;
        public int iPagePrevious;
        public int iPageTotal;
        public int iSeconds = 10;
        public int iTimerCount = 0;

        //LONG VARIABLES
        public long sImageFileLength = 0;

        //BYTE VARIABLES
        public static byte[] sBarrImg;

        //STRING VARIABLES
        public static string sMessageBox = "[ MAGIC LABORATORY ver. 1.0 ]";
        public static string sUsername;
        public static string sUserFullname;
        public static string sUserLogin;
        public static string sUserLogout;
        public static string sUserType;
        public static string sCompanyName;
        public static string sContactName;
        public static string sCompanyAddress;
        public static string sPhoneNumber;
        public static string sFaxNumber;
        public static string sEmailAddress;
        public static string sWebAddress;

        //BOOLEAN VARIABLES
        public static bool boolConnected = false;
        public static bool nonNumberEntered = false;

        //FILE DIALOG VARIABLES
        public OpenFileDialog openIMG = new OpenFileDialog();
        public SaveFileDialog saveIMG = new SaveFileDialog();


    }
}
