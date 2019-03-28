using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_2_B
{
    public partial class MiniTCPanel : UserControl
    {
        #region Prop
        public string CurrentPath
        {
            get {
                return textBox1.Text;
            }
            set {
                textBox1.Text = value;
            }
        }
        public string[] Drives
        {
            set
            {
               comboBox1.Items.AddRange(value);
            }
        }

        public DirectoryElement[] DirectoryElements
        {
            set
            {
                foreach (DirectoryElement element in value)
                {
                    listView1.Items.Add(new ListViewItem(element.ToString()));
                }
            }
        } 

        #endregion

        #region Events
        public event Action SelectedDriveChanege;
        #endregion

        public MiniTCPanel()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) => SelectedDriveChanege?.Invoke();
    }
}
