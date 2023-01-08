using System.Windows.Input;
using Xamarin.Forms;

namespace ListApp.Custom
{
	public class CustomListView : ListView
	{
		public CustomListView()
		{
			ItemSelected += OnItemSelected;
		}

        private void OnItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (SelectedCommand != null)
                SelectedCommand.Execute(e);
            SelectedItem = null;
        }

        public static readonly BindableProperty SelectedCommandProperty =
            BindableProperty.Create(nameof(SelectedCommand), typeof(ICommand), typeof(CustomListView), null);

        public ICommand SelectedCommand
        {
            get { return (ICommand)GetValue(SelectedCommandProperty); }
            set { SetValue(SelectedCommandProperty, value); }
        }
    }
}

