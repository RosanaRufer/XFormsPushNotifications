using System;
using XFormsPushNotifications.Services.Contracts;
using Xamarin.Forms;

namespace XFormsPushNotifications
{
	public class MainViewModel : BaseViewModel
	{
		#region Fields

		private string _title;
		private string _instructionsText;
		private IPushNotificationHandler _pushNotificationHandler;

		#endregion

		#region Constructor

		public MainViewModel ()
		{
			_title = "XForms Push Notifications";
			_instructionsText = AppConstants.StaticText.MainPage_IntroductionText;
			_pushNotificationHandler = DependencyService.Get<IPushNotificationHandler> ();
			TriggerPushNotificationCommand = new Command (TriggerPushNotification);
		}

		#endregion

		#region Commands
		public Command TriggerPushNotificationCommand { get; set; }
		private void TriggerPushNotification()
		{
			_pushNotificationHandler.CreateNotification ("Ok, It works", "Next step is triggering the Push Notification from Azure");
		}
		#endregion

		#region Properties

		public string Title {
			get { return _title; }
			set {
				_title = value;
				RaisePropertyChanged ();
			}
		}
		public string InstructionsText {
			get { return _instructionsText; }
			set {
				_instructionsText = value;
				RaisePropertyChanged ();
			}
		}

		#endregion

		#region Methods

		#endregion
	}
}

