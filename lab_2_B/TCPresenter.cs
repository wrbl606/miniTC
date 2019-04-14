using miniTCApp;
using miniTCNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_B
{
    class TCPresenter
    {
        Model model;
        readonly ITCView view;
        TCPanelPresenter leftPanelPresenter, rightPanelPresenter;

        public TCPresenter (ITCView view, Model model)
        {
            this.view = view;
            this.model = model;
            leftPanelPresenter = new TCPanelPresenter(this.view.LeftPanel, model);
            rightPanelPresenter = new TCPanelPresenter(this.view.RightPanel, model);

            view.Copy += View_Copy;
            view.MoveFile += View_MoveFile;
            view.Delete += View_Delete;
        }

        private void View_Copy()
        {
            model.Copy(leftPanelPresenter.CurrentPath, rightPanelPresenter.CurrentPath);
            ReloadDirectoryElements();
        }

        private void View_MoveFile()
        {
            model.Move(leftPanelPresenter.CurrentPath, rightPanelPresenter.CurrentPath);
            ReloadDirectoryElements();
        }
        private void View_Delete()
        {
            model.Delete(leftPanelPresenter.CurrentPath);
            ReloadDirectoryElements();
        }

        private void ReloadDirectoryElements()
        {
            leftPanelPresenter.ReloadDirectoryElements();
            rightPanelPresenter.ReloadDirectoryElements();
        }
    }
}
