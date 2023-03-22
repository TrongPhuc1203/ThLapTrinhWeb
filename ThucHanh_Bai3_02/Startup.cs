using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ThucHanh_Bai3_02.Startup))]
namespace ThucHanh_Bai3_02
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
