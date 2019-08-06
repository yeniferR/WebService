using Funq;
using ServiceStack;
using ServiceStack.Api.OpenApi;
using ServiceStack.Api.Swagger;
using System;
using WebApplication1.ServiceInterface;

namespace WebApplication1
{
	public class Global : System.Web.HttpApplication
	{
		public class AppHost : AppHostBase
		{
			//Tell ServiceStack the name of your application and where to find your services
			public AppHost() : base("Hola Yenifer", typeof(MyServices).Assembly) { }

			public override void Configure(Container container)
			{
				//register any dependencies your services use, e.g:
				//container.Register<ICacheClient>(new MemoryCacheClient());
				//Plugins.Add(new SwaggerFeature());
				Plugins.Add(new OpenApiFeature());
			}
		}

		//Initialize your application singleton
		protected void Application_Start(object sender, EventArgs e)
		{
			new AppHost().Init();
		}
	}

}