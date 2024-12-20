using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace pm_manager
{

    public struct Playlist
    {
        public int Index { get; set; }
        public List<Slide> Slides { get; set; }
    }

    public sealed class PlayListHook
    {
        private static readonly Lazy<PlayListHook> _instance = new Lazy<PlayListHook>(() => new PlayListHook());

        public static PlayListHook Instance => _instance.Value;

        private Playlist playlist;

        private  PlayListHook()
        {
            this.playlist = new Playlist()
            {
                Slides = new List<Slide>()
            };
        }

        public int? get_index()
        {

            return this.playlist.Index;
        }
        public void set_index(int index)
        {
            if (this.playlist.Slides.Count - 1 > index)
            {
                this.playlist.Index = index;
            }
        }
        public void add_Slide(Slide slide)
        {
            if (this.get_slide(slide.Id) != null)
            {
                return;
            }

            this.playlist.Slides.Add(slide);
        }

        public Slide? get_slide(int index)
        {
            if (this.playlist.Slides.Count > index) {
                return this.playlist.Slides[index];
            }else
            {
                return null;
            }
        }

        public Slide? get_slide(string id)
        {
            foreach (Slide slide in this.playlist.Slides)
            {
                if (id == slide.Id)
                {
                    return slide;
                }
            }
            return null;
        }

        // TODO: add slide update at some point
        public void delete_slide(int index)
        {
            this.playlist.Slides.RemoveAt(index);
        }

        public void delete_slide(string id)
        {
            this.playlist.Slides.RemoveAll((slide) => slide.Id == id);
        }
    }
}
