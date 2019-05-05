using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(first_primer.Startup))]
namespace first_primer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
