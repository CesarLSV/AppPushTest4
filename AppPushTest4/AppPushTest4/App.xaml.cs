using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Com.OneSignal;



[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace AppPushTest4
{
	public partial class App : Application
	{
        public static string MessageFromNotification = "";
        public App ()
		{
			InitializeComponent();

			MainPage = new MainPage();

            OneSignal.Current.StartInit("398c7431-0a94-410d-a933-1bfc462db1e3")
                 .EndInit();


          

        }


  

        protected override void OnStart()
        {
            OneSignal.Current.RegisterForPushNotifications();
        }

        protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
