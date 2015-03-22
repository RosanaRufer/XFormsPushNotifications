using System;

using Xamarin.Forms;
using PushNotification.Plugin;

namespace XFormsPushNotifications
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application
			MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart ()
		{
			var see = CrossPushNotification.Current;
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

