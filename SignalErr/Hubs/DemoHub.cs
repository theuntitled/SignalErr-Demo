using Microsoft.AspNet.SignalR;

namespace SignalErr.Hubs
{
	public class DemoHub : Hub
	{
		public void UpdateField(string clientId, string field, string value)
		{
			Clients.Others.UpdateField(clientId, field, value);
		}

		public void BlurField(string clientId, string field)
		{
			Clients.Others.BlurField(clientId, field);
		}

		public void FocusField(string clientId, string field)
		{
			Clients.Others.FocusField(clientId, field);
		}
	}
}
