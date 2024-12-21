using System;
using System.Drawing;
using System.Windows.Forms;

namespace pm_manager
{
    public partial class ImageBox : UserControl
    {
        private readonly PlayListHook playListHook = PlayListHook.Instance;

        private string image;
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
                
                this.image = imagePath;

                Image image = Image.FromFile(imagePath);
                ImageBoxContainer.Image = image;
                ImageBoxContainer.SizeMode = PictureBoxSizeMode.Zoom; // Adjust as needed (e.g., Zoom, CenterImage, etc.)
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void imageBoxContainer_DoubleClick(object sender, EventArgs e) 
        {
            this.playListHook.set_BgSrc(this.image);
        }

    }
}
