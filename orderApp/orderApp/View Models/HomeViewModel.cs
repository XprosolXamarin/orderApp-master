using orderApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace orderApp.View_Models
{
   public class HomeViewModel
    {
        public Command NavigateToHomePage
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new AppShellPage();
                });
            }
        }

    }
}
