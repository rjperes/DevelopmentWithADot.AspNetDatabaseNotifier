using System;
using System.Web;
using DevelopmentWithADot.AspNetDatabaseNotifier.Test;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Global))]

namespace DevelopmentWithADot.AspNetDatabaseNotifier.Test
{
	public class Global : HttpApplication
	{
		public static void Configuration(IAppBuilder app)
		{
			app.MapSignalR();
		}

		protected void Application_Start(Object sender, EventArgs e)
		{
			var notifier = new ChangeNotifier();
			notifier.Change += this.OnChange;
			//change this appropriately
			notifier.Start("MyDatabase", "SELECT Id FROM dbo.MyTable");
		}

		private void OnChange(object sender, ChangeEventArgs e)
		{
			var context = GlobalHost.ConnectionManager.GetHubContext<ChangeNotificationHub>();
			context.Clients.All.OnChange(e.Info, e.Source, e.Type);
		}
	}
}