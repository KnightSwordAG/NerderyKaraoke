using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

using Owin;
using Microsoft.Owin;

using NerderyKaraoke.UI;

[assembly: OwinStartup(typeof (Startup))]

namespace NerderyKaraoke.UI
{
	public partial class Startup
	{
		public void Configuration(IAppBuilder app)
		{
			ConfigureInjection(app);

			AreaRegistration.RegisterAllAreas();
			GlobalConfiguration.Configure(WebApiConfig.Register);
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);

			app.MapSignalR();
		}
	}
}