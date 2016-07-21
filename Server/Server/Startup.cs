using Microsoft.Owin;
[assembly: OwinStartup(typeof(Server.Startup))]

namespace Server
{
	#region Using
	using App_Start;
	using Owin;
	using System.Web.Http;
	#endregion
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			HttpConfiguration config = new HttpConfiguration();

			ContainerConfig.Config(config);
			WebApiConfig.Register(config);

			app.UseWebApi(config);
		}
	}
}
