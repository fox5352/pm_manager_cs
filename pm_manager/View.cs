using System;
using System.Drawing;
using System.Windows.Forms;

namespace pm_manager
{
    public partial class ViewWindow : Form
    {
        public ViewWindow()
        {
            InitializeComponent();
            this.Size = new Size(1366, 768);
            this.FormBorderStyle = FormBorderStyle.Sizable;
        }
    }
}
