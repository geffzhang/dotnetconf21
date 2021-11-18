using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace DotNetConf21.MAUI2
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}