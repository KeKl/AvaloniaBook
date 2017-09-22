using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_3_ContentControls_Button
{
    public class MainViewModel : ReactiveObject
    {
        public MainViewModel()
        {
            ClickCommand = ReactiveCommand.Create();
            ClickCommand.Subscribe(o => 
            { 
                // Do Something 

            });

            ButtonClickEventCommand = ReactiveCommand.Create();
            ButtonClickEventCommand.Subscribe(o =>
            {
                // Do Something 

            });
        }

        public ReactiveCommand<object> ClickCommand { get; set; }

        public ReactiveCommand<object> ButtonClickEventCommand { get; set; }
    }
}
