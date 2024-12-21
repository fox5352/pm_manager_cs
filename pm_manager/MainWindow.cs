using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using pm_manager.Components;

namespace pm_manager
{
    public partial class MainWindow : Form
    {
        private ViewWindow view;
        private SettingsModel settings;
        private List<string> imagesFolders;

        // tabs data
        private List<string> images = new List<string>();
        private List<string> songs = new List<string>();


        // hooks 
        protected Image DataViewImage;
        private PlayListHook playlistHook = PlayListHook.Instance;
        private DataViewHook dataViewHook = DataViewHook.Instance;

        public MainWindow()
        {
            // BUG: this stays here because visual sudtio keeps removing this from the design file :( this.PreviewPanel = new DataView(true);
            // Window configuration
            InitializeComponent();
            //InitializePreviewPanel();
            this.Size = new Size(1366, 768);
            this.FormBorderStyle = FormBorderStyle.Sizable;
            // settings configuration
            this.settings = new SettingsModel();

            // child Window initialization
            this.view = new ViewWindow();

            // ui components initialization
            this.Render_ImageViewContainer();
            this.Render_LyricViewContainer();
        }

        // helper methods
        private void Get_Images_from_folders()
        {
            this.imagesFolders = this.settings.Get_Settings().ImageFolders;

            foreach (string path in this.imagesFolders) {
                string[] data = new SearchFuncs().Search_dir(SearchTypes.Image,path);

                for (int index = 0; index < data.Length; index++)
                {
                    this.images.Add(data[index]);
                }
            }
        }

        private void Get_Songs_from_folder()
        {
            string songsFolder = this.settings.Get_Settings().LyricsPath;

            string[] data = new SearchFuncs().Search_dir(SearchTypes.Text, songsFolder);

            foreach (string file in data)
            {
                this.songs.Add(file);
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

        // lyric view conttainer
        protected void Render_LyricViewContainer() 
        {
            this.Get_Songs_from_folder();
            this.LyricViewContainer.Controls.Clear();

            int yPosition = 0;
            foreach (string songFilePath in this.songs)
            {
                LyricBtnContainer lyricBtn = new LyricBtnContainer();
                lyricBtn.Location = new Point(0, yPosition);
                lyricBtn.Width = this.LyricViewContainer.ClientSize.Width;
                lyricBtn.Height = 30;
                lyricBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                lyricBtn.LoadText(songFilePath);

                this.LyricViewContainer.Controls.Add(lyricBtn);
                yPosition += lyricBtn.Height + 3; // 3 pixels gap between buttons
            }
        }

        // UI events
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

        private void toggleWindow_Click(object sender, EventArgs e)
        {
            this.Toggle_Window();
            Console.WriteLine("testing");
            Image test = Image.FromFile(this.images[0]);
            this.DataViewImage = test;
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

        // tab methods

        // image view
        private void AddImageBtn_Click(object sender, EventArgs e)
        {
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

        // lyric view
        private void AddLyricBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("sdawda");
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                folderBrowserDialog.Description = "Select a Folder Containing Lyrics";

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFolderPath = folderBrowserDialog.SelectedPath;

                    this.settings.Update_Setting<string>(SettingsFields.LyricsPath, selectedFolderPath);
                    this.Render_LyricViewContainer();
                }
            }
        }
    }
}
