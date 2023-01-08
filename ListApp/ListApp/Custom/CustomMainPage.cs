using System.Windows.Input;
using Xamarin.Forms;

namespace ListApp.Custom
{
	public class CustomMainPage : ContentPage
	{
		public CustomMainPage()
		{
		}

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (AppearedCommand != null)
                AppearedCommand.Execute(null);
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            if (DisappearedCommand != null)
                DisappearedCommand.Execute(null);
        }

        public static readonly BindableProperty AppearedCommandProperty =
            BindableProperty.Create(nameof(AppearedCommand), typeof(ICommand), typeof(CustomMainPage), null);

        public ICommand AppearedCommand
        {
            get { return (ICommand)GetValue(AppearedCommandProperty); }
            set { SetValue(AppearedCommandProperty, value); }
        }

        public static readonly BindableProperty DisappearedCommandProperty =
            BindableProperty.Create(nameof(DisappearedCommand), typeof(ICommand), typeof(CustomMainPage), null);

        public ICommand DisappearedCommand
        {
            get { return (ICommand)GetValue(DisappearedCommandProperty); }
            set { SetValue(DisappearedCommandProperty, value); }
        }
    }
}

