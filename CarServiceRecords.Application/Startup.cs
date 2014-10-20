using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CarServiceRecords.Application.Startup))]

namespace CarServiceRecords.Application
{
    public partial class Startup 
    {
        public void Configuration(IAppBuilder app) 
        {
            ConfigureAuth(app);
        }
    }
}
