using System;
using PushNotification.Plugin;
using PushNotification.Plugin.Abstractions;
using System.Collections.Generic;
using Xamarin.Forms;
using XFormsPushNotifications.Services.Contracts;

namespace XFormsPushNotifications
{
	public class CrossPushNotificationListener:IPushNotificationListener
	{
		IPushNotificationHandler _pushNotificationHandler;

		public CrossPushNotificationListener ()
		{
			_pushNotificationHandler = DependencyService.Get<IPushNotificationHandler> ();
		}
		public void OnMessage (IDictionary<string, object> Parameters, DeviceType deviceType)
		{
			_pushNotificationHandler.CreateNotification ("ARRIVED", "OK");
		}

		public void OnRegistered (string Token, DeviceType deviceType)
		{
			
		}

		public void OnUnregistered (DeviceType deviceType)
		{
			
		}

		public void OnError (string message, DeviceType deviceType)
		{
			
		}
	}
}

