using System;
using System.Windows.Forms;

namespace pm_manager.Lib
{
    internal class ClickManager
    {
        private System.Timers.Timer ClickTimer;
        private bool IsDoubleClick = false;
        
        Action<object, MouseEventArgs> Click;
        Action<object, MouseEventArgs> DBClick;

        private object sender;
        private MouseEventArgs e;

        public ClickManager(Action<object, MouseEventArgs> Click, Action<object, MouseEventArgs> DBClick,int delay=200)
        {
            this.ClickTimer = new System.Timers.Timer() { Interval = delay };
            this.ClickTimer.Elapsed += this.ClickTimer_Tick;
            this.Click = Click;
            this.DBClick = DBClick;
        }

        public void MouseDown(object sender, MouseEventArgs e)
        {
            if (!this.ClickTimer.Enabled)
            {
                this.ClickTimer.Start();
                this.sender = sender;
                this.e = e;
            }else
            {
                this.IsDoubleClick = true;
            }
        }

        private void ClickTimer_Tick(object sender, EventArgs e)
        {
           this.ClickTimer.Stop(); // Stop the timer after the delay

            if (this.IsDoubleClick)
            {
                this.DBClick(this.sender, this.e);
            }else
            {
                this.Click(this.sender, this.e);
            }
            this.IsDoubleClick = false;
        }
    }
}
