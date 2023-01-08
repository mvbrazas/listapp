using System;
using ListApp.Models;

namespace ListApp.ViewModels
{
	public class UserViewModel : BaseViewModel
	{
		public Person _users { get; set; }
		public Person Users { get { return _users; } set { _users = value; NotifyPropertyChanged("Users"); } }

		public UserViewModel(Person user)
		{
			Users = user;
		}
	}
}

