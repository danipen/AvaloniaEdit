using Avalonia.ReactiveUI;
using Avalonia.Web.Blazor;

namespace AvaloniaEdit.Web;

public partial class App
{
    static App()
    {
        AvaloniaEdit.Base.App.EnableInputOutput = false;
    }

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        WebAppBuilder.Configure<AvaloniaEdit.Base.App>()
            .UseReactiveUI()
            .SetupWithSingleViewLifetime();
    }
}
