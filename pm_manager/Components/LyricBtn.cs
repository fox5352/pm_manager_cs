using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using pm_manager.Lib;

namespace pm_manager.Components
{
    public partial class LyricBtnContainer : Button
    {
        private string path;
        private string name;

        private readonly PlayListHook playListHook = PlayListHook.Instance;

        private ClickManager ClickManager;

        public LyricBtnContainer()
        {
            this.ClickManager = new ClickManager(this.LyricBtn_Click, this.LyricBtn_DoubleClick, 150);
            InitializeComponent();
        }

        private List<Slide> slides = new List<Slide>();
        public void LoadText(string path)
        {
            this.path = path;
            this.name = path.Split('\\').Last().Split('.').First();
            this.Text = this.name;
            this.Load_file();

        }

        private void Load_file()
        {
            string fileData = File.ReadAllText(this.path);

            fileData = fileData.Replace("\r\n", "\n");
            string[] lyricSlides = fileData.Split(new[] { "\n\n" }, StringSplitOptions.None);

            foreach (var slide in lyricSlides)
            {
                Slide temp = new Slide()
                {
                    HeaderText = this.name,
                    ContentText = slide,
                };

                this.slides.Add(temp);
            }
        }

        private void LyricBtn_Click(object sender, MouseEventArgs e) 
        {
            Console.WriteLine("Singal Click");
        }
        private void LyricBtn_DoubleClick(object sender, MouseEventArgs e) 
        {
            Console.WriteLine("Double Click");
        }


        // TODO: add on drag event for this comp
    }
}
