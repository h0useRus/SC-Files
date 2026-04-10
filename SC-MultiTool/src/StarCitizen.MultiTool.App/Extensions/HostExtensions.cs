using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace NSW.StarCitizen.MultiTool.Extensions;

internal static class HostExtensions
{
    extension(HostApplicationBuilder hostBuilder)
    {
        public HostApplicationBuilder AddAppServices()
        {
            hostBuilder.Services.AddSingleton(TimeProvider.System);
            hostBuilder.Services.AddSingleton<Themes.ThemeManager>();
            return hostBuilder;
        }

        public HostApplicationBuilder AddAppForms()
        {
            hostBuilder.Services.AddSingleton<Forms.MainForm>();
            return hostBuilder;
        }
    }

    extension(IHost host)
    {
        public void RunApp()
        {
            var mainForm = host.Services.GetRequiredService<Forms.MainForm>();
            Application.Run(mainForm);
        }
    }
}
