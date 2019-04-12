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
        ITCView view;
        TCPanelPresenter leftPanelPresenter, rightPanelPresenter;

        public TCPresenter (ITCView view, Model model)
        {
            this.view = view;
            this.model = model;
            leftPanelPresenter = new TCPanelPresenter(this.view.LeftPanel, model);
            rightPanelPresenter = new TCPanelPresenter(this.view.RightPanel, model);
        }

        
    }
}
