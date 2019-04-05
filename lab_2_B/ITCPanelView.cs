using miniTCApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_B
{
    public interface ITCPanelView
    {
        string CurrentPath { get; set; }
        string[] Drives { set; }
        event Action LoadDrivesList;
        DirectoryElement[] DirectoryElements { set; }
        event Action LoadDirectoryElements;
    }
}
