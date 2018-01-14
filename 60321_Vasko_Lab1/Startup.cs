using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_60321_Vasko_Lab1.Startup))]
namespace _60321_Vasko_Lab1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
