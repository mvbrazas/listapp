using System.ComponentModel;

namespace ListApp.ViewModels
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		public BaseViewModel()
		{
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void NotifyPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

