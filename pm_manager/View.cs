using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public void UpdateView(string data) {
            System.Console.WriteLine(data);
        }
    }
}
