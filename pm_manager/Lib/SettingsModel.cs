using System.IO;
using System.Collections.Generic;

using Newtonsoft.Json;
using System;

namespace pm_manager
{

    public struct Settings
    {
        public List<string> ImageFolders { get; set; }
        public string BiblesPath { get; set; }
        public string LyricsPath { get; set; }
    }

    public enum SettingsFields {
        ImageFolders,
        BiblePath,
        LyricsPath
    }

    public class SettingsModel
    {
        private readonly string settingsPath = "./settings.json";
        private Settings settings;

        public SettingsModel()
        {
            this.settings = this.Get_Settings();
        }

        protected string Read_File()
        {
            try
            {
                string fileData = File.ReadAllText(this.settingsPath);

                return fileData;
            }
            catch (FileNotFoundException)
            {
                Settings settings = new Settings { LyricsPath = "./", BiblesPath ="./", ImageFolders = new List<string> { "./" } };

                return JsonConvert.SerializeObject(settings);
            }
        }

        protected bool Write_file(string data)
        {
            try
            {
                File.WriteAllText(this.settingsPath, data);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing file: " + ex.Message);
                return false;
            }
        }

        protected bool Save_Settings()
        {
            string stringSettings = JsonConvert.SerializeObject(this.settings);

            return this.Write_file(stringSettings);
        }

        public Settings Get_Settings()
        {
            string data = this.Read_File();

            Settings settings = JsonConvert.DeserializeObject<Settings>(data);
            this.settings = settings;
            return settings;
        }

        public bool Update_Setting<T>(SettingsFields field, T data)
        {
            try
            {
                // Get current settings
                this.Get_Settings();
                
                switch (field)
                {
                    case SettingsFields.ImageFolders:
                        if (data is List<string> folders)
                        {
                            this.settings.ImageFolders = folders;
                        }
                        else
                        {
                            throw new InvalidCastException($"Expected List<string> but got {typeof(T)}.");
                        }
                        break;

                    case SettingsFields.LyricsPath:
                        if (data is string lyricsPath)
                        {
                            this.settings.LyricsPath = lyricsPath;
                        }
                        else
                        {
                            throw new InvalidCastException($"Expected string but got {typeof(T)}.");
                        }
                        break;

                    case SettingsFields.BiblePath:
                        if (data is string biblesPath)
                        {
                            this.settings.BiblesPath = biblesPath;
                        }
                        else
                        {
                            throw new InvalidCastException($"Expected string but got {typeof(T)}.");
                        }
                        break;
                    default:
                        break;
                }

                string updatedSettings = JsonConvert.SerializeObject(this.settings);
                return Write_file(updatedSettings);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating setting: {ex.Message}");
                return false;
            }
        }
    }
}
