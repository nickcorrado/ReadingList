using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ReadingList.Startup))]
namespace ReadingList
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
