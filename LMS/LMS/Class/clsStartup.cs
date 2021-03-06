using System;
using System.Windows.Forms;

namespace LMS
{
    static class clsStartup
    {
        [STAThread]
        static void Main()
        {
            if (clsSettings.setPrevInstance() == false)
            {
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new LoginScreen());//Load the Login- Screen.
                    if (clsVariables.boolConnected == true) { Application.Run(new MainMenu()); }//Load the Main Form.
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, clsVariables.sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            }
            else { MessageBox.Show("این برنامه اکنون در حال اجراست.", clsVariables.sMessageBox, MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }
    }
}
