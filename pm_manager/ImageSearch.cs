using System;
using System.IO;
using System.Linq;

namespace pm_manager
{
    public class ImageSearch
    {
        public string[] Get_Images_Paths(string path)
        {
            // Get all image files in the specified directory, excluding subdirectories
            string[] imageFiles = Directory.GetFiles(path, "*.jpg"); // Adjust the pattern as needed (e.g., "*.png", "*.gif", etc.)

            return imageFiles;
        }
    }
}
