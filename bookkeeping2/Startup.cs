using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(bookkeeping2.Startup))]
namespace bookkeeping2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
