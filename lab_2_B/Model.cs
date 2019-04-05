using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab_2_B
{
    class Model
    {
        public string[] getDrives()
        {
            List<string> drives = new List<string>(Directory.GetLogicalDrives());
            return drives.ToArray();
        }

    }
}
