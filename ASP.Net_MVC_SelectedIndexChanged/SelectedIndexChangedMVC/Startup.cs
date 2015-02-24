using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SelectedIndexChangedMVC.Startup))]
namespace SelectedIndexChangedMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
