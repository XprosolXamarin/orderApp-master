using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace orderApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SplashPage : ContentPage
    {
        public SplashPage()
        {
            InitializeComponent();
            _ = DelayFun();
        }

        public async Task<int> DelayFun()
        {
            await Task.Delay(3000);
            Application.Current.MainPage = new NavigationPage(new CarouselPage1());
            return 1;
           
        }
    }
}