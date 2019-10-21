using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using ReadingList.App_Start; //really not sure this should be here. makes me nervous
using Services;
using System.Web.Mvc;

[assembly: OwinStartupAttribute(typeof(ReadingList.Startup))]
namespace ReadingList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            var services = new ServiceCollection();

            ConfigureServices(services);

            ConfigureAuth(app);

            var resolver = new DefaultDependencyResolver(services.BuildServiceProvider());
            DependencyResolver.SetResolver(resolver);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient(typeof(UserStore));
            services.AddTransient(typeof(RoleStore));
            services.AddTransient(typeof(ApplicationUserManager));
            services.AddTransient(typeof(ApplicationSignInManager));

            services.AddTransient(typeof(UserBookService));
        }
    }
}
