using Recruiters.API.Settings.Startup.Interfaces;

namespace Recruiters.API.Settings.Startup
{
    public static class WebApplicationSettings
    {
        public static void UseStartup<TStartup>(this WebApplicationBuilder builder) where TStartup : IStartupSettings, new()
        {
            var startup = new TStartup()
                                    .AddConfiguration(builder.Configuration)
                                    .ConfigureServices(builder.Services);

            var app = builder.Build();
            startup.Configure(app);

            app.Run();
        }
    }
}
