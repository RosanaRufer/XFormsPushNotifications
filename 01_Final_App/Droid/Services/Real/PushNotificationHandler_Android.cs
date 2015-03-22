using System;
using XFormsPushNotifications.Services.Contracts;
using Android.Content;
using Android.App;
using Xamarin.Forms;
using XFormsPushNotifications.Droid.Services.Real;

[assembly: Dependency(typeof(PushNotificationHandler_Android))]
namespace XFormsPushNotifications.Droid.Services.Real
{
	public class PushNotificationHandler_Android:IPushNotificationHandler
	{
		public PushNotificationHandler_Android ()
		{
		}

		public void CreateNotification (string title, string message)
		{
			//Create notification
			var context = Xamarin.Forms.Forms.Context;
			var notificationManager = context.GetSystemService (Context.NotificationService) as NotificationManager;

			//Create an intent to show ui
			var uiIntent = new Intent (context, typeof(MainActivity));

			//Create the notification
			var notification = new Notification (Android.Resource.Drawable.SymActionEmail, title);

			//Auto cancel will remove the notification once the user touches it
			notification.Flags = NotificationFlags.AutoCancel;

			//Set the notification info
			//we use the pending intent, passing our ui intent over which will get called
			//when the notification is tapped.
			notification.SetLatestEventInfo (context, title, message, PendingIntent.GetActivity (context, 0, uiIntent, 0));

			//Show the notification
			notificationManager.Notify (1, notification);

		}
	}
}

