using Core.Services;
using Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Owin;
using Owin;
using Services;
using System.Web.Mvc;
using Web.App_Start; //really not sure this should be here. makes me nervous

[assembly: OwinStartupAttribute(typeof(Web.Startup))]
namespace Web
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
            services.AddTransient(typeof(UnitOfWork));

            services.AddTransient(typeof(UserStore));
            services.AddTransient(typeof(RoleStore));
            services.AddTransient(typeof(ApplicationUserManager));
            services.AddTransient(typeof(ApplicationSignInManager));

            services.AddTransient(typeof(UserBookService));
        }
    }
}
