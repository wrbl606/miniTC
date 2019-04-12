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
            this.view.SubfolderChosen += View_SubpathChosen;

            Init();
        }

        private void Init()
        {
            string[] drives = model.GetDrives();
            view.Drives = drives;
            view.CurrentPath = drives[0];
            view.CurrentDrive = drives[0];
            View_LoadDirectoryElements();
        }

        private void View_SubpathChosen(string obj)
        {
            string newPath = view.CurrentPath;

            if (obj == "..")
            {
                view.CurrentPath = model.DirectoryAbove(view.CurrentPath);
                return;
            }

            if (model.IsFile(view.CurrentPath))
                newPath = model.DirectoryAbove(view.CurrentPath);

            newPath += $"{obj}{ (model.IsDirectory(newPath + obj) ? "\\" : "") }";
            view.CurrentPath = newPath;
        }

        private void View_SelectedDriveChanged()
        {
            view.CurrentPath = view.CurrentDrive;
        }

        private void View_LoadDirectoryElements()
        {
            if (model.IsDirectory(view.CurrentPath))
                view.DirectoryElements = model.GetDirectoryElements(view.CurrentPath).ToArray();
        }

        private void View_LoadDrivesList()
        {
            view.Drives = model.GetDrives();
        }
    }
}
