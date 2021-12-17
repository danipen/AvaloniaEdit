using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Controls.Platform;
using Avalonia.Markup.Xaml;
using System;

namespace AvaloniaEdit.Base
{
    public class App : Application
    {
        public static bool EnableInputOutput { get; set; } = true;

        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktopLifetime)
            {

                var window = new MainWindow();

                desktopLifetime.MainWindow = window;
            }
            else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewLifetime)
            {
                singleViewLifetime.MainView = new MainView();
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
