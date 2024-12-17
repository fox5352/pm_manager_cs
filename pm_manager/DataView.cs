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

namespace pm_manager
{
    public partial class DataView : UserControl
    {
        public Image DataViewBackgroundImage { get; set; }
        public string HeaderText { get; set; }

        public string ContentText { get; set; }

        private Label HeaderLabel;
        private Label ContentLabel;

        public void ImageWithHeaderContainer() {
            this.BackgroundImage = null;
            this.HeaderText = "Header Text";
            this.ContentText = "Content Text";

            this.HeaderLabel = new Label
            {
                Font = new Font("Microsoft Sans Serif", 19),
                ForeColor = Color.White,
                AutoSize = true,
                TextAlign = ContentAlignment.TopLeft,
                Dock = DockStyle.Top,
                Height = 40
            };

            this.ContentLabel = new Label
            {
                Font = new Font("Microsoft Sans Serif", 14),
                ForeColor = Color.White,
                AutoSize = true,
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };
        }

        public DataView()
        {
            InitializeComponent();
        }
    }
}
