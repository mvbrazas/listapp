using ListApp.Models;
using ListApp.ViewModels;
using Xamarin.Forms;

namespace ListApp.Views
{	
	public partial class UserPage : ContentPage
	{	
		public UserPage (Person user)
		{
			InitializeComponent ();
			BindingContext = new UserViewModel(user);
		}
	}
}

