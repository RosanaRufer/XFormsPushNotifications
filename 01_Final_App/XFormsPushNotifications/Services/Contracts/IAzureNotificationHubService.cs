using System;
using System.Threading.Tasks;

namespace XFormsPushNotifications.Services.Contracts
{
	public interface IAzureNotificationHubService
	{
		Task RegisterNativeAsync(string registrationId);
		Task UnregisterNativeAsync ();
	}
}

