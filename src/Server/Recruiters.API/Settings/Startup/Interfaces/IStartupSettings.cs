namespace Recruiters.API.Settings.Startup.Interfaces
{
    public interface IStartupSettings
    {
        public IStartupSettings AddConfiguration(IConfiguration configuration);
        public IConfiguration Configuration { get; }
        public IStartupSettings ConfigureServices(IServiceCollection services);
        public void Configure(WebApplication app);
    }
}
