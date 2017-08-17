using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalErr.Hubs
{
	public class DemoHub : Hub
	{
		public void SendMessage(string message)
		{
			Clients.Others.SendMessage(message);
		}

		public void UpdateField(string field, string value)
		{
			Clients.Others.UpdateField(field, value);
		}

		public void FocusField(string field)
		{
			Clients.Others.FocusField(field);
		}
	}
}