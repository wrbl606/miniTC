using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab_2_B;

namespace miniTCApp
{
    public partial class Form1 : Form, ITCView
    {
        public Form1()
        {
            InitializeComponent();
            miniTCPanel1.CurrentPath = "c:\\";
            miniTCPanel1.Drives = System.IO.Directory.GetLogicalDrives();
            miniTCPanel1.SelectedDriveChanege += MInTCPanel1_SelectedDriveChanege;

            DirectoryElement[] elements =
            {
                new DirectoryElement(DirectoryElementType.DIRECTORY, "folder"),
                new DirectoryElement(DirectoryElementType.FILE, "niefolder"),
            };
            miniTCPanel1.DirectoryElements = elements;
        }

        public ITCPanelView LeftPanel => miniTCPanel1;

        public ITCPanelView RightPanel => miniTCPanel2;

        private void MInTCPanel1_SelectedDriveChanege()
        {
            MessageBox.Show("działa");
        }
    }
}
