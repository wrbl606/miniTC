﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using miniTCApp;

namespace miniTCNamespace
{
    class Model
    {
        public string[] GetDrives()
        {
            List<string> drives = new List<string>(Directory.GetLogicalDrives());
            return drives.ToArray();
        }

        public List<DirectoryElement> GetDirectoryElements(string path)
        {
            List<DirectoryElement> elements = new List<DirectoryElement>();
            string[] paths = Directory.GetFileSystemEntries(path);

            for (int i = 0; i < paths.Count(); i++)
            {
                elements.Add(
                    new DirectoryElement(
                        Directory.Exists(paths[i]) ? DirectoryElementType.DIRECTORY : DirectoryElementType.FILE,
                        Path.GetFileName(paths[i])
                    )
                );
            }

            return elements;
        }
    }
}
