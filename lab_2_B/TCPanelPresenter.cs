using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTCNamespace
{
    class TCPanelPresenter
    {
        ITCPanelView view;
        Model model;

        public TCPanelPresenter(ITCPanelView view, Model model) {
            this.view = view;
            this.model = model;

            this.view.LoadDrivesList += View_LoadDrivesList;
            this.view.LoadDirectoryElements += View_LoadDirectoryElements;
        }

        private void View_LoadDirectoryElements()
        {
            view.DirectoryElements = model.GetDirectoryElements("C:\\").ToArray();
        }

        private void View_LoadDrivesList()
        {
            view.Drives = model.GetDrives();
        }
    }
}
