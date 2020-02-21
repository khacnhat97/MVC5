using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ForJob1.Startup))]
namespace ForJob1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
