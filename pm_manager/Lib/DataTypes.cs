using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pm_manager
{
    public enum SlideType
    {
        Song,
        Bible
    };

    public struct Slide
    {
        public string Id { get; set; }
        public string BgSrc { get; set; }
        public SlideType Type { get; set; }
        public string HeaderText { get; set; }
        public string ContentText { get; set; }
    }

}
