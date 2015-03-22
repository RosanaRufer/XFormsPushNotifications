using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using PushNotification.Plugin;

[assembly: Permission (Name = "@PACKAGE_NAME@.permission.C2D_MESSAGE")]
[assembly: UsesPermission (Name = "@PACKAGE_NAME@.permission.C2D_MESSAGE")]
[assembly: UsesPermission (Name = "com.google.android.c2dm.permission.RECEIVE")]
[assembly: UsesPermission (Name = "android.permission.GET_ACCOUNTS")]
[assembly: UsesPermission (Name = "android.permission.INTERNET")]
[assembly: UsesPermission (Name = "android.permission.WAKE_LOCK")]

namespace XFormsPushNotifications.Droid
{
	[Activity (Label = "XFormsPushNotifications.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			

			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			CrossPushNotification.Initialize<CrossPushNotificationListener>(AppConstants.Keys.GOOGLE_APIs_ID);

			LoadApplication (new App ());
		}
	}
}

