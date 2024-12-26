using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pm_manager.Lib;

namespace pm_manager.Components
{
    public partial class SlideBox : UserControl
    {

        public int? SlideIndex = null;

        private readonly Timer UpdateTimer;
        private int? bufferPlaylistIndex = null;

        private PlayListHook playListHook = PlayListHook.Instance;


        public SlideBox()
        {
            InitializeComponent();

            this.UpdateTimer = new Timer { Interval = 33 };
            this.UpdateTimer.Tick += (sender, e) => this.Update_UI();
            this.UpdateTimer.Start();
        }

        public void set_text(string header, string content)
        {
            this.HeaderText.Text = header;
            this.ContentText.Text = content;
        }

        private void SlideBox_Click(object sender, MouseEventArgs e)
        {
            int? idx = this.playListHook.get_index();

            if (idx == this.SlideIndex)
            {
                this.playListHook.set_index(null);
            }else
            {
                this.playListHook.set_index(this.SlideIndex);
            }
        }

        private void SlideBox_DoubleClick(object sender, MouseEventArgs e) 
        {
        }

        private void Update_UI()
        {
            int? index = this.playListHook.get_index();

            if (index != this.bufferPlaylistIndex)
            {
                if (this.SlideIndex == index)
                {
                    this.BackColor = Color.MediumTurquoise;
                }else
                {
                    this.BackColor = Color.White;
                }
                this.bufferPlaylistIndex = index;
            }
        }
    }
}
