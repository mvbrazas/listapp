using System;
using System.Collections.Generic;
using System.Windows.Input;
using ListApp.Models;
using Xamarin.Forms;

namespace ListApp.ViewModels
{
	public class MainViewModel : BaseViewModel
	{
        public List<Person> _users { get; set; }
        public List<Person> Users { get { return _users; } set { _users = value; NotifyPropertyChanged("Users"); } }

        private bool _init = true;

        public ICommand OnAppearing
        {
            get
            {
                return new Command(async () =>
                {
                    try
                    {
                        if (_init)
                        {
                            Users = await App.UserService.GetUsers();
                            _init = false;
                        }
                    }
                    catch (Exception ex)
                    {
                        App.Log(ex.ToString());
                    }
                });
            }
        }

        public ICommand UserTapCommand
        {
            get
            {
                return new Command(async p =>
                {
                    try
                    {
                        var args = p as SelectedItemChangedEventArgs;
                        var selectedItem = args.SelectedItem;
                        if (selectedItem != null)
                        {
                            var user = selectedItem as Person;
                            if (user != null)
                                await App.NavigationService.OpenUserPage(user);
                        }
                    }
                    catch (Exception ex)
                    {
                        App.Log(ex.ToString());
                    }
                });
            }
        }
    }
}

