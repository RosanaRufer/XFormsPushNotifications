using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XFormsPushNotifications
{
	public class BaseViewModel:INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public void RaisePropertyChanged ([CallerMemberName]string propertyName = "")
		{
			var handler = PropertyChanged;
			if (handler != null)
				handler (this, new PropertyChangedEventArgs (propertyName));
		}
	}
}

