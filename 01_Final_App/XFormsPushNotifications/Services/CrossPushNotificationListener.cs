using System;
using PushNotification.Plugin;
using PushNotification.Plugin.Abstractions;
using System.Collections.Generic;
using Xamarin.Forms;
using XFormsPushNotifications.Services.Contracts;
using Microsoft.WindowsAzure.MobileServices;

namespace XFormsPushNotifications.Services
{
	public class CrossPushNotificationListener:IPushNotificationListener
	{
		IPushNotificationHandler _pushNotificationHandler;
		IAzureNotificationHubService _azureNotificationHubService;

		public CrossPushNotificationListener ()
		{
			_pushNotificationHandler = DependencyService.Get<IPushNotificationHandler> ();
			_azureNotificationHubService = DependencyService.Get<IAzureNotificationHubService> (); 
		}
		public void OnMessage (IDictionary<string, object> Parameters, DeviceType deviceType)
		{
			_pushNotificationHandler.CreateNotification ("ARRIVED", "OK");
		}

		public async void OnRegistered (string Token, DeviceType deviceType)
		{
			await _azureNotificationHubService.UnregisterNativeAsync ();
			try{
			await _azureNotificationHubService.RegisterNativeAsync (Token);
			}
			catch(Exception exception){
			}
		}

		public async void OnUnregistered (DeviceType deviceType)
		{
			await _azureNotificationHubService.UnregisterNativeAsync ();
		}

		public void OnError (string message, DeviceType deviceType)
		{
			
		}
	}
}

