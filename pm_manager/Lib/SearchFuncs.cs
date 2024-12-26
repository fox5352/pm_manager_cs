using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace pm_manager
{

    public enum SearchTypes {
        Image,
        Text,
    }

    public class SearchFuncs
    {
        private readonly Dictionary<SearchTypes, string[]> extensions = new Dictionary<SearchTypes, string[]>() {
            { SearchTypes.Image, new[] { ".jpg", ".jpeg", ".png" } },
            { SearchTypes.Text, new[] {".txt"} }
        };

        public string[] Search_dir(SearchTypes type, string path) 
        {
            string[] extensions = this.extensions[type];



            string[] data = Directory.GetFiles(path, "*", SearchOption.AllDirectories)
                 .Where(file => extensions.Any(ext => file.EndsWith(ext, StringComparison.OrdinalIgnoreCase)))
                        .ToArray();

            return data;
        }
    }
}
