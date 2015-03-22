using System;
using Microsoft.WindowsAzure.MobileServices;
using System.Threading.Tasks;
using Xamarin.Forms;
using XFormsPushNotifications.Droid;
using XFormsPushNotifications.Services.Contracts;

[assembly: Dependency(typeof(AzureNotificationHubService_Android))]
namespace XFormsPushNotifications.Droid
{
	public class AzureNotificationHubService_Android:IAzureNotificationHubService
	{
		private MobileServiceClient _mobileServiceClient;
		private Push _push;

		public string _currentRegistrationId { get; private set; }

		public AzureNotificationHubService_Android ()
		{
			_mobileServiceClient = new MobileServiceClient (AppConstants.Keys.AzureMobileService_URL, AppConstants.Keys.AzureMobileService_KEY); 
			_push = _mobileServiceClient.GetPush ();
		}

		public async Task UnregisterNativeAsync ()
		{
			await _push.UnregisterNativeAsync ();
		}

		public async Task RegisterNativeAsync (string registrationId)
		{
			_currentRegistrationId = registrationId;

			await _push.RegisterNativeAsync (registrationId);
		}
	}
}

