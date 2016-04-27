﻿using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Windows.Forms;
using FEFTwiddler.Extensions;

namespace FEFTwiddler
{
    public static class Config
    {
        private static string _configPath = Application.StartupPath + "\\Config.xml";

        public static string StartupPath
        {
            get
            {
                var root = GetConfigRoot();
                var settings = root.Elements("misc").First();
                return settings.GetAttribute("startupPath");
            }
            set
            {
                var root = GetConfigRoot();
                var settings = root.Elements("misc").First();
                settings.SetAttributeValue("startupPath", value);
                SetConfigRoot(root);
            }
        }

        private static XElement GetConfigRoot()
        {
            try
            {
                return XDocument.Load(_configPath).Root;
            }
            catch (FileNotFoundException)
            {
                return XDocument.Parse(@"<?xml version=""1.0"" encoding=""utf-8"" ?>
<root>
  <misc startupPath="""" />
</root>
                ").Root;
            }
        }

        private static void SetConfigRoot(XElement root)
        {
            root.Document.Save(_configPath);
        }
    }
}
