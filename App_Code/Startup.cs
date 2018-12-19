using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(mini_project2018.Startup))]
namespace mini_project2018
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
