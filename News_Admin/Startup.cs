using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(News_Admin.Startup))]
namespace News_Admin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
