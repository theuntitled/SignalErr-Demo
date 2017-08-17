using Microsoft.Owin;
using MyWebApplication;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace MyWebApplication
{
	public class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			app.MapSignalR();
		}
	}
}
