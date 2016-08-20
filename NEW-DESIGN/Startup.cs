using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MY_DEMO_BLOG.Startup))]
namespace MY_DEMO_BLOG
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
