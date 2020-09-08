using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace LMS.Controls
{
    public partial class ctrlLineHorizontal : UserControl
    {
        public ctrlLineHorizontal() { InitializeComponent(); }

        private void ctrlLineHorizontal_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.FromName("ControlDark")), this.Width, 0, 0, 0);
            e.Graphics.DrawLine(new Pen(Color.FromName("ControlLightLight")), this.Width, 1, 0, 1);
        }

        private void ctrlLineHorizontal_Resize(object sender, EventArgs e) { Height = 2; }

        private void ctrlLineHorizontal_Load(object sender, EventArgs e)
        {

        }
    }
}
