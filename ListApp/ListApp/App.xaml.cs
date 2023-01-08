using Xamarin.Forms;
using Kapamilya.Services;
using ListApp.Services;

namespace ListApp
{
    public partial class App : Application
    {
        public App ()
        {
            InitializeComponent();

            NavigationService.ConfigurePages();
            MainPage = NavigationService.SetRootPage("MainPage");
        }

        protected override void OnStart ()
        {
        }

        protected override void OnSleep ()
        {
        }

        protected override void OnResume ()
        {
        }

        static RestService restService;
        public static RestService RestService
        {
            get
            {
                if (restService == null)
                {
                    restService = new RestService();
                }
                return restService;
            }
        }

        static UserService userService;
        public static UserService UserService
        {
            get
            {
                if (userService == null)
                {
                    userService = new UserService();
                }
                return userService;
            }
        }

        static NavigationService navigationService;
        public static NavigationService NavigationService
        {
            get
            {
                if (navigationService == null)
                {
                    navigationService = new NavigationService();
                }
                return navigationService;
            }
        }

        public static void Log(string message)
        {
            LogService.SetDebug(message);
        }
    }
}

