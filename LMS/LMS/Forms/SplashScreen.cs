using System;
using System.Windows.Forms;

namespace LMS
{
    public partial class SplashScreen : Form
    {
        public SplashScreen(){InitializeComponent();}

        private void SplashScreen_Load(object sender, EventArgs e){}

        private void picSplash_Click(object sender, EventArgs e){Close();}

        private void timer1_Tick(object sender, EventArgs e) { Close(); }
    }
}