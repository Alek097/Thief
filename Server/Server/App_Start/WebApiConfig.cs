namespace Server.App_Start
{
	#region Using
	using System.Web.Http;
	#endregion
	public static class WebApiConfig
	{
		public static void Register(HttpConfiguration config)
		{
			config.Routes.MapHttpRoute(
				"API Default",
				"api/{controller}/{action}",
				new { id = RouteParameter.Optional }
			);

			config.MapHttpAttributeRoutes();

		}
	}
}
