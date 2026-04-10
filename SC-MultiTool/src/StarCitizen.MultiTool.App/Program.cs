using Microsoft.Extensions.Hosting;

using NSW.StarCitizen.MultiTool.Extensions;

namespace NSW.StarCitizen.MultiTool.App;

internal static class Program
{
    [STAThread]
    private static void Main(string[] args)
    {
        ApplicationConfiguration.Initialize();

        var host = Host.CreateApplicationBuilder(args)
            .AddAppServices()
            .AddAppForms()
            .Build();

        host.RunApp();
    }
}
