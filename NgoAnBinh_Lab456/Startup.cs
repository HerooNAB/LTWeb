using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NgoAnBinh_Lab456.Startup))]
namespace NgoAnBinh_Lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
