using orderApp.Models;
using orderApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace orderApp.View_Models
{
    class CartViewModel:BaseViewModel
    {
        public ObservableCollection<CartModel> CartItems { get; set; } = new ObservableCollection<CartModel>();
        public CartViewModel()
        {
            CartItems.Add(new CartModel
            {
                Image= "Shirt1.jpg",
                Name="Outfiter",
                Type="XXL",
                Price="2300.00",
                purchasedQty = 1
                

            });
            CartItems.Add(new CartModel
            {
                Image = "Shoes1.png",
                Name = "Service Shoes",
                Type = "XL",
                Price = "2300.00",
                purchasedQty = 1


            });
            CartItems.Add(new CartModel
            {
                Image = "Mobile.jpg",
                Name = "Tecno",
                Type = "Device",
                Price = "2300.00",
                purchasedQty = 1


            });
        }
        public Command<CartModel> RemoveItem
        {
            get
            {
                return new Command<CartModel>((CartModel product) =>
                {
                    CartItems.Remove(product);
                });
            }
        }
        public Command<CartModel> IncreaseQtyCommand
        {
            get
            {
                return new Command<CartModel>((CartModel product) =>
                {
                    product.purchasedQty += 1;
                    //product.totalpurchased = product.totalpurchased * product.purchasedQty;
                });
            }
        }
        public Command<CartModel> DecreaseQtyCommand
        {
            get
            {
                return new Command<CartModel>((CartModel product) =>
                {
                   // product.totalpurchased = product.totalpurchased / product.purchasedQty;
                    product.purchasedQty -= 1;

                });
            }
        }
        public Command CheckOutCommand
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage=new NavigationPage(new CheckoutPage());
                });
            }
        }
       
             public Command NavigateAddressPage
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage=new NavigationPage(new AddressPage());
                });
                   
            }
        }
        public Command NavigatePaymentsCommand
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new NavigationPage(new PaymentsPage());

                });
            }
        }
        public Command NavigateSummaryPage
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new NavigationPage(new SummaryPage());

                });
            }
        }
        public Command NavigateDashboardPage
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage=new AppShellPage();
                    
                });
            }
        }
        public Command NavigateCartPage
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new NavigationPage(new CartPage());

                });
            }
        }
        public Command NavigateOrderAcceptedCommand
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new NavigationPage(new OrderAcceptedPage());

                });
            }
        }
        public Command NavigateOrderTrackPage
        {
            get
            {
                return new Command(() =>
                {
                    Application.Current.MainPage = new NavigationPage(new LoginPage());

                });
            }
        }
    }
}
