using System;

namespace XFormsPushNotifications.Services.Contracts
{
	public interface IPushNotificationHandler
	{
		void CreateNotification(string title, string message);
	}
}

