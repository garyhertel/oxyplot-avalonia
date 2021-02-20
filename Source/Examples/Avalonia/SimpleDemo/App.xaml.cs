using Avalonia;
using Avalonia.Markup.Xaml;
using OxyPlot.Avalonia;

namespace SimpleDemo
{
    class App : Application
    {
        public App()
        {
            RegisterServices();
        }

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            base.Initialize();
        }

        public static void Main(string[] args)
        {
            OxyPlotModule.EnsureLoaded();
            AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .StartWithClassicDesktopLifetime(args);
        }
    }
}
