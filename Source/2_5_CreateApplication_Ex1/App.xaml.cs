using Avalonia;
using Avalonia.Markup.Xaml;

namespace _2_5_CreateApplication_Ex1
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
