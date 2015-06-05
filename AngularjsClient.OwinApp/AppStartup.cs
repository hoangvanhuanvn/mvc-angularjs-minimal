using AngularjsClient.OwinApp;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AppStartup))]

namespace AngularjsClient.OwinApp
{
    public class AppStartup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            
        }
    }
}