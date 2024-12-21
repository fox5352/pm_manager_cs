using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace pm_manager
{
    public partial class MainWindow : Form
    {
        private ViewWindow view;
        private SettingsModel settings;
        private List<string> imagesFolders;

        private List<string> images = new List<string>();

        private PlayListHook playlistHook = PlayListHook.Instance;
        private DataViewHook dataViewHook = DataViewHook.Instance;

        // hooks 
        protected Image DataViewImage;

        public MainWindow()
        {
            // Window configuration
            InitializeComponent();
            this.Size = new Size(1366, 768);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            // settings configuration
            this.settings = new SettingsModel();

            // child Window initialization
            this.view = new ViewWindow();

            // ui components initialization
            this.Render_ImageViewContainer();
        }

        // helper methods
        protected void Get_Images_from_folders()
        {
            this.imagesFolders = this.settings.Get_Settings().ImageFolders;
            ImageSearch search_helper = new ImageSearch();

            foreach (string path in this.imagesFolders) {
                string[] data = search_helper.Get_Images_Paths(path);

                foreach(string item in data)
                {
                    this.images.Add(item);
                }
            }
        }

        // ui methods

        // tab view components

        // image view container
        protected void Render_ImageViewContainer()
        {
            this.Get_Images_from_folders();
            this.ImagesViewContainer.Controls.Clear();

            foreach (var imagePath in this.images)
            {
                ImageBox imageBox = new ImageBox
                {
                    Size = new Size(180, 130),
                    Margin = new Padding(13)
                };

                imageBox.LoadImage(imagePath);

                this.ImagesViewContainer.Controls.Add(imageBox);
            }
        }

        // UI events
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
            Console.WriteLine("testing");
            Image test = Image.FromFile(this.images[0]);
            this.DataViewImage = test;
        }

        private void AddImageBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Help !");
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a Folder Containing Images";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;
                    this.imagesFolders.Add(selectedFolderPath);

                    this.settings.Update_Setting<List<string>>(SettingsFields.ImageFolders, this.imagesFolders);
                    this.Render_ImageViewContainer();
                }
            }

        }

        private void LiveToggleBtn_Click(object sender, EventArgs e)
        {
            bool current = this.dataViewHook.toggle_isLive();
            if (current)
            {
                this.LiveToggleBtn.ForeColor = Color.White;
                this.LiveToggleBtn.BackColor = Color.Crimson;
            }else
            {
                this.LiveToggleBtn.ForeColor = Color.Black;
                this.LiveToggleBtn.BackColor = Color.Gainsboro;
            }
        }
    }
}
