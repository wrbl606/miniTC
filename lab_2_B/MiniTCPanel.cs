using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using miniTCNamespace;

namespace miniTCApp
{
    public partial class MiniTCPanel : UserControl, ITCPanelView
    {
        public string CurrentPath
        {
            get
            {
                return textBox1.Text;
            }

            set
            {
                textBox1.Text = value;
            }
        }

        public string[] Drives
        {
            set
            {
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(value);
            }
        }

        public DirectoryElement[] DirectoryElements
        {
            set
            {
                listView1.Items.Clear();
                foreach (DirectoryElement element in value)
                {
                    ListViewItem listViewItem = new ListViewItem();
                    listViewItem.Text = element.ToString();
                    listView1.Items.Add(listViewItem);
                }
            }
        }
        #region Prop

        #endregion

        #region Events
        public event Action SelectedDriveChange;
        public event Action LoadDrivesList;
        public event Action LoadDirectoryElements;
        #endregion

        public MiniTCPanel()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) => LoadDirectoryElements?.Invoke();

        private void comboBox1_Click(object sender, EventArgs e)
        {
            LoadDrivesList?.Invoke();
        }
    }
}
