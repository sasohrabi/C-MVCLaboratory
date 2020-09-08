using System;
using System.IO;
using System.Windows.Forms;

namespace LMS
{
    class clsSettings : clsVariables
    {
        public static bool setPrevInstance()
        {
            try
            {
                if (System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length > 1) { return true; }
                else { return false; }
            }
            catch (Exception ex) { return false; }
        }

        public static void setListview(ListView sListView, String sCaption, Byte sIcon, ImageList sImageList)
        {
            sListView.Width = 250;
            sListView.LargeImageList = sImageList;
            sListView.SmallImageList = sImageList;
            sListView.Items.Add(new ListViewItem(sCaption, sIcon));
        }

        public static void setMDIChild(Form sMDIChild, Form sMDIParent)
        {
            sMDIChild.MdiParent = sMDIParent;
            sMDIChild.Show();
            sMDIChild.Activate();
        }

        public static void setCreateDirectory(string sFolder, string sLocation)
        {
            try { if (Directory.Exists(sLocation + "\\" + sFolder) == false) { Directory.CreateDirectory(sLocation + "\\" + sFolder); } }
            catch (Exception ex) { }
        }

        public static void setRemoveDirectory(string sFolder, string sLocation)
        {
            try { if (Directory.Exists(sLocation + "\\" + sFolder) == true) { Directory.Delete(sLocation + "\\" + sFolder); } }
            catch (Exception ex) { }
        }

        public static void setCreateFile(PictureBox sPictureBox, string sFile, string sLocation)
        {
            try { if (File.Exists(sLocation + sFile) == false) { sPictureBox.Image.Save(sLocation + "\\" + sFile); } }
            catch (Exception ex) { }
        }

        public static void setRemoveFile(string sFile, string sLocation)
        {
            try { if (File.Exists(sLocation + sFile) == true) { File.Delete(sLocation + sFile); } }
            catch (Exception ex) { }
        }

        public static void setComponent(string sShell, string sComponent)
        {
            try { System.Diagnostics.Process.Start(sShell); }
            catch (Exception ex) { MessageBox.Show("No " + sComponent + " installed in the system.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public static void setRemovePic(PictureBox sPictureBox)
        {
            try
            {
                sPictureBox.Image.Dispose();
                sPictureBox.Image = null;
            }
            catch (Exception ex) { }
        }
    }
}
