using System;
using XFormsPushNotifications.Services.Contracts;
using UIKit;
using Xamarin.Forms;
using XFormsPushNotifications.iOS.Services.Real;

[assembly: Dependency(typeof(PushNotificationHandler_iOS))]
namespace XFormsPushNotifications.iOS.Services.Real
{
	public class PushNotificationHandler_iOS: IPushNotificationHandler
	{
		public PushNotificationHandler_iOS ()
		{
		}

		public void CreateNotification (string title, string message)
		{
			var avAlert = new UIAlertView (title, message, null, "OK", null);
			avAlert.Show ();
		}
	}
}

