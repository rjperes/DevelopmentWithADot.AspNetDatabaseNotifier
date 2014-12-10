using System;
using Microsoft.AspNet.SignalR;

namespace DevelopmentWithADot.AspNetDatabaseNotifier.Test
{
	public class ChangeNotificationHub : Hub
	{
		public void OnChange(Int32 info, Int32 source, Int32 type)
		{
			this.Clients.All.onChange(info, source, type);
		}
	}
}