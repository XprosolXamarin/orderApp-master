using orderApp.Models;
using orderApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace orderApp.View_Models
{
    class Carousel1ViewModel:INotifyPropertyChanged
    {
       
        
       
        public ObservableCollection<CarouselModel> Items1 { get; private set; }

        public Carousel1ViewModel()
        {
            

            Items1 = new ObservableCollection<CarouselModel>();
            Items1.Add(new CarouselModel
            {
                Details = "Life is Succession of lessons which must",
                ImageUrl = "Image1.png"

            });
            Items1.Add(new CarouselModel
            {
                Details = "You Come into the World with nothing, and the Purpose of your life is to make",
                ImageUrl = "Image2.png"

            });
            Items1.Add(new CarouselModel
            {
                Details = "Life is what happens while you are busy",
                ImageUrl = "Image3.png",
                nextImage= "Forward.png",
                getStart="Get Started"

            });

           

        }

        public Command NavigateAppShellpage
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new AppShellPage();

                });
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
