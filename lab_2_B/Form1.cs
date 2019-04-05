﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using miniTCNamespace;

namespace miniTCApp
{
    public partial class Form1 : Form, ITCView
    {
        public Form1()
        {
            InitializeComponent();
        }

        public ITCPanelView LeftPanel => miniTCPanel1;

        public ITCPanelView RightPanel => miniTCPanel2;

        private void MInTCPanel1_SelectedDriveChanege()
        {
            MessageBox.Show("działa");
        }
    }
}
