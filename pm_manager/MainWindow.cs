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
    public partial class MainWindow : Form
    {
        private ViewWindow view;
        public MainWindow()
        {
            InitializeComponent();
            this.Size = new Size(1366, 768);
            this.FormBorderStyle = FormBorderStyle.Sizable;

            this.view = new ViewWindow();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void controls_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Toggle_Window()
        {
            if (this.view.IsDisposed)
            {
                this.view = new ViewWindow();
                this.view.Show();

                viewToggleBtn.Text = "Close view";
                return;
            }

            if (!this.view.Visible)
            {
                this.view.Show();
                viewToggleBtn.Text = "Close view";
                return;
            }

            if (!this.view.IsDisposed && this.view.Visible)
            {
                this.view.Hide();
                viewToggleBtn.Text = "Open view";
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Toggle_Window();
        }
    }
}
