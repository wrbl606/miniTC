using System;
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

            elements.Add(new DirectoryElement(
                DirectoryElementType.DIRECTORY,
                ".."
            ));
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

        public string DirectoryAbove(string path)
        {
            string parentPath = path;
            if (path.Last() == '\\'&& path.Length > 3) parentPath = Directory.GetParent(parentPath)?.FullName;
            return Directory.GetParent(parentPath)?.FullName ?? path;
        }

        public bool IsDirectory(string path) => Directory.Exists(path);

        public bool IsFile(string path) => File.Exists(path);

        public void Copy(string sourcePath, string destinationPath)
        {
            if (IsFile(sourcePath) && IsFile(destinationPath))
            {
                File.Copy(sourcePath, DirectoryAbove(destinationPath));
            } else if (IsFile(sourcePath) && IsDirectory(destinationPath))
            {
                string fileName = Path.GetFileName(sourcePath);
                string destinationFile = Path.Combine(destinationPath, fileName);
                File.Copy(sourcePath, destinationFile, true);
            }
            else if (IsDirectory(sourcePath) && IsFile(destinationPath))
            {
                string[] files = Directory.GetFiles(sourcePath);
                foreach (string s in files)
                {
                    string fileName = Path.GetFileName(s);
                    string destinationFile = Path.Combine(DirectoryAbove(destinationPath), fileName);
                    File.Copy(s, destinationFile, true);
                }
            }
            else if (IsDirectory(sourcePath) && IsDirectory(destinationPath))
            {
                string[] files = Directory.GetFiles(sourcePath);
                foreach (string s in files)
                {
                    string fileName = Path.GetFileName(s);
                    string destinationFile = Path.Combine(destinationPath, fileName);
                    File.Copy(s, destinationFile, true);
                }
            }
        }

        public void Move(string sourcePath, string destinationPath)
        {
            if (IsFile(sourcePath) && IsFile(destinationPath))
            {
                File.Move(sourcePath, DirectoryAbove(destinationPath));
            }
            else if (IsFile(sourcePath) && IsDirectory(destinationPath))
            {
                File.Move(sourcePath, destinationPath);
            }
            else if (IsDirectory(sourcePath) && IsFile(destinationPath))
            {
                Directory.Move(sourcePath, DirectoryAbove(destinationPath));
            }
            else if (IsDirectory(sourcePath) && IsDirectory(destinationPath))
            {   
                Directory.Move(sourcePath, destinationPath);
            }
        }

        public void Delete(string sourcePath)
        {
            if (IsFile(sourcePath))
            {
                File.Delete(sourcePath);
            }
            else if (IsDirectory(sourcePath))
            {
                Directory.Delete(sourcePath, true);
            }
        }
    }
}
