using Avalonia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_Layout
{
    class Program
    {
        static void Main(string[] args)
        {
            AppBuilder.Configure<App>()
                   .UsePlatformDetect()
                   .Start<MainWindow>();
        }
    }
}
