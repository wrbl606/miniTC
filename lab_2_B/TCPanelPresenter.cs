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
            this.view.SelectedDriveChanged += View_SelectedDriveChanged;
            this.view.SubfolderChosen += View_SubfolderChosen;
        }

        private void View_SubfolderChosen(string obj)
        {
            if (obj == "..") {
                view.CurrentPath = model.DirectoryAbove(view.CurrentPath);
                return;
            }
            view.CurrentPath += $"{obj}\\";
        }

        private void View_SelectedDriveChanged()
        {
            view.CurrentPath = view.CurrentDrive;
        }

        private void View_LoadDirectoryElements()
        {
            view.DirectoryElements = model.GetDirectoryElements(view.CurrentPath).ToArray();
        }

        private void View_LoadDrivesList()
        {
            view.Drives = model.GetDrives();
        }
    }
}
