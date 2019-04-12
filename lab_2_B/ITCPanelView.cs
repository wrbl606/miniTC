using miniTCApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTCNamespace
{
    public interface ITCPanelView
    {
        string CurrentPath { get; set; }
        string CurrentDrive { get; set; }
        string[] Drives { set; }
        event Action LoadDrivesList;
        DirectoryElement[] DirectoryElements { set; }
        event Action LoadDirectoryElements;
        event Action SelectedDriveChanged;
        event Action<string> SubfolderChosen;
    }
}
