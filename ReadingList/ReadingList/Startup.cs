using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReadingList.Startup))]
namespace ReadingList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var services = new ServiceCollection();

            //this will happen
            //ConfigureServices(services);

            ConfigureAuth(app);

            services.BuildServiceProvider();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient(typeof(Models.ApplicationDbContext));
        }
    }
}
