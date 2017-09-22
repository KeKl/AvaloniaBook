using Avalonia;
using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_5_CreateApplication_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .SetupWithoutStarting();
        }
    }

    public class MainWindow : Window
    {
        public MainWindow()
        {
            Title = "This is my first avalonia window!";
        }
    }
}
