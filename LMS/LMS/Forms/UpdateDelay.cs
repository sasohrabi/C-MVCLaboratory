using System;
using System.Windows.Forms;

namespace LMS
{
    public partial class UpdateDelay : Form
    {
        public UpdateDelay(){InitializeComponent();}

        //CLASS VARIABLES
        clsFunctions sFunctions = new clsFunctions();
        clsVariables sVariables = new clsVariables();

        private void UpdateDelay_Load(object sender, EventArgs e)
        {
            try
            {
                sFunctions.setPicImages(picHourGlass, 6);

                pbUpdate.Minimum = 1;
                pbUpdate.Maximum = sVariables.iSeconds;
                timerDelay.Enabled = true;
            }
            catch (Exception ex) { }
        }

        private void timerDelay_Tick(object sender, EventArgs e)
        {
            if (sVariables.iTimerCount == sVariables.iSeconds)
            {
                timerDelay.Enabled = false;
                Close();
            }
            else
            {
                sVariables.iTimerCount = sVariables.iTimerCount + 1;
                pbUpdate.Value = sVariables.iTimerCount;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sFunctions.setPicImages(picHourGlass, 6);
            timer1.Enabled = !timer1.Enabled;
            timer2.Enabled = !timer2.Enabled;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            sFunctions.setPicImages(picHourGlass, 7);
            timer2.Enabled = !timer2.Enabled;
            timer3.Enabled = !timer3.Enabled;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            sFunctions.setPicImages(picHourGlass, 8);
            timer3.Enabled = !timer3.Enabled;
            timer4.Enabled = !timer4.Enabled;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            sFunctions.setPicImages(picHourGlass, 9);
            timer4.Enabled = !timer4.Enabled;
            timer1.Enabled = !timer1.Enabled;
        }

    }
}