using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3_ContentControls_ToolTip_Expander
{
    public class MainViewModel : ReactiveObject
    {

        private bool _expanderIsOpen;

        public bool ExpanderIsOpen
        {
            get
            {
                return _expanderIsOpen;
            }
            set
            {
                this.RaiseAndSetIfChanged(ref _expanderIsOpen, value);
            }
        }
    }
}
