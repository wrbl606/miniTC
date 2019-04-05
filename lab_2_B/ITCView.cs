using lab_2_B;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniTCApp
{
    public interface ITCView
    {
        ITCPanelView LeftPanel { get; }
        ITCPanelView RightPanel { get; }
    }
}
