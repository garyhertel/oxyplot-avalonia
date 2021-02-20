using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using OxyPlot.Avalonia;

namespace MemoryTest
{
    class App : Application
    {

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
            base.Initialize();
        }

        static void Main(string[] args)
        {
            OxyPlotModule.EnsureLoaded();
            AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace()
                .StartWithClassicDesktopLifetime(args);
        }

        public static void AttachDevTools(Window window)
        {
#if DEBUG
			DevToolsExtensions.AttachDevTools(window);
#endif
        }
    }
}
