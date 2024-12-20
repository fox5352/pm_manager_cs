using System;
using System.Drawing;
using System.Windows.Forms;

namespace pm_manager
{
    public partial class DataView : UserControl
    {
        private readonly Timer UpdateTimer;

        private readonly bool preview;

        private DataViewHook dataViewHook = DataViewHook.Instance;

        public DataView(bool preViewPanel=false)
        {
            this.preview = preViewPanel;
            this.InitializeComponent();
            this.UpdateLayout();

            this.UpdateTimer = new Timer { Interval = 33 };
            this.UpdateTimer.Tick += (sender, e) => this.Update_UI();
            this.UpdateTimer.Start();
        }

        private void DataView_Resize(object sender, EventArgs e)
        {
            this.UpdateLayout();
        }

        private void UpdateLayout()
        {
            // Update header height (40% of container)
            HeaderLabel.Height = (int)(this.Height * 0.1);
            // ContentLabel will automatically fill remaining space due to Dock = Fill
        }

        
        private void label1_Click(object sender, EventArgs e)
        {
        }

        // updating functions
        public void Set_HeaderText(string text)
        {
            this.HeaderLabel.Text = text;
        }
        public void Set_ContentText(string text)
        {
            this.ContentLabel.Text = text;
        }
        // public
        public void Set_FG_Color(Color color)
        {
            this.HeaderLabel.ForeColor = color;
            this.ContentLabel.ForeColor = color;
        }

        public void Set_Background_Image(string src)
        {
            try
            {
                // Load the image from the provided source path
                var image = Image.FromFile(src);

                // Set the image as the background
                this.BackgroundImage = image;

                // Optional: Set the background image layout to "Stretch" to fit the control
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                // Handle potential errors (e.g., file not found, invalid format)
                MessageBox.Show($"Error loading image: {ex.Message}");
            }
        }

        public void Set_Slide(Slide slide) {
            if (slide.HeaderText != null)
            {
                this.Set_HeaderText(slide.HeaderText);
            }
            if (slide.ContentText != null)
            {
                this.Set_ContentText(slide.ContentText);
            }
            if (slide.BgSrc != null)
            {
                this.Set_Background_Image(slide.BgSrc);
            }
        }

        private void Update_UI()
        {
            if (this.preview || this.dataViewHook.get_isLive())
            {

            }
        }
    }
}
