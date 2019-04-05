using lab_2_B;
using miniTCNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miniTCApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Model model = new Model();
            ITCView view = new Form1();
            TCPresenter tcPresenter = new TCPresenter(view, model);

            Application.Run((Form) view);
        }
    }
}
