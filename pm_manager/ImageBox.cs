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
    public partial class ImageBox : UserControl
    {
        public ImageBox()
        {
            InitializeComponent();
        }

        public void LoadImage(string imagePath)
        {
            try
            {
                if (string.IsNullOrEmpty(imagePath))
                {
                    throw new ArgumentException("Image path cannot be null or empty.", nameof(imagePath));
                }

                Image image = Image.FromFile(imagePath);
                ImageBoxContainer.Image = image;
                ImageBoxContainer.SizeMode = PictureBoxSizeMode.Zoom; // Adjust as needed (e.g., Zoom, CenterImage, etc.)
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
