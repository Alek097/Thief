﻿namespace Server.App_Start
{
	#region Using
	using Infrastructure;
	using Microsoft.Practices.Unity;
	using System.Web.Http;
	using System.Web.Http.Dispatcher;
	using System.Web.Mvc;
	#endregion
	public static class ContainerConfig
	{
		public static void Config(HttpConfiguration config)
		{
			var container = new UnityContainer();
			MapTypes(container);

			// Set resolver to MVC.
			var controllerActivator = new UnityControllerActivator(container);
			ControllerBuilder.Current.SetControllerFactory(new DefaultControllerFactory(controllerActivator));

			// Set resolver to WebApi.
			var httpControllerActivator = new UnityHttpControllerActivator(container);
			GlobalConfiguration.Configuration.Services.Replace(typeof(IHttpControllerActivator), httpControllerActivator);

			config.DependencyResolver = new UnityResolver(container);
		}

		private static void MapTypes(IUnityContainer container)
		{

		}
	}
}