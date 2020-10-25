using orderApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace orderApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            Device.SetFlags(new[]
            {
                "SwipeView_Experimental",
                "IndicatorView_Experimental"
            });

            MainPage = new SplashPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
