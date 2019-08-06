﻿using Funq;
using ServiceStack;
using WebApplication1.ServiceInterface;

namespace WebApplication1
{
	//VS.NET Template Info: https://servicestack.net/vs-templates/EmptyAspNet
	public class AppHost : AppHostBase
	{
		/// <summary>
		/// Base constructor requires a Name and Assembly where web service implementation is located
		/// </summary>
		public AppHost()
			: base("WebApplication1", typeof(MyServices).Assembly) { }

		/// <summary>
		/// Application specific configuration
		/// This method should initialize any IoC resources utilized by your web service classes.
		/// </summary>
		public override void Configure(Container container)
		{
			Plugins.Add(new ServiceStack.Api.Swagger.SwaggerFeature { });
			//Config examples
			//this.Plugins.Add(new PostmanFeature());
			//this.Plugins.Add(new CorsFeature());
		}
	}
}