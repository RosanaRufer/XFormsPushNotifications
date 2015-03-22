using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XFormsPushNotifications
{
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
			BindingContext = new MainViewModel ();
		}
	}
}

