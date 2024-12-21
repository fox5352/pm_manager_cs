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

namespace pm_manager.Components
{
    public partial class LyricBtnContainer : UserControl
    {
        private string path;
        private string name;
        public LyricBtnContainer()
        {
            InitializeComponent();
        }

        public void LoadText(string path)
        {
            this.path = path;
            this.name = path.Split('\\').Last().Split('.').First();
            this.LyricBtn.Text = this.name;
        }
        public void set_width(int width)
        {
            this.Width = width;
        }
    }
}
